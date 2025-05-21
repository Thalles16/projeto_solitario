using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_solitario
{
    public partial class FormProdutos : Form
    {
        public FormProdutos()
        {
            InitializeComponent();
        }
        private void limparCampos()
        {
            txtNome.Clear();
            txtValidade.Clear();
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtTipo.Clear();
        }
        private void carregarProdutos()
        {
            Produto p = new Produto(0, "", new DateOnly(), 0, 0, "");
            List<Produto> lista = p.listar();

            dataGridViewProdutos.Rows.Clear();
            foreach (Produto prod in lista)
            {
                dataGridViewProdutos.Rows.Add(prod.Id, prod.Nome, prod.Validade, prod.Preco, prod.Quantidade, prod.Tipo);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
            this.Hide();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(txtValidade.Text, out DateTime dataConvertida))
            {
                MessageBox.Show("Data de validade inválida! Digite no formato correto (ex: 20/05/2025)");
                return;
            }

            DateOnly validade = DateOnly.FromDateTime(dataConvertida);

            Produto produto = new Produto
            (
                id: 0, // ou outro valor se estiver editando
                nome: txtNome.Text,
                validade: validade,
                preco: double.Parse(txtPreco.Text),
                quantidade: int.Parse(txtQuantidade.Text),
                tipo: txtTipo.Text
            );

            produto.inserir(produto);

            MessageBox.Show("Produto salvo com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}

