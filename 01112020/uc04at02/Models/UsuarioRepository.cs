using System.Collections.Generic;
using MySqlConnector; //dotnet add package MySqlConnector

namespace uc04at02.Models
{
    public class UsuarioRepository
    {
        private const string _strConexao = "Database=lenobrega;Data Source=127.0.0.1;User Id=profmauro;Password=password";

        public void Insert(Usuario u){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "INSERT INTO usuario(nome, dataNascimento, login, senha, tipo) ";
            sql = sql + "VALUES (@Nome, @DataNascimento, @Login, @Senha, @Tipo)";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@Nome",u.Nome);
            comando.Parameters.AddWithValue("@DataNascimento",u.DataNascimento);
            comando.Parameters.AddWithValue("@Login",u.Login);
            comando.Parameters.AddWithValue("@Senha",u.Senha);
            comando.Parameters.AddWithValue("@Tipo",u.Tipo);

            comando.ExecuteNonQuery();

            conexao.Close();
            
        }

        public void Excluir(Usuario u){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "DELETE FROM usuario WHERE id = @Id";
            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@Id",u.Id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public void Editar(Usuario u){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "UPDATE usuario SET nome = @Nome, dataNascimento = @DataNascimento,";
            sql = sql + "login = @Login, senha = @Senha, tipo = @Tipo";
            sql = sql + "WHERE id = @Id";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@ID",u.Id);
            comando.Parameters.AddWithValue("@Nome",u.Nome);
            comando.Parameters.AddWithValue("@DataNascimento",u.DataNascimento);
            comando.Parameters.AddWithValue("@Login",u.Login);
            comando.Parameters.AddWithValue("@Senha",u.Senha);
            comando.Parameters.AddWithValue("@Tipo",u.Tipo);

        }

        public List<Usuario> Listar(){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            // string sql = "SELECT * FROM pacote WHERE usuario = 1";
            string sql = "SELECT * FROM usuario";

            MySqlCommand comando = new MySqlCommand(sql,conexao);

            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> lista = new List<Usuario>();

            while(reader.Read()){
                Usuario user = new Usuario();

                user.Id = reader.GetInt32("Id");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome"))) 
                    user.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento"))) 
                    user.DataNascimento = reader.GetString("DataNascimento");
                if (!reader.IsDBNull(reader.GetOrdinal("Login"))) 
                    user.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha"))) 
                    user.Senha = reader.GetString("Senha");
                if (!reader.IsDBNull(reader.GetOrdinal("Tipo"))) 
                    user.Tipo = reader.GetInt32("Tipo");
                
                lista.Add(user);
            }
            conexao.Close();
            return lista;

        }

        public Usuario Login(Usuario u){
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string sql = "SELECT * FROM usuario WHERE login = @Login AND senha = @Senha";

            MySqlCommand comando = new MySqlCommand(sql,conexao);
            comando.Parameters.AddWithValue("@Login",u.Login);
            comando.Parameters.AddWithValue("@Senha",u.Senha);

            MySqlDataReader reader = comando.ExecuteReader();

            Usuario user = null;

            if(reader.Read()){
                user = new Usuario();
                user.Id = reader.GetInt32("Id");
                if (!reader.IsDBNull(reader.GetOrdinal("Nome"))) 
                    user.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("DataNascimento"))) 
                    user.DataNascimento = reader.GetString("DataNascimento");
                if (!reader.IsDBNull(reader.GetOrdinal("Login"))) 
                    user.Login = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha"))) 
                    user.Senha = reader.GetString("Senha");
                if (!reader.IsDBNull(reader.GetOrdinal("Tipo"))) 
                    user.Tipo = reader.GetInt32("Tipo");
            }
            conexao.Close();
            return user;

        }
    }
}