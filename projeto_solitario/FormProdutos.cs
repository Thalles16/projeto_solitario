﻿using System;
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
                // Corrigido: converter DateOnly para string
                string validadeFormatada = prod.Validade.ToString("dd/MM/yyyy");
                dataGridViewProdutos.Rows.Add(prod.Id, prod.Nome, validadeFormatada, prod.Preco, prod.Quantidade, prod.Tipo);
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
            carregarProdutos(); // <- Atualiza a listagem
            limparCampos();     // <- Limpa os campos do formulário

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada.");
                return;
            }

            int id;
            if (!int.TryParse(dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString(), out id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            Produto p = new Produto(0, "", new DateOnly(), 0, 0, "");
            p.excluir(id);

            MessageBox.Show("Produto excluído com sucesso!");
            carregarProdutos();
            limparCampos();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProdutos.CurrentRow == null)
            {
                MessageBox.Show("Nenhuma linha selecionada.");
                return;
            }

            if (!int.TryParse(dataGridViewProdutos.CurrentRow.Cells[0].Value.ToString(), out int id))
            {
                MessageBox.Show("ID inválido.");
                return;
            }

            if (!DateTime.TryParse(txtValidade.Text, out DateTime dataConvertida))
            {
                MessageBox.Show("Data de validade inválida!");
                return;
            }

            if (!double.TryParse(txtPreco.Text, out double preco))
            {
                MessageBox.Show("Preço inválido!");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade))
            {
                MessageBox.Show("Quantidade inválida!");
                return;
            }

            DateOnly validade = DateOnly.FromDateTime(dataConvertida);

            Produto produto = new Produto(
                id: id,
                nome: txtNome.Text,
                validade: validade,
                preco: preco,
                quantidade: quantidade,
                tipo: txtTipo.Text
            );

            produto.alterar(produto);

            MessageBox.Show("Produto alterado com sucesso!");
            carregarProdutos();
            limparCampos();
        }
        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProdutos.Rows[e.RowIndex];
                txtNome.Text = row.Cells[1].Value.ToString();
                txtValidade.Text = row.Cells[2].Value.ToString(); // Corrigido
                txtPreco.Text = row.Cells[3].Value.ToString();
                txtQuantidade.Text = row.Cells[4].Value.ToString();
                txtTipo.Text = row.Cells[5].Value.ToString();
            }
        }

        private void FormProdutos_Load(object sender, EventArgs e)
        {
            dataGridViewProdutos.Columns.Add("Id", "ID");
            dataGridViewProdutos.Columns["Id"].ReadOnly = true;
            dataGridViewProdutos.Columns.Add("Nome", "Nome");
            dataGridViewProdutos.Columns.Add("Validade", "Validade"); // Agora será string
            dataGridViewProdutos.Columns.Add("Preco", "Preço");
            dataGridViewProdutos.Columns.Add("Quantidade", "Quantidade");
            dataGridViewProdutos.Columns.Add("Tipo", "Tipo");

            carregarProdutos();
        }

        
    }
}

