namespace projeto_solitario
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dataGridViewProdutos = new DataGridView();
            lblNome = new Label();
            lblValidade = new Label();
            lblTipo = new Label();
            lblPreco = new Label();
            lblQuantidade = new Label();
            txtNome = new TextBox();
            txtValidade = new TextBox();
            txtTipo = new TextBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnExcluir = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 16;
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
            // dataGridViewProdutos
            // 
            dataGridViewProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProdutos.Location = new Point(559, 63);
            dataGridViewProdutos.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProdutos.Name = "dataGridViewProdutos";
            dataGridViewProdutos.RowHeadersWidth = 62;
            dataGridViewProdutos.Size = new Size(567, 667);
            dataGridViewProdutos.TabIndex = 17;
            dataGridViewProdutos.CellClick += dataGridViewProdutos_CellClick;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(101, 163);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 18;
            lblNome.Text = "Nome";
            // 
            // lblValidade
            // 
            lblValidade.AutoSize = true;
            lblValidade.Location = new Point(101, 228);
            lblValidade.Margin = new Padding(4, 0, 4, 0);
            lblValidade.Name = "lblValidade";
            lblValidade.Size = new Size(79, 25);
            lblValidade.TabIndex = 19;
            lblValidade.Text = "Validade";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(101, 295);
            lblTipo.Margin = new Padding(4, 0, 4, 0);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(47, 25);
            lblTipo.TabIndex = 20;
            lblTipo.Text = "Tipo";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(101, 347);
            lblPreco.Margin = new Padding(4, 0, 4, 0);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(57, 25);
            lblPreco.TabIndex = 21;
            lblPreco.Text = "preço";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(101, 415);
            lblQuantidade.Margin = new Padding(4, 0, 4, 0);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(105, 25);
            lblQuantidade.TabIndex = 22;
            lblQuantidade.Text = "Quantidade";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(244, 163);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(141, 31);
            txtNome.TabIndex = 23;
            // 
            // txtValidade
            // 
            txtValidade.Location = new Point(244, 223);
            txtValidade.Margin = new Padding(4, 5, 4, 5);
            txtValidade.Name = "txtValidade";
            txtValidade.Size = new Size(141, 31);
            txtValidade.TabIndex = 24;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(244, 295);
            txtTipo.Margin = new Padding(4, 5, 4, 5);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(141, 31);
            txtTipo.TabIndex = 25;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(244, 342);
            txtPreco.Margin = new Padding(4, 5, 4, 5);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(141, 31);
            txtPreco.TabIndex = 26;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(244, 415);
            txtQuantidade.Margin = new Padding(4, 5, 4, 5);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(141, 31);
            txtQuantidade.TabIndex = 27;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(69, 620);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 38);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(231, 620);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 38);
            btnSalvar.TabIndex = 29;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(383, 620);
            btnExcluir.Margin = new Padding(4, 5, 4, 5);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(107, 38);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(txtTipo);
            Controls.Add(txtValidade);
            Controls.Add(txtNome);
            Controls.Add(lblQuantidade);
            Controls.Add(lblPreco);
            Controls.Add(lblTipo);
            Controls.Add(lblValidade);
            Controls.Add(lblNome);
            Controls.Add(dataGridViewProdutos);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormProdutos";
            Text = "FormProdutos";
            Load += FormProdutos_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewProdutos;
        private Label lblNome;
        private Label lblValidade;
        private Label lblTipo;
        private Label lblPreco;
        private Label lblQuantidade;
        private TextBox txtNome;
        private TextBox txtValidade;
        private TextBox txtTipo;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnExcluir;
    }
}