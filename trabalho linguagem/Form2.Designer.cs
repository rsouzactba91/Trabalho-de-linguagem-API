namespace trabalho_linguagem
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txbnome = new TextBox();
            txbplatforma = new TextBox();
            txbgenero = new TextBox();
            txbdata = new TextBox();
            label2 = new Label();
            lblgenero = new Label();
            label4 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            btnsalvar = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            txbid = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txbnome
            // 
            txbnome.Location = new Point(178, 47);
            txbnome.Name = "txbnome";
            txbnome.Size = new Size(100, 23);
            txbnome.TabIndex = 8;
            // 
            // txbplatforma
            // 
            txbplatforma.Location = new Point(178, 79);
            txbplatforma.Name = "txbplatforma";
            txbplatforma.Size = new Size(100, 23);
            txbplatforma.TabIndex = 9;
            // 
            // txbgenero
            // 
            txbgenero.Location = new Point(178, 141);
            txbgenero.Name = "txbgenero";
            txbgenero.Size = new Size(100, 23);
            txbgenero.TabIndex = 11;
            // 
            // txbdata
            // 
            txbdata.Location = new Point(178, 109);
            txbdata.Name = "txbdata";
            txbdata.Size = new Size(100, 23);
            txbdata.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 14;
            label2.Text = "Plataforma";
            // 
            // lblgenero
            // 
            lblgenero.AutoSize = true;
            lblgenero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgenero.Location = new Point(12, 145);
            lblgenero.Name = "lblgenero";
            lblgenero.Size = new Size(61, 21);
            lblgenero.TabIndex = 16;
            lblgenero.Text = "Gênero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 111);
            label4.Name = "label4";
            label4.Size = new Size(152, 21);
            label4.TabIndex = 15;
            label4.Text = "Data de Lançamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 184);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 17;
            label6.Text = "Disponivel";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(308, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 243);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(185, 234);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 234);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Carregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnsalvar
            // 
            btnsalvar.ImageAlign = ContentAlignment.BottomLeft;
            btnsalvar.Location = new Point(104, 234);
            btnsalvar.Name = "btnsalvar";
            btnsalvar.Size = new Size(75, 23);
            btnsalvar.TabIndex = 22;
            btnsalvar.Text = "Salvar";
            btnsalvar.UseVisualStyleBackColor = true;
            btnsalvar.Click += btnsalvar_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(178, 184);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(46, 19);
            checkBox1.TabIndex = 27;
            checkBox1.Text = "Sim";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(230, 184);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(48, 19);
            checkBox2.TabIndex = 28;
            checkBox2.Text = "Não";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // txbid
            // 
            txbid.Location = new Point(178, 11);
            txbid.Name = "txbid";
            txbid.Size = new Size(100, 23);
            txbid.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(23, 21);
            label5.TabIndex = 29;
            label5.Text = "Id";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 283);
            Controls.Add(txbid);
            Controls.Add(label5);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnsalvar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(lblgenero);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txbgenero);
            Controls.Add(txbdata);
            Controls.Add(txbplatforma);
            Controls.Add(txbnome);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbplatforma;
        private TextBox txbgenero;
        private TextBox txbdata;
        private Label label2;
        private Label lblgenero;
        private Label label4;
        private Label label6;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button btnsalvar;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private TextBox txbid;
        private Label label5;
        private TextBox txbnome;
    }
}
