using MySqlConnector;
using System.Collections.Generic;

namespace Cadastros.Models
{
    public class UsuarioRepository
    {
        /* Conectar com o banco de dados*/
        private const string _strConexao = "Database=ProjCadastros; Data Source=localhost; User Id=root; Password=''";
        public void Insert(Usuario newUsuario){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open(); 
            string sql = "INSERT INTO usuario (nome, login, senha) VALUES (@Nome, @Login, @Senha)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", newUsuario.Nome);
            comando.Parameters.AddWithValue("@Login", newUsuario.Login);
            comando.Parameters.AddWithValue("@Senha", newUsuario.Senha);
            comando.ExecuteNonQuery();
            conexao.Close();
            
        }
        public List<Usuario> Query()
        {
                MySqlConnection conexao = new MySqlConnection(_strConexao);
                conexao.Open();
                string sql = "SELECT * FROM usuario ORDER BY nome";
                MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
                MySqlDataReader reader = comandoQuery.ExecuteReader();
                List<Usuario> lista = new List<Usuario>();
                while (reader.Read())
                {
                    Usuario usr = new Usuario();
                    usr.Id = reader.GetInt32("Id");
       
                    if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    usr.Nome = reader.GetString("Nome");
       
                    if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                        usr.Login = reader.GetString("Login");
                    if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                        usr.Senha = reader.GetString("Senha");
                    lista.Add(usr);
                }
            conexao.Close();
            return lista;
        }

        public Usuario QueryLogin(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM usuario WHERE login = @Login AND senha = @Senha";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@Login", u.Login);
            comandoQuery.Parameters.AddWithValue("@Senha", u.Senha);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Usuario usr = null;
            if(reader.Read())
            {
                usr = new Usuario();
                usr.Id = reader.GetInt32("Id");
                if(!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    usr.Nome = reader.GetString("Nome");
       
                if(!reader.IsDBNull(reader.GetOrdinal("Login")))
                    usr.Login = reader.GetString("Login");
                if(!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    usr.Senha = reader.GetString("Senha");
            }
   
            conexao.Close();
            return usr;
        }

    }

}