using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_linguagem
{   
    public partial class Formeditar : Form
    {   
        public Formeditar(Pessoa pessoa, Endereco endereco)
        {
            InitializeComponent();
            PreencherComboBoxPedidosPorCPF(pessoa.cpf);

            txbnomecliente.Text = pessoa.nome;
            txbcpf.Text = pessoa.cpf;
            txbtelefone.Text = pessoa.telefone;
            txbcep.Text = endereco.Cep;
            txbendereco.Text = endereco.Logradouro;
            txbnumero.Text = endereco.Numero;
            txbbairro.Text = endereco.Bairro;
            txbcidade.Text = endereco.Cidade;
            txbestado.Text = endereco.UF;
        }
        
        private void PreencherComboBoxPedidosPorCPF(string cpf)
        {
            comboBox1.Items.Clear();

            using (SqlConnection conexao = new SqlConnection("Server=DESKTOP-EBJNJFL\\SQLEXPRESS;Database=locadora;User Id=root;Password=abc;TrustServerCertificate=True;"))
            {
                string sql = "SELECT id_pedido FROM pedido WHERE cpf = @cpf ORDER BY data DESC";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);

                    conexao.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["id_pedido"]);
                            DateTime data = Convert.ToDateTime(reader["data"]);
                            string texto = $"Pedido #{id} - {data:dd/MM/yyyy}";
                            comboBox1.Items.Add(texto);
                        }
                    }
                }
            }
        }

        private void btnCarregarJogos_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); // Limpa os itens antigos, se houver
            
            PreencherComboBoxPedidosPorCPF(txbcpf.Text.Trim());
        }
    }
}
