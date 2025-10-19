using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Drawing.Imaging;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace trabalho_linguagem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            RespostaApi respostaApi = new RespostaApi();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Cadastro de jogos";
        }

        public string TruncarDescricao(string descricao)
        {
            const int MaxDescricaoLength = 100; // Defina o limite de caracteres
            if (descricao.Length > MaxDescricaoLength)
            {
                return descricao.Substring(0, MaxDescricaoLength) + "..."; // Adiciona "..." ao final
            }
            return descricao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /*private async Task<Jogos?> BuscarJogoPorIdAsync(int id)
        {
            using HttpClient client = new HttpClient();
            try
            {
                string apiKey = "23b8648e1de24da8be568f63d9e1140b"; // Verifique se esta chave é válida
                string url = $"https://api.rawg.io/api/games/{id}?key={apiKey}";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                Console.WriteLine(json); // Registra a resposta JSON

                var rawg = JsonConvert.DeserializeObject<RespostaApi>(json);

                var jogo = new Jogos
                {
                    Id = rawg.Id,
                    Nome = rawg.Name,
                    Plataforma = rawg.Platforms?[0]?.Platform?.Name ?? "Desconhecida",
                    DataLancamento = DateTime.TryParse(rawg.Released, out DateTime dt) ? dt : DateTime.MinValue,
                    ImagemUrl = rawg.BackgroundImage,
                    Rating = rawg.Rating,
                    Metacritic = rawg.Metacritic,
                    Generos = rawg.Genres.Select(g => g.Name).ToList(), // Adiciona os gêneros
                    Desenvolvedores = rawg.Developers.Select(d => d.Name).ToList(), // Adiciona os desenvolvedores
                    Publicadores = rawg.Publishers.Select(p => p.Name).ToList(), // Adiciona os publicadores
                };

                return jogo;
            }
            catch (JsonException jsonEx)
            {
                MessageBox.Show("Erro ao deserializar JSON: " + jsonEx.Message);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar jogo: " + ex.Message);
                return null;
            }
        }
        */

        private async Task<Jogos?> BuscarJogosPorNomeAsync(string nome)
        {
            using HttpClient client = new HttpClient();
            try
            {
                string apiKey = "23b8648e1de24da8be568f63d9e1140b";
                string url = $"https://api.rawg.io/api/games?search={nome}&key={apiKey}";

                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var resultadoBusca = JsonConvert.DeserializeObject<RespostaApi>(json);

                var primeiroJogo = resultadoBusca?.Results?.FirstOrDefault();
                if (primeiroJogo == null)
                    return null;

                return new Jogos
                {
                    Id = primeiroJogo.Id,
                    Nome = primeiroJogo.Name,
                    Plataforma = primeiroJogo.Platforms?.FirstOrDefault()?.Platform?.Name ?? "Desconhecida",
                    DataLancamento = DateTime.TryParse(primeiroJogo.Released, out DateTime dt) ? dt : DateTime.MinValue,
                    ImagemUrl = primeiroJogo.BackgroundImage,
                    Rating = primeiroJogo.Rating,
                    Metacritic = primeiroJogo.Metacritic,
                    Generos = primeiroJogo.Genres?.Select(g => g.Name).ToList() ?? new List<string>(),
                    Desenvolvedores = primeiroJogo.Developers?.Select(d => d.Name).ToList() ?? new List<string>(),
                    Publicadores = primeiroJogo.Publishers?.Select(p => p.Name).ToList() ?? new List<string>()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar jogo: " + ex.Message);
                return null;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string nomeJogo = txbnome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeJogo))
            {
                MessageBox.Show("Por favor, insira um nome de jogo válido.");
                return;
            }

            try
            {
                Jogos ?jogo = await BuscarJogosPorNomeAsync(nomeJogo);

                if (jogo != null)
                {
                    // Preenche os campos com os dados do jogo retornado
                    txbid.Text = jogo.Id.ToString();  // ID da API
                    txbplatforma.Text = jogo.Plataforma;
                    txbdata.Text = jogo.DataLancamento != DateTime.MinValue ? jogo.DataLancamento.ToString("dd/MM/yyyy") : "Data não disponível";
                    txbgenero.Text = jogo.Generos != null ? string.Join(", ", jogo.Generos) : "Gêneros não disponíveis";

                    if (!string.IsNullOrWhiteSpace(jogo.ImagemUrl))
                    {
                        pictureBox1.Load(jogo.ImagemUrl);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        pictureBox1.Image = null; // limpa a imagem anterior
                        MessageBox.Show("Imagem não disponível para este jogo.");
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum jogo encontrado com esse nome.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar jogo: " + ex.Message);
            }
        }


        private void SalvarJogoNoBanco(Jogos jogo)
        {
            try
            {
                string pastaImagens = Path.Combine(Application.StartupPath, "imagens");
                if (!Directory.Exists(pastaImagens))
                    Directory.CreateDirectory(pastaImagens);

                // Gera um nome único para a imagem
                string nomeLimpo = Regex.Replace(jogo.Nome ?? string.Empty, @"[^a-zA-Z0-9]", "_");
                string nomeImagem = $"{nomeLimpo}_{DateTime.Now.Ticks}.jpg";
                string caminhoImagem = Path.Combine(pastaImagens, nomeImagem);

                // Salva a imagem localmente
                pictureBox1.Image.Save(caminhoImagem, ImageFormat.Jpeg);

                // Caminho relativo que será salvo no banco
                string caminhoRelativoImagem = $"imagens/{nomeImagem}";

                using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-EBJNJFL\\SQLEXPRESS;Database=locadora;User Id=root;Password=abc;TrustServerCertificate=True;"))
                {
                    conexao.Open();
                    string sql = @"INSERT INTO jogo (nome, plataforma, genero, imagem,id_api)
                           VALUES (@nome, @plataforma, @genero, @imagem,@id_api)";

                    using (SqlCommand cmd = new SqlCommand(sql, conexao))
                    {
                        
                        cmd.Parameters.AddWithValue("@nome", jogo.Nome);
                        cmd.Parameters.AddWithValue("@plataforma", jogo.Plataforma);
                        cmd.Parameters.AddWithValue("@genero", jogo.Generos != null ? string.Join(", ", jogo.Generos) : string.Empty);
                        cmd.Parameters.AddWithValue("@imagem", caminhoRelativoImagem);
                        cmd.Parameters.AddWithValue("@id_api", jogo.Id);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Jogo inserido com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir no banco: " + ex.Message);
            }
        }

        private async void btnsalvar_Click(object sender, EventArgs e)
        {   Jogos jogos = new Jogos();
            string nomeJogo = txbnome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nomeJogo))
            {
                MessageBox.Show("Por favor, insira um nome de jogo válido.");
                return;
            }

            try
            {
                Jogos ?jogo = await BuscarJogosPorNomeAsync(nomeJogo);

                if (jogo != null)
                {
                    txbid.Text = jogo.Id.ToString();  // ID da API
                    txbplatforma.Text = jogo.Plataforma;
                    txbgenero.Text = jogo.Generos != null ? string.Join(", ", jogo.Generos) : "Gêneros não disponíveis";

                    // Carrega a imagem via URL
                    pictureBox1.ImageLocation = jogo.ImagemUrl;
                    pictureBox1.Load();
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Define o caminho para salvar a imagem
                    string pastaDestino = @"C:\Users\rsouz\Downloads\trabalho-linguagem-rsouzactba91-patch-1\trabalho linguagem\imagens";
                    string nomeArquivo = $"{jogo.Id}.jpg";
                    string caminhoCompleto = Path.Combine(pastaDestino, nomeArquivo);

                    // Garante que a pasta existe
                    Directory.CreateDirectory(pastaDestino);

                    // Salva a imagem do PictureBox
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Save(caminhoCompleto, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("Imagem salva com sucesso em:\n" + caminhoCompleto);
                    }
                    else
                    {
                        MessageBox.Show("Imagem não carregada.");
                    }

                    // Aqui você pode salvar no banco, se quiser
                    SalvarJogoNoBanco(jogo);
                }
                else
                {
                    MessageBox.Show("Nenhum jogo encontrado com esse nome.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar ou salvar jogo: " + ex.Message);
            }
        }
    }
}
