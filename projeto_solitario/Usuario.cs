using System;
using MySql.Data.MySqlClient;
using Projeto;

namespace projeto_solitario
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        private ConexaoBD conexao = new ConexaoBD();

        public Usuario(int id, string email, string senha)
        {
            Id = id;
            Email = email;
            Senha = senha;
        }

        public void inserir(Usuario usuario)
        {
            string sql = "INSERT INTO usuarios (email, senha) VALUES (@Email, @Senha)";
            MySqlCommand comando = new MySqlCommand(sql, conexao.Conectar());
            comando.Parameters.AddWithValue("@Email", usuario.Email);
            comando.Parameters.AddWithValue("@Senha", usuario.Senha);
            comando.ExecuteNonQuery();
            conexao.Desconectar();
        }

        // (Opcional) método para validar login:
        public static bool ValidarLogin(string email, string senha)
        {
            ConexaoBD conexao = new ConexaoBD();
            string sql = "SELECT COUNT(*) FROM usuarios WHERE email = @Email AND senha = @Senha";
            MySqlCommand comando = new MySqlCommand(sql, conexao.Conectar());
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Senha", senha);
            int resultado = Convert.ToInt32(comando.ExecuteScalar());
            conexao.Desconectar();
            return resultado > 0;
        }
    }
}
