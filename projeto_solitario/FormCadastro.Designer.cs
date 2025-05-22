namespace projeto_solitario
{
    partial class FormCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            btnCadastro = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCadastro);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblEmail);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1143, 750);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlText;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1143, 53);
            panel2.TabIndex = 15;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlLightLight;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(4, 5, 4, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1107, 0);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 38);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.Location = new Point(426, 543);
            btnCadastro.Margin = new Padding(4, 5, 4, 5);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(121, 70);
            btnCadastro.TabIndex = 11;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = true;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(426, 320);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(370, 31);
            txtSenha.TabIndex = 10;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(250, 320);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(96, 32);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(426, 188);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(370, 31);
            txtEmail.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(250, 188);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(90, 32);
            lblEmail.TabIndex = 7;
            lblEmail.Text = "Email :";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormCadastro";
            Text = "FormCadastro";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnCadastro;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}