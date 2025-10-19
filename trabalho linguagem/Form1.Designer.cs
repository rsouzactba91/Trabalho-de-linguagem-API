namespace trabalho_linguagem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listaaluguel = new ListBox();
            listacomprovante = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txbnome = new TextBox();
            txbplataforma = new TextBox();
            btnconsultar = new Button();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txbnomecliente = new TextBox();
            txbcpf = new TextBox();
            txbtelefone = new TextBox();
            cbxsim = new CheckBox();
            cbxdevolucaosim = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txbgenero = new TextBox();
            btnaddlista = new Button();
            btnremover = new Button();
            btnlimpar = new Button();
            btnadjogos = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txbcidade = new TextBox();
            txbnumero = new TextBox();
            txbendereco = new TextBox();
            txbestado = new TextBox();
            label12 = new Label();
            txbbairro = new TextBox();
            label13 = new Label();
            btnconsultaendereco = new Button();
            btncadastrarcliente = new Button();
            label14 = new Label();
            txbcep = new TextBox();
            btnconsultarcliente = new Button();
            btnsalvarpedido = new Button();
            btneditarpedido = new Button();
            pictureBox1 = new PictureBox();
            btnconsultarjogosbd = new Button();
            txbid = new TextBox();
            label15 = new Label();
            btneditarcliente = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listaaluguel
            // 
            listaaluguel.FormattingEnabled = true;
            listaaluguel.ItemHeight = 15;
            listaaluguel.Location = new Point(31, 152);
            listaaluguel.Margin = new Padding(3, 2, 3, 2);
            listaaluguel.Name = "listaaluguel";
            listaaluguel.Size = new Size(355, 199);
            listaaluguel.TabIndex = 0;
            // 
            // listacomprovante
            // 
            listacomprovante.FormattingEnabled = true;
            listacomprovante.ItemHeight = 15;
            listacomprovante.Location = new Point(554, 151);
            listacomprovante.Margin = new Padding(3, 2, 3, 2);
            listacomprovante.Name = "listacomprovante";
            listacomprovante.Size = new Size(355, 199);
            listacomprovante.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 384);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 2;
            label1.Text = "Nome do jogo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 409);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Plataforma";
            // 
            // txbnome
            // 
            txbnome.Location = new Point(147, 382);
            txbnome.Margin = new Padding(3, 2, 3, 2);
            txbnome.Name = "txbnome";
            txbnome.Size = new Size(97, 23);
            txbnome.TabIndex = 4;
            // 
            // txbplataforma
            // 
            txbplataforma.Location = new Point(147, 406);
            txbplataforma.Margin = new Padding(3, 2, 3, 2);
            txbplataforma.Name = "txbplataforma";
            txbplataforma.Size = new Size(97, 23);
            txbplataforma.TabIndex = 5;
            // 
            // btnconsultar
            // 
            btnconsultar.Location = new Point(31, 469);
            btnconsultar.Margin = new Padding(3, 2, 3, 2);
            btnconsultar.Name = "btnconsultar";
            btnconsultar.Size = new Size(112, 39);
            btnconsultar.TabIndex = 6;
            btnconsultar.Text = "Consultar jogos API";
            btnconsultar.UseVisualStyleBackColor = true;
            btnconsultar.Click += btnconsultar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(759, 420);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(96, 27);
            button2.TabIndex = 7;
            button2.Text = "Fechar pedido";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 46);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 9;
            label3.Text = "cpf";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 21);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 8;
            label4.Text = "Nome Cliente";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 74);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 10;
            label5.Text = "Telefone";
            // 
            // txbnomecliente
            // 
            txbnomecliente.Location = new Point(108, 16);
            txbnomecliente.Margin = new Padding(3, 2, 3, 2);
            txbnomecliente.Name = "txbnomecliente";
            txbnomecliente.Size = new Size(213, 23);
            txbnomecliente.TabIndex = 11;
            // 
            // txbcpf
            // 
            txbcpf.Location = new Point(108, 40);
            txbcpf.Margin = new Padding(3, 2, 3, 2);
            txbcpf.Name = "txbcpf";
            txbcpf.Size = new Size(213, 23);
            txbcpf.TabIndex = 12;
            // 
            // txbtelefone
            // 
            txbtelefone.Location = new Point(108, 68);
            txbtelefone.Margin = new Padding(3, 2, 3, 2);
            txbtelefone.Name = "txbtelefone";
            txbtelefone.Size = new Size(213, 23);
            txbtelefone.TabIndex = 13;
            // 
            // cbxsim
            // 
            cbxsim.AutoSize = true;
            cbxsim.Location = new Point(617, 384);
            cbxsim.Margin = new Padding(3, 2, 3, 2);
            cbxsim.Name = "cbxsim";
            cbxsim.Size = new Size(46, 19);
            cbxsim.TabIndex = 14;
            cbxsim.Text = "Sim";
            cbxsim.UseVisualStyleBackColor = true;
            // 
            // cbxdevolucaosim
            // 
            cbxdevolucaosim.AutoSize = true;
            cbxdevolucaosim.Location = new Point(732, 384);
            cbxdevolucaosim.Margin = new Padding(3, 2, 3, 2);
            cbxdevolucaosim.Name = "cbxdevolucaosim";
            cbxdevolucaosim.Size = new Size(46, 19);
            cbxdevolucaosim.TabIndex = 15;
            cbxdevolucaosim.Text = "Sim";
            cbxdevolucaosim.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(617, 361);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 16;
            label6.Text = "Cleinte já pagou?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(732, 361);
            label7.Name = "label7";
            label7.Size = new Size(107, 15);
            label7.TabIndex = 17;
            label7.Text = "Paga na devolução";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 434);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 18;
            label8.Text = "Gênero";
            // 
            // txbgenero
            // 
            txbgenero.Location = new Point(147, 431);
            txbgenero.Margin = new Padding(3, 2, 3, 2);
            txbgenero.Name = "txbgenero";
            txbgenero.Size = new Size(97, 23);
            txbgenero.TabIndex = 19;
            // 
            // btnaddlista
            // 
            btnaddlista.Location = new Point(422, 168);
            btnaddlista.Margin = new Padding(3, 2, 3, 2);
            btnaddlista.Name = "btnaddlista";
            btnaddlista.Size = new Size(110, 39);
            btnaddlista.TabIndex = 20;
            btnaddlista.Text = "Adicionar a lista";
            btnaddlista.UseVisualStyleBackColor = true;
            btnaddlista.Click += btnaddlista_Click;
            // 
            // btnremover
            // 
            btnremover.Location = new Point(422, 211);
            btnremover.Margin = new Padding(3, 2, 3, 2);
            btnremover.Name = "btnremover";
            btnremover.Size = new Size(110, 35);
            btnremover.TabIndex = 21;
            btnremover.Text = "Remover itens";
            btnremover.UseVisualStyleBackColor = true;
            btnremover.Click += btnremover_Click;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(422, 250);
            btnlimpar.Margin = new Padding(3, 2, 3, 2);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(110, 37);
            btnlimpar.TabIndex = 22;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // btnadjogos
            // 
            btnadjogos.Location = new Point(426, 302);
            btnadjogos.Name = "btnadjogos";
            btnadjogos.Size = new Size(106, 48);
            btnadjogos.TabIndex = 23;
            btnadjogos.Text = "Adicionar jogos a locadora";
            btnadjogos.UseVisualStyleBackColor = true;
            btnadjogos.Click += btnadjogos_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(339, 21);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 25;
            label9.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(339, 46);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 26;
            label10.Text = "Número";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(473, 46);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 27;
            label11.Text = "Cidade";
            // 
            // txbcidade
            // 
            txbcidade.Location = new Point(535, 37);
            txbcidade.Margin = new Padding(3, 2, 3, 2);
            txbcidade.Name = "txbcidade";
            txbcidade.Size = new Size(66, 23);
            txbcidade.TabIndex = 30;
            // 
            // txbnumero
            // 
            txbnumero.Location = new Point(401, 37);
            txbnumero.Margin = new Padding(3, 2, 3, 2);
            txbnumero.Name = "txbnumero";
            txbnumero.Size = new Size(54, 23);
            txbnumero.TabIndex = 29;
            // 
            // txbendereco
            // 
            txbendereco.Location = new Point(401, 13);
            txbendereco.Margin = new Padding(3, 2, 3, 2);
            txbendereco.Name = "txbendereco";
            txbendereco.Size = new Size(318, 23);
            txbendereco.TabIndex = 28;
            // 
            // txbestado
            // 
            txbestado.Location = new Point(401, 65);
            txbestado.Margin = new Padding(3, 2, 3, 2);
            txbestado.Name = "txbestado";
            txbestado.Size = new Size(54, 23);
            txbestado.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(339, 74);
            label12.Name = "label12";
            label12.Size = new Size(42, 15);
            label12.TabIndex = 31;
            label12.Text = "Estado";
            // 
            // txbbairro
            // 
            txbbairro.Location = new Point(535, 67);
            txbbairro.Margin = new Padding(3, 2, 3, 2);
            txbbairro.Name = "txbbairro";
            txbbairro.Size = new Size(184, 23);
            txbbairro.TabIndex = 34;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(473, 71);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 33;
            label13.Text = "Bairro";
            // 
            // btnconsultaendereco
            // 
            btnconsultaendereco.Location = new Point(742, 11);
            btnconsultaendereco.Name = "btnconsultaendereco";
            btnconsultaendereco.Size = new Size(167, 28);
            btnconsultaendereco.TabIndex = 35;
            btnconsultaendereco.Text = "Consultar Endereço";
            btnconsultaendereco.UseVisualStyleBackColor = true;
            btnconsultaendereco.Click += Consultar_Click;
            // 
            // btncadastrarcliente
            // 
            btncadastrarcliente.Location = new Point(742, 74);
            btncadastrarcliente.Name = "btncadastrarcliente";
            btncadastrarcliente.Size = new Size(83, 28);
            btncadastrarcliente.TabIndex = 36;
            btncadastrarcliente.Text = "Cadastrar";
            btncadastrarcliente.UseVisualStyleBackColor = true;
            btncadastrarcliente.Click += btncadastrarcliente_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(613, 43);
            label14.Name = "label14";
            label14.Size = new Size(28, 15);
            label14.TabIndex = 37;
            label14.Text = "Cep";
            // 
            // txbcep
            // 
            txbcep.Location = new Point(647, 40);
            txbcep.Margin = new Padding(3, 2, 3, 2);
            txbcep.Name = "txbcep";
            txbcep.Size = new Size(72, 23);
            txbcep.TabIndex = 38;
            // 
            // btnconsultarcliente
            // 
            btnconsultarcliente.Location = new Point(742, 43);
            btnconsultarcliente.Name = "btnconsultarcliente";
            btnconsultarcliente.Size = new Size(167, 28);
            btnconsultarcliente.TabIndex = 39;
            btnconsultarcliente.Text = "Consultar Cliente";
            btnconsultarcliente.UseVisualStyleBackColor = true;
            btnconsultarcliente.Click += btnconsultarcliente_Click;
            // 
            // btnsalvarpedido
            // 
            btnsalvarpedido.Location = new Point(554, 420);
            btnsalvarpedido.Margin = new Padding(3, 2, 3, 2);
            btnsalvarpedido.Name = "btnsalvarpedido";
            btnsalvarpedido.Size = new Size(96, 27);
            btnsalvarpedido.TabIndex = 41;
            btnsalvarpedido.Text = "Salvar pedido";
            btnsalvarpedido.UseVisualStyleBackColor = true;
            btnsalvarpedido.Click += btnsalvarpedido_Click;
            // 
            // btneditarpedido
            // 
            btneditarpedido.Location = new Point(656, 420);
            btneditarpedido.Margin = new Padding(3, 2, 3, 2);
            btneditarpedido.Name = "btneditarpedido";
            btneditarpedido.Size = new Size(96, 27);
            btneditarpedido.TabIndex = 42;
            btneditarpedido.Text = "Adicionar item ao pedido";
            btneditarpedido.UseVisualStyleBackColor = true;
            btneditarpedido.Click += btneditarpedido_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(287, 356);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 105);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // btnconsultarjogosbd
            // 
            btnconsultarjogosbd.Location = new Point(162, 469);
            btnconsultarjogosbd.Margin = new Padding(3, 2, 3, 2);
            btnconsultarjogosbd.Name = "btnconsultarjogosbd";
            btnconsultarjogosbd.Size = new Size(108, 39);
            btnconsultarjogosbd.TabIndex = 46;
            btnconsultarjogosbd.Text = "Consultar jogos BD";
            btnconsultarjogosbd.UseVisualStyleBackColor = true;
            btnconsultarjogosbd.Click += btnconsultarjogosbd_Click;
            // 
            // txbid
            // 
            txbid.Location = new Point(147, 359);
            txbid.Margin = new Padding(3, 2, 3, 2);
            txbid.Name = "txbid";
            txbid.Size = new Size(97, 23);
            txbid.TabIndex = 48;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(31, 361);
            label15.Name = "label15";
            label15.Size = new Size(17, 15);
            label15.TabIndex = 47;
            label15.Text = "id";
            // 
            // btneditarcliente
            // 
            btneditarcliente.Location = new Point(826, 74);
            btneditarcliente.Name = "btneditarcliente";
            btneditarcliente.Size = new Size(83, 28);
            btneditarcliente.TabIndex = 49;
            btneditarcliente.Text = "Editar";
            btneditarcliente.UseVisualStyleBackColor = true;
            btneditarcliente.Click += btneditarcliente_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 534);
            Controls.Add(btneditarcliente);
            Controls.Add(txbid);
            Controls.Add(label15);
            Controls.Add(btnconsultarjogosbd);
            Controls.Add(pictureBox1);
            Controls.Add(btneditarpedido);
            Controls.Add(btnsalvarpedido);
            Controls.Add(btnconsultarcliente);
            Controls.Add(txbcep);
            Controls.Add(label14);
            Controls.Add(btncadastrarcliente);
            Controls.Add(btnconsultaendereco);
            Controls.Add(txbbairro);
            Controls.Add(label13);
            Controls.Add(txbestado);
            Controls.Add(label12);
            Controls.Add(txbcidade);
            Controls.Add(txbnumero);
            Controls.Add(txbendereco);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnadjogos);
            Controls.Add(btnlimpar);
            Controls.Add(btnremover);
            Controls.Add(btnaddlista);
            Controls.Add(txbgenero);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cbxdevolucaosim);
            Controls.Add(cbxsim);
            Controls.Add(txbtelefone);
            Controls.Add(txbcpf);
            Controls.Add(txbnomecliente);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(btnconsultar);
            Controls.Add(txbplataforma);
            Controls.Add(txbnome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listacomprovante);
            Controls.Add(listaaluguel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listaaluguel;
        private ListBox listacomprovante;
        private Label label1;
        private Label label2;
        private TextBox txbnome;
        private TextBox txbplataforma;
        private Button btnconsultar;
        private Button button2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbnomecliente;
        private TextBox txbcpf;
        private TextBox txbtelefone;
        private CheckBox cbxsim;
        private CheckBox cbxdevolucaosim;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txbgenero;
        private Button btnaddlista;
        private Button btnremover;
        private Button btnlimpar;
        private Button btnadjogos;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txbcidade;
        private TextBox txbnumero;
        private TextBox txbendereco;
        private TextBox txbestado;
        private Label label12;
        private TextBox txbbairro;
        private Label label13;
        private Button btnconsultaendereco;
        private Button btncadastrarcliente;
        private Label label14;
        private TextBox txbcep;
        private Button btnconsultarcliente;
        private Button btnsalvarpedido;
        private Button btneditarpedido;
        private PictureBox pictureBox1;
        private Button btnconsultarjogosbd;
        private TextBox txbid;
        private Label label15;
        private Button btneditarcliente;
    }
}