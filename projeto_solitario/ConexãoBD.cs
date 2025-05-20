using System;
using MySql.Data.MySqlClient;

namespace Projeto
{
    class ConexaoBD
    {
        // String de conexão com o banco de dados
        private string conexaoBanco = "Server=localhost; Database=projetoCrud; Uid=root; Pwd=;";

        private MySqlConnection conexao;

        // Abre e retorna a conexão
        public MySqlConnection Conectar()
        {
            if (conexao == null)
            {
                conexao = new MySqlConnection(conexaoBanco);
            }

            if (conexao.State != System.Data.ConnectionState.Open)
            {
                conexao.Open();
            }

            return conexao;
        }

        // Fecha a conexão aberta
        public void Desconectar()
        {
            if (conexao != null && conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}