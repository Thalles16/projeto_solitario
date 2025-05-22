namespace projeto_solitario
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            linkLblCadastro = new LinkLabel();
            btnEntrar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLblCadastro);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 750);
            panel1.TabIndex = 0;
            // 
            // linkLblCadastro
            // 
            linkLblCadastro.AutoSize = true;
            linkLblCadastro.Location = new Point(286, 448);
            linkLblCadastro.Margin = new Padding(4, 0, 4, 0);
            linkLblCadastro.Name = "linkLblCadastro";
            linkLblCadastro.Size = new Size(105, 25);
            linkLblCadastro.TabIndex = 6;
            linkLblCadastro.TabStop = true;
            linkLblCadastro.Text = "Cadastre-se";
            linkLblCadastro.LinkClicked += linkLblCadastro_LinkClicked;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(286, 595);
            btnEntrar.Margin = new Padding(4, 5, 4, 5);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(121, 70);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(286, 372);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(370, 31);
            txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(110, 372);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(96, 32);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(286, 240);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(110, 240);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 32);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email :";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 68);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1103, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 38);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormLogin";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private Label lblEmail;
        private LinkLabel linkLblCadastro;
        private Button btnEntrar;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}
