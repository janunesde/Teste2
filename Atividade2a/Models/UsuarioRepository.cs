using MySqlConnector;
using System.Collections.Generic;

namespace Atividade2.Models
{
    public class UsuarioRepository
    {
         private const string _strConexao = "Database=Viagem; Data Source=127.0.0.1; User Id=root; Password=''";

         public void Insert(Usuario u){

             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             /* 
             Usuário Administrador - tipo: 1
            Usuário  Comum - tipo: 2 
             */

             string sql ="INSERT INTO usuario(nome, dataNasc,login, senha, tipo) ";
             sql = sql + "VALUES (@Nome, @DataNascimento, @Login, @Senha, @Tipo)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", u.Nome);
            comando.Parameters.AddWithValue("@DataNascimento", u.DataNascimento);
            comando.Parameters.AddWithValue("@Login", u.Login);
            comando.Parameters.AddWithValue("@Senha", u.Senha);
            comando.Parameters.AddWithValue("@Tipo", u.Tipo);

            comando.ExecuteNonQuery();

            conexao.Close();

         }

         public void Excluir(Usuario u){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "DELETE FROM usuario WHERE id = @Id";
             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@Id",u.Id);
             comando.ExecuteNonQuery();
             conexao.Close();
         }

         public void Editar(Usuario u){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "UPDATE usuario SET nome = @Nome, dataNasc = @DataNascimento,";
             sql = sql + "login = @Login, senha = @Login, tipo = @Tipo";
             sql = sql + "WHERE id = @Id";

             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@Id", u.Id);
             comando.Parameters.AddWithValue("@Nome", u.Nome);
             comando.Parameters.AddWithValue("@dataNascimento", u.DataNascimento);
             comando.Parameters.AddWithValue("@Login", u.Login);
             comando.Parameters.AddWithValue("@Senha", u.Senha);
             comando.Parameters.AddWithValue("@Tipo", u.Tipo);
            }

             public List<Usuario> Listar(){
                  MySqlConnection conexao = new MySqlConnection(_strConexao);  
                  conexao.Open();

                  string sql = "SELECT * FROM usuario";

                  MySqlCommand comando = new MySqlCommand(sql, conexao);

                  MySqlDataReader reader = comando.ExecuteReader();

                  List<Usuario> lista = new List<Usuario>();

                  while (reader.Read()){
                       Usuario user = new Usuario();

                        user.Id = reader.GetInt32("id");
                        if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                            user.Nome = reader.GetString("Nome");
                        if (!reader.IsDBNull(reader.GetOrdinal("dataNasc")))
                            user.DataNascimento = reader.GetString("dataNasc"); 
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

                  MySqlCommand comando = new MySqlCommand(sql, conexao);
                  comando.Parameters.AddWithValue("@Login", u.Login);
                  comando.Parameters.AddWithValue("@Senha", u.Senha);

                 MySqlDataReader reader = comando.ExecuteReader();

                 Usuario user = null;

                 if(reader.Read()){
                     user = new Usuario();
                     user.Id = reader.GetInt32("Id");
                          if (!reader.IsDBNull(reader.GetOrdinal("nome")))
                            user.Nome = reader.GetString("nome");
                        if (!reader.IsDBNull(reader.GetOrdinal("dataNasc")))
                            user.DataNascimento = reader.GetString("dataNasc"); 
                        if (!reader.IsDBNull(reader.GetOrdinal("login")))
                            user.Login = reader.GetString("login");
                        if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                            user.Senha = reader.GetString("senha");  
                        if (!reader.IsDBNull(reader.GetOrdinal("tipo")))
                            user.Tipo = reader.GetInt32("tipo");                           

                 } 
                 conexao.Close();
                 return user;
             }
    }
}