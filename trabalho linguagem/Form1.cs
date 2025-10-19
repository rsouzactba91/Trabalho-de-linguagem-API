using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace trabalho_linguagem
{
    public partial class Form1 : Form
    {
        public string connectionString = "Server=DESKTOP-EBJNJFL\\SQLEXPRESS;Database=locadora;User Id=root;Password=abc;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
            Pessoa pessoa = new Pessoa();
            Endereco endereco = new Endereco();
            var pedido = pessoa.pedido;
            this.Text = "Aluguel de jogos";
            // Inicializa o DataGridView ou outros componentes, se necessário

        }
        public void CreatePessoaBanco(Pessoa person, Endereco endereco)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    try
                    {
                        using (SqlConnection conexao = new SqlConnection(connectionString))
                        {
                            conexao.Open();

                            // 1. Inserir na tabela pessoa
                            string sqlPessoa = "INSERT INTO pessoa (nome, sexo, ativo, matricula, cpf, telefone) VALUES (@nome, @sexo, @ativo, @matricula, @cpf, @telefone)";
                            using (SqlCommand cmdPessoa = new SqlCommand(sqlPessoa, conexao))
                            {
                                cmdPessoa.Parameters.AddWithValue("@nome", person.nome);
                                cmdPessoa.Parameters.AddWithValue("@sexo", person.sexo);
                                cmdPessoa.Parameters.AddWithValue("@ativo", person.ativo);
                                cmdPessoa.Parameters.AddWithValue("@matricula", person.matricula);
                                cmdPessoa.Parameters.AddWithValue("@cpf", person.cpf);
                                cmdPessoa.Parameters.AddWithValue("@telefone", person.telefone);

                                cmdPessoa.ExecuteNonQuery();
                            }

                            // 2. Inserir na tabela endereço
                            string sqlEndereco = "INSERT INTO endereco (cep,Logradouro, numero,bairro,cidade,uf,cpf) VALUES (@cep,@Logradouro,@numero,@bairro,@cidade,@uf,@cpf)";
                            using (SqlCommand cmdEndereco = new SqlCommand(sqlEndereco, conexao))
                            {
                                cmdEndereco.Parameters.AddWithValue("@cep", txbcep.Text);
                                cmdEndereco.Parameters.AddWithValue("@Logradouro", txbendereco.Text);
                                cmdEndereco.Parameters.AddWithValue("@numero", txbnumero.Text);
                                cmdEndereco.Parameters.AddWithValue("@bairro", txbbairro.Text);
                                cmdEndereco.Parameters.AddWithValue("@cidade", txbcidade.Text);
                                cmdEndereco.Parameters.AddWithValue("@uf", txbestado.Text);
                                cmdEndereco.Parameters.AddWithValue("@cpf", person.cpf);


                                cmdEndereco.ExecuteNonQuery();
                            }

                            MessageBox.Show("Pessoa cadastrada com sucesso.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao inserir no banco: " + ex.Message);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show("Erro de SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }
        public (Pessoa, Endereco) BuscarClientePorCpf(string cpf)
        {
            Pessoa pessoa = new Pessoa(); // Inicializa com um objeto não nulo
            Endereco endereco = new Endereco(); // Inicializa com um objeto não nulo

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();

                    // Buscar dados da pessoa
                    string sqlPessoa = "SELECT nome, cpf, telefone FROM pessoa WHERE cpf = @cpf";
                    using (SqlCommand cmdPessoa = new SqlCommand(sqlPessoa, conexao))
                    {
                        cmdPessoa.Parameters.AddWithValue("@cpf", cpf);
                        using (SqlDataReader readerPessoa = cmdPessoa.ExecuteReader())
                        {
                            if (readerPessoa.Read())
                            {
                                pessoa.nome = readerPessoa["nome"].ToString();
                                pessoa.cpf = readerPessoa["cpf"].ToString();
                                pessoa.telefone = readerPessoa["telefone"].ToString();
                            }
                        }
                    }

                    // Buscar endereço correspondente
                    string sqlEndereco = "SELECT cep, logradouro, numero, bairro, cidade, uf FROM endereco WHERE cpf = @cpf";
                    using (SqlCommand cmdEndereco = new SqlCommand(sqlEndereco, conexao))
                    {
                        cmdEndereco.Parameters.AddWithValue("@cpf", cpf);
                        using (SqlDataReader readerEndereco = cmdEndereco.ExecuteReader())
                        {
                            if (readerEndereco.Read())
                            {
                                endereco = new Endereco
                                {
                                    Cep = readerEndereco["cep"].ToString(),
                                    Logradouro = readerEndereco["logradouro"].ToString(),
                                    Numero = readerEndereco["numero"].ToString(),
                                    Bairro = readerEndereco["bairro"].ToString(),
                                    Cidade = readerEndereco["cidade"].ToString(),
                                    UF = readerEndereco["uf"].ToString()
                                };
                            }
                        }
                    }

                    // Preencher os campos do formulário (assumindo que estão disponíveis)
                    if (pessoa != null && endereco != null)
                    {
                        txbnomecliente.Text = pessoa.nome;
                        txbcpf.Text = pessoa.cpf;
                        txbtelefone.Text = pessoa.telefone;
                        txbendereco.Text = endereco.Logradouro;
                        txbnumero.Text = endereco.Numero;
                        txbcep.Text = endereco.Cep;
                        txbcidade.Text = endereco.Cidade;
                        txbestado.Text = endereco.UF;
                        txbbairro.Text = endereco.Bairro;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao buscar cliente: " + ex.Message);
                }
            }

            return (pessoa, endereco); // retorna uma tupla com os dois objetos
        }
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
                    Plataforma = primeiroJogo.Platforms?[0]?.Platform?.Name ?? "Desconhecida",
                    DataLancamento = DateTime.TryParse(primeiroJogo.Released, out DateTime dt) ? dt : DateTime.MinValue,
                    ImagemUrl = primeiroJogo.BackgroundImage,
                    Rating = primeiroJogo.Rating,
                    Metacritic = primeiroJogo.Metacritic,
                    Generos = primeiroJogo.Genres?.Select(g => g.Name).ToList(),
                    Desenvolvedores = primeiroJogo.Developers?.Select(d => d.Name).ToList(),
                    Publicadores = primeiroJogo.Publishers?.Select(p => p.Name).ToList(),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar jogo: " + ex.Message);
                return null;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

            this.Text = "Aluguel de jogos";


        }
        private async void Consultar_Click(object sender, EventArgs e)
        {

            Endereco? end = new Endereco();
            end.Cep = txbcep.Text;

            string url = $"https://viacep.com.br/ws/{end.Cep}/json/";

            using HttpClient client = new HttpClient();

            try
            {
                string resposta = await client.GetStringAsync(url);
                end = JsonConvert.DeserializeObject<Endereco>(resposta);

                txbendereco.Text = end?.Logradouro;
                txbestado.Text = end?.UF;
                txbcidade.Text = end?.Cidade;
                txbbairro.Text = end?.Bairro;
                txbnumero.Text = end?.Numero;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnadjogos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();

        }
        private async void btnconsultar_Click(object sender, EventArgs e)
        {
            string nomeJogo = txbnome.Text;

            if (string.IsNullOrWhiteSpace(nomeJogo))
            {
                MessageBox.Show("Por favor, insira um nome de jogo válido.");
                return;
            }

            Jogos? jogo = await BuscarJogosPorNomeAsync(nomeJogo);

            if (jogo != null)
            {
                // Preenche os campos com os dados do jogo retornado
                txbid.Text = jogo.Id.ToString();
                txbplataforma.Text = jogo.Plataforma;
                if (jogo.Generos != null && jogo.Generos.Any())
                {
                    txbgenero.Text = string.Join(", ", jogo.Generos);
                }
                else
                {
                    txbgenero.Text = "Gêneros não disponíveis";
                }

                pictureBox1.Load(jogo.ImagemUrl);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Nenhum jogo encontrado com esse nome.");
            }
        }
        private void btnaddlista_Click(object sender, EventArgs e)
        {
            listaaluguel.Items.Add(txbid.Text + " - " + txbnome.Text + " - " + txbplataforma.Text + " - " + txbgenero.Text);
        }
        public void limparlistaaluguel()
        {

            listaaluguel.Items.Clear();
        }
        public void limparlistacomprovante()
        {

            listacomprovante.Items.Clear();
            cbxdevolucaosim.Enabled = true;
            cbxdevolucaosim.Checked = false;
            cbxsim.Enabled = true;
            cbxsim.Checked = false;
            button2.TabStop = false;


        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            limparlistaaluguel();
        }
        private void btnremover_Click(object sender, EventArgs e)
        {
            if (listaaluguel.SelectedIndex != -1)
            {
                // Remove the selected item
                listaaluguel.Items.RemoveAt(listaaluguel.SelectedIndex);
                // Clear selection afterwards
                listaaluguel.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Nenhum item selecionado para remover.");
            }
        }
        public void limparcampos()
        {
            txbnomecliente.Clear();
            txbtelefone.Clear();
            txbcpf.Clear();
            txbcep.Clear();
            txbestado.Clear();
            txbendereco.Clear();
            txbcidade.Clear();
            txbbairro.Clear();
            txbnumero.Clear();
        }
        private void btncadastrarcliente_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                nome = txbnomecliente.Text,
                cpf = txbcpf.Text,
                telefone = txbtelefone.Text,
            };
            Endereco endereco = new Endereco
            {
                Cep = txbcep.Text,
                UF = txbestado.Text,
                Logradouro = txbendereco.Text,
                Cidade = txbcidade.Text,
                Bairro = txbbairro.Text,
                Numero = txbnumero.Text
            };
            CreatePessoaBanco(pessoa, endereco);
            limparcampos();
        }
        private void btnconsultarcliente_Click(object sender, EventArgs e)
        {

            BuscarClientePorCpf(txbcpf.Text);


        }
        private void btnsalvarpedido_Click(object sender, EventArgs e)
        {

            Pessoa pessoa = new Pessoa();

            if (string.IsNullOrWhiteSpace(txbnomecliente.Text) ||
                string.IsNullOrWhiteSpace(txbcpf.Text) ||
                string.IsNullOrWhiteSpace(txbtelefone.Text) ||
                listaaluguel.Items.Count == 0)
            {
                MessageBox.Show("Por favor, preencha todos os campos e adicione pelo menos um jogo à lista de aluguel.");
                return;
            }

            // Limpa o comprovante anterior
            listacomprovante.Items.Clear();

            // Cabeçalho do comprovante
            listacomprovante.Items.Add("===== COMPROVANTE DE ALUGUEL =====");
            listacomprovante.Items.Add("Data: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            listacomprovante.Items.Add("");

            // Informações do cliente
            listacomprovante.Items.Add("Nome: " + txbnomecliente.Text);
            listacomprovante.Items.Add("CPF: " + txbcpf.Text);
            listacomprovante.Items.Add("Telefone: " + txbtelefone.Text);
            listacomprovante.Items.Add("Endereço: " + txbendereco.Text + ", " + txbnumero.Text);
            listacomprovante.Items.Add("Bairro: " + txbbairro.Text);
            listacomprovante.Items.Add("Cidade: " + txbcidade.Text + " - " + txbestado.Text);
            listacomprovante.Items.Add("CEP: " + txbcep.Text);
            listacomprovante.Items.Add("");

            listacomprovante.Items.Add("Pedido n°:" + pessoa.pedido);

            // Lista de jogos alugados
            listacomprovante.Items.Add("Jogos Alugados:");
            foreach (var item in listaaluguel.Items)
            {
                listacomprovante.Items.Add("- " + item.ToString());
            }

            if (cbxsim.Checked)
            {
                cbxdevolucaosim.Enabled = (false);
                listacomprovante.Items.Add("Pagamento efetuado no ato da retirada.");

            }
            else if (cbxdevolucaosim.Checked)
            {
                cbxsim.Enabled = (false);

                listacomprovante.Items.Add("Pagamento será efetuado no ato da devolução.");
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma opção de pagamento.");
                return;
            }
            listacomprovante.Items.Add("==================================");



            // Agora sim limpa a lista de aluguel, depois de gerar o comprovante
            limparlistaaluguel();

        }
        private void btneditarpedido_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbnome.Text) || string.IsNullOrWhiteSpace(txbplataforma.Text) || string.IsNullOrWhiteSpace(txbgenero.Text))
            {
                MessageBox.Show("Preencha todos os campos do jogo.");
                return;
            }

            string novoJogo = txbnome.Text.Trim() + " - " + txbplataforma.Text.Trim() + " - " + txbgenero.Text.Trim();

            // Adiciona à lista visual
            //  listaaluguel.Items.Add(novoJogo);

            // Atualiza o comprovante
            int indiceJogos = listacomprovante.Items.IndexOf("Jogos Alugados:");
            if (indiceJogos != -1)
            {
                // Verifica se já existe o jogo no comprovante para não duplicar
                bool jogoExiste = false;
                for (int i = indiceJogos + 1; i < listacomprovante.Items.Count; i++)
                {
                    string? item = listacomprovante.Items[i].ToString();
                    if (item == "- " + novoJogo)
                    {
                        jogoExiste = true;
                        break;
                    }
                    // Se encontrou o fim da lista de jogos, para

                    // Verifica se o item não é nulo antes de chamar StartsWith
                    if (item == null || !item.StartsWith("- "))
                        break;
                }

                if (!jogoExiste)
                    listacomprovante.Items.Insert(indiceJogos + 1, "- " + novoJogo);
            }
            else
            {
                // Se não existir "Jogos Alugados:", adiciona no fim
                listacomprovante.Items.Add("Jogos Alugados:");
                listacomprovante.Items.Add("- " + novoJogo);
            }
        } 
        private void button2_Click(object sender, EventArgs e)
        {
            if (listacomprovante.Items.Count == 0)
            {
                MessageBox.Show("Não há itens para salvar.");
                return;
            }

            // Caminho completo para salvar o TXT na pasta Pedidos
            string pastaPedidos = @"C:\Users\rsouz\Downloads\trabalho-linguagem-rsouzactba91-patch-1\trabalho linguagem\Pedidos";
            string nomeArquivo = Path.Combine(pastaPedidos, $"comprovante_{DateTime.Now:yyyyMMdd_HHmmss}.txt");

            try
            {
                // 1. Salvar o arquivo TXT
                using (StreamWriter sw = new StreamWriter(nomeArquivo))
                {
                    foreach (var item in listacomprovante.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }

                // 2. Salvar os dados no banco usando Pessoa
                SalvarPedidoEItensNoBanco(nomeArquivo);

                MessageBox.Show("Arquivo exportado e dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar arquivo e salvar dados: " + ex.Message);
            }
        }
        private void SalvarPedidoEItensNoBanco(string nomeArquivo)
        {
            string cpfCliente = "06961551920"; // Pegue do formulário, se quiser

            Pessoa p = new Pessoa();
            int idPedido = p.pedido; // Aqui você usa sua lógica da classe Pessoa!

            using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-EBJNJFL\\SQLEXPRESS;Database=locadora;User Id=root;Password=abc;TrustServerCertificate=True;"))
            {
                conexao.Open();

                // 1. Inserir o pedido
                string sqlPedido = "INSERT INTO pedido (cpf, data_pedido) VALUES (@cpf, @data_pedido)";
                using (SqlCommand cmdPedido = new SqlCommand(sqlPedido, conexao))
                {
                    cmdPedido.Parameters.AddWithValue("@cpf", cpfCliente);
                    cmdPedido.Parameters.AddWithValue("@data_pedido", DateTime.Now);
                    cmdPedido.ExecuteNonQuery();
                }

                // 2. Inserir os itens do pedido com id_jogo e nome_jogo
                foreach (var item in listacomprovante.Items)
                {
                    string linha = item.ToString().Trim();
                    int pos = linha.IndexOf(" - ");

                    if (pos > 0)
                    {
                        int idJogo;
                        if (int.TryParse(linha.Substring(0, pos), out idJogo))
                        {
                            string nomeJogo = linha.Substring(pos + 3).Trim();

                            string sqlItem = "INSERT INTO itens_pedido (id_pedido, id_jogo, nome_jogo, quantidade) VALUES (@id_pedido, @id_jogo, @nome_jogo, @quantidade)";
                            using (SqlCommand cmdItem = new SqlCommand(sqlItem, conexao))
                            {
                                cmdItem.Parameters.AddWithValue("@id_pedido", idPedido);
                                cmdItem.Parameters.AddWithValue("@id_jogo", idJogo);
                                cmdItem.Parameters.AddWithValue("@nome_jogo", nomeJogo);
                                cmdItem.Parameters.AddWithValue("@quantidade", 1); // Ajuste se quiser quantidade variável

                                cmdItem.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            limparlistacomprovante();
        }
        private void btnconsultarjogosbd_Click(object sender, EventArgs e)
        {
            Jogo jogo = new Jogo
            {
                Nome = txbnome.Text
            };

            using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-EBJNJFL\\SQLEXPRESS;Database=locadora;User Id=root;Password=abc;TrustServerCertificate=True;"))
            {
                conexao.Open();

                string sql = "SELECT * FROM jogo WHERE nome LIKE @nome";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    // Adiciona os curingas para a busca LIKE
                    cmd.Parameters.AddWithValue("@nome", "%" + jogo.Nome + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Leitura dos dados do banco
                            string? id = reader["id_api"].ToString();
                            string? nome = reader["nome"].ToString();
                            string? plataforma = reader["plataforma"].ToString();
                            string? genero = reader["genero"].ToString();
                            string? imagem = reader["imagem"].ToString();

                            // Preenche os campos no formulário
                            txbid.Text = id;
                            txbnome.Text = nome;
                            txbplataforma.Text = plataforma;
                            txbgenero.Text = genero;

                            // Caminho completo da imagem
                            string? caminhoImagemCompleto = !string.IsNullOrEmpty(imagem) ? Path.Combine(Application.StartupPath, imagem) : null;

                            if (!string.IsNullOrEmpty(caminhoImagemCompleto) && File.Exists(caminhoImagemCompleto))
                            {
                                pictureBox1.Load(caminhoImagemCompleto);
                                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            }
                            else
                            {
                                MessageBox.Show("Imagem não encontrada ou caminho inválido.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Jogo não encontrado.");
                        }
                    }
                }
            }
        }
        private void btneditarcliente_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa
            {
                nome = txbnomecliente.Text,
                cpf = txbcpf.Text,
                telefone = txbtelefone.Text,
            };
            Endereco endereco = new Endereco
            {
                Cep = txbcep.Text,
                UF = txbestado.Text,
                Logradouro = txbendereco.Text,
                Cidade = txbcidade.Text,
                Bairro = txbbairro.Text,
                Numero = txbnumero.Text
            };

            Formeditar formEditar = new Formeditar(pessoa, endereco);
            formEditar.ShowDialog();
        }
    }
}




