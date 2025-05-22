using MySql.Data.MySqlClient;

namespace projeto_solitario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string senha = txtSenha.Text;

            using (MySqlConnection conn = new MySqlConnection("server=localhost;database=projetoCrud;uid=root;pwd=;"))
            {
                conn.Open();
                string query = "SELECT * FROM usuarios WHERE email = @email AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@senha", senha);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login bem-sucedido!");
                    new FormProdutos().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Email ou senha incorretos.");
                }
            }

        }
    }
}
 