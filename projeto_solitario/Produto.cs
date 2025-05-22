using Projeto;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace projeto_solitario
{
    class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly Validade { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }

        private ConexaoBD conexao = new ConexaoBD();

        public Produto(int id, string nome, DateOnly validade, double preco, int quantidade, string tipo)
        {
            Id = id;
            Nome = nome;
            Validade = validade;
            Preco = preco;
            Quantidade = quantidade;
            Tipo = tipo;
        }

        public void inserir(Produto produto)
        {
            try
            {
                string sql = "INSERT INTO produtos (nome, validade, preco, quantidade, tipo) VALUES (@nome, @validade, @preco, @quantidade, @tipo)";
                using (var conexaoAberta = conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conexaoAberta))
                {
                    comando.Parameters.AddWithValue("@nome", produto.Nome);
                    comando.Parameters.AddWithValue("@validade", produto.Validade.ToDateTime(TimeOnly.MinValue));
                    comando.Parameters.AddWithValue("@preco", produto.Preco);
                    comando.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                    comando.Parameters.AddWithValue("@tipo", produto.Tipo);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void alterar(Produto produto)
        {
            try
            {
                string sql = "UPDATE produtos SET nome = @nome, validade = @validade, preco = @preco, quantidade = @quantidade, tipo = @tipo WHERE id = @id";
                using (var conexaoAberta = conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conexaoAberta))
                {
                    comando.Parameters.AddWithValue("@id", produto.Id);
                    comando.Parameters.AddWithValue("@nome", produto.Nome);
                    comando.Parameters.AddWithValue("@validade", produto.Validade.ToDateTime(TimeOnly.MinValue));
                    comando.Parameters.AddWithValue("@preco", produto.Preco);
                    comando.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                    comando.Parameters.AddWithValue("@tipo", produto.Tipo);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar produto: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void excluir(int id)
        {
            try
            {
                string sql = "DELETE FROM produtos WHERE id = @id";
                using (var conexaoAberta = conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conexaoAberta))
                {
                    comando.Parameters.AddWithValue("@id", id);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public List<Produto> listar()
        {
            List<Produto> produtos = new List<Produto>();
            try
            {
                string sql = "SELECT * FROM produtos";
                using (var conexaoAberta = conexao.Conectar())
                using (MySqlCommand comando = new MySqlCommand(sql, conexaoAberta))
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Produto produto = new Produto(
                            reader.GetInt32(0),                   // id
                            reader.GetString(1),                  // nome
                            DateOnly.FromDateTime(reader.GetDateTime(2)), // validade
                            reader.GetDouble(4),                  // preco
                            reader.GetInt32(5),                   // quantidade
                            reader.GetString(3)                   // tipo
                        );
                        produtos.Add(produto);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produtos: " + ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return produtos;
        }
    }
}
