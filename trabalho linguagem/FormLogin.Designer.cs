namespace trabalho_linguagem
{
    partial class FormLogin
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
            lbllogin = new Label();
            lblsenha = new Label();
            txbsenha = new TextBox();
            txblogin = new TextBox();
            btnlogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbllogin
            // 
            lbllogin.AutoSize = true;
            lbllogin.Location = new Point(143, 158);
            lbllogin.Name = "lbllogin";
            lbllogin.Size = new Size(37, 15);
            lbllogin.TabIndex = 0;
            lbllogin.Text = "Login";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(143, 204);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(39, 15);
            lblsenha.TabIndex = 1;
            lblsenha.Text = "Senha";
            // 
            // txbsenha
            // 
            txbsenha.BorderStyle = BorderStyle.FixedSingle;
            txbsenha.Location = new Point(222, 196);
            txbsenha.Name = "txbsenha";
            txbsenha.Size = new Size(100, 23);
            txbsenha.TabIndex = 2;
            // 
            // txblogin
            // 
            txblogin.BorderStyle = BorderStyle.FixedSingle;
            txblogin.Location = new Point(222, 150);
            txblogin.Name = "txblogin";
            txblogin.Size = new Size(100, 23);
            txblogin.TabIndex = 5;
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(190, 264);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(94, 23);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(70, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(364, 108);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 340);
            Controls.Add(pictureBox1);
            Controls.Add(btnlogin);
            Controls.Add(txblogin);
            Controls.Add(txbsenha);
            Controls.Add(lblsenha);
            Controls.Add(lbllogin);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbllogin;
        private Label lblsenha;
        private TextBox txbsenha;
        private TextBox txblogin;
        private Button btnlogin;
        private PictureBox pictureBox1;
    }
}