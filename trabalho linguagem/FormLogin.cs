using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_linguagem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }



        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            string Login = "admin";
            string Senha = "admin";

            if (txblogin.Text == Login && txbsenha.Text == Senha)
            {
                MessageBox.Show("Autenticado com Sucesso");
                form.Show();
                //lbMensagem.Text = "Autenticado com Sucesso - Bem vindo " + txblogin.Text;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
                // lbMensagem.Text = "Usuário ou senha inválidos - Não existe usuário " + txblogin.Text;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Tela de Login";
            pictureBox1.Image = Image.FromFile(@"C:\Users\rsouz\Downloads\trabalho-linguagem-rsouzactba91-patch-1\Sem título.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }
    }
}

