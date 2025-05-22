using Projeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace projeto_solitario
{
    class Produto
    {
        public int Id{ get; set; }
        public string Nome { get; set; }
        public DateOnly Validade { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public string Tipo { get; set; }
     
        public Produto(int id, string nome, DateOnly validade, double preco, int quantidade, string tipo)
        {
            Id = id;
            Nome = nome;
            Validade = validade;
            Preco = preco;
            Quantidade = quantidade;
            Tipo = tipo;
        }
        private ConexaoBD conexao = new ConexaoBD();

        public void inserir(projeto_solitario.Produto produto)
        {
            string sql = "INSERT INTO produtos (nome, validade, preco, quantidade, tipo) VALUES (@nome, @validade, @preco, @quantidade, @tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexao.Conectar());
            comando.Parameters.AddWithValue("@nome", produto.Nome);
            comando.Parameters.AddWithValue("@validade", produto.Validade.ToDateTime(TimeOnly.MinValue));
            comando.Parameters.AddWithValue("@preco", produto.Preco);
            comando.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            comando.Parameters.AddWithValue("@tipo", produto.Tipo);
            comando.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void alterar(projeto_solitario.Produto produto)
        {
            string sql = "UPDATE produtos SET nome = @nome, validade = @validade, preco = @preco, quantidade = @quantidade, tipo = @tipo WHERE id = @id";
            MySqlCommand comando = new MySqlCommand(sql, conexao.Conectar());
            comando.Parameters.AddWithValue("@id", produto.Id);
            comando.Parameters.AddWithValue("@nome", produto.Nome);
            comando.Parameters.AddWithValue("@validade", produto.Validade.ToDateTime(TimeOnly.MinValue));

            comando.Parameters.AddWithValue("@preco", produto.Preco);
            comando.Parameters.AddWithValue("@quantidade", produto.Quantidade);
            comando.Parameters.AddWithValue("@tipo", produto.Tipo);
            comando.ExecuteNonQuery();
        }

        public void excluir(int id)
        {
            string sql = "DELETE FROM produtos WHERE id = @id";
            MySqlCommand comando = new MySqlCommand(sql, conexao.Conectar());
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public List<Produto> listar()
        {
            List<Produto> produtos = new List<Produto>();
            string sql = "SELECT * FROM produtos";

            MySqlCommand comando = new MySqlCommand(sql, conexao.Conectar());

            using (MySqlDataReader reader = comando.ExecuteReader())
            {
                while (reader.Read())
                {
                    Produto produto = new Produto(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        DateOnly.FromDateTime(reader.GetDateTime(2)),
                        reader.GetDouble(4),
                        reader.GetInt32(5),           // quantidade
                        reader.GetString(3)           // tipo
                    );
                    // <- aqui está o tipo



                    produtos.Add(produto);
            }
            conexao.Desconectar();
            return produtos;
        }
        }
    }

    }


