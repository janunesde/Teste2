using MySqlConnector;
using System.Collections.Generic;

namespace Atividade2.Models
{
    public class PacoteRepository
    {
         private const string _strConexao = "Database=Viagem; Data Source=127.0.0.1; User Id=root; Password=''";

         public void Insert(Pacote p){

             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             /* 
             Usuário Administrador - tipo: 1
            Usuário  Comum - tipo: 2 
             */

             string sql ="INSERT INTO pacote(nome, origem, destino, atrativos, saida, retorno, usuario) ";
             sql = sql + "VALUES (@Nome, @Origem, @Destino, @Atrativos, @Saida, @Retorno, @Usuario)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", p.Nome);
            comando.Parameters.AddWithValue("@Origem", p.Origem);
            comando.Parameters.AddWithValue("@Destino", p.Destino);
            comando.Parameters.AddWithValue("@Atrativos", p.Atrativos);
            comando.Parameters.AddWithValue("@Saida", p.Saida);
            comando.Parameters.AddWithValue("@Retorno", p.Retorno);
            comando.Parameters.AddWithValue("@Usuario", p.Usuario);            

            comando.ExecuteNonQuery();

            conexao.Close();

         }

         public void Excluir(Pacote p){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "DELETE FROM pacote WHERE id = @Id";
             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@Id",p.Id);
             comando.ExecuteNonQuery();
             conexao.Close();
         }

         public void Editar(Pacote p){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "UPDATE pacote SET nome = @Nome, destino = @Destino, ";
             sql = sql + "atrativos = @Atrativos, saida = @Saida, retorno = @Retorno, usuario=@Usuario";
             sql = sql + "WHERE id = @Id";

             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@Id", p.Id);
             comando.Parameters.AddWithValue("@Nome", p.Nome);
             comando.Parameters.AddWithValue("@Destino", p.Destino);
             comando.Parameters.AddWithValue("@Atrativos", p.Atrativos);
             comando.Parameters.AddWithValue("@Saida", p.Saida);
             comando.Parameters.AddWithValue("@Retorno", p.Retorno);
             comando.Parameters.AddWithValue("@Usuario", p.Usuario);
            }

             public List<Pacote> Listar(){
                  MySqlConnection conexao = new MySqlConnection(_strConexao);  
                  conexao.Open();

                  string sql = "SELECT * FROM pacote";

                  MySqlCommand comando = new MySqlCommand(sql, conexao);

                  MySqlDataReader reader = comando.ExecuteReader();

                  List<Pacote> lista = new List<Pacote>();

                  while (reader.Read()){
                       Pacote pacote = new Pacote();

                        pacote.Id = reader.GetInt32("id");
                        if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                            pacote.Nome = reader.GetString("Nome");
                        if (!reader.IsDBNull(reader.GetOrdinal("Origem")))
                            pacote.Destino = reader.GetString("Origem");    
                        if (!reader.IsDBNull(reader.GetOrdinal("Destino")))
                            pacote.Destino = reader.GetString("Destino"); 
                        if (!reader.IsDBNull(reader.GetOrdinal("Atrativos")))
                            pacote.Atrativos = reader.GetString("Atrativos");
                        if (!reader.IsDBNull(reader.GetOrdinal("Saida")))
                            pacote.Saida = reader.GetString("Saida");  
                        if (!reader.IsDBNull(reader.GetOrdinal("Retorno")))
                            pacote.Retorno = reader.GetString("Retorno"); 
                        if (!reader.IsDBNull(reader.GetOrdinal("Usuario")))
                            pacote.Usuario = reader.GetInt32("Usuario"); 

                            lista.Add(pacote);
                  }
                  conexao.Close();
                  return lista;
             }
             
    }
}