using MySqlConnector;

namespace Cadastros.Models
{
    public class UsuarioRepository
    {
        /* Conectar com o banco de dados*/
        private const string _strConexao = "Database=ProjCadastos; Data Source=localhost; User Id=root;";

        public void Insert(Usuario newUsuario){
            MySqlConnector conexao = new MySqlConnector(_strConexao);
            conexao.Open(); 
            string sql = "INSERT INTO usuario (nome, login, senha) VALUES (@Nome,@Login, @Senha)";
            
            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@Nome", newUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", newUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", newUsuario.Senha);
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}