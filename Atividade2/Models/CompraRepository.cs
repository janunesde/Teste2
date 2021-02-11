using MySqlConnector;
using System.Collections.Generic;
namespace Atividade2.Models
{
    public class CompraRepository
    {
        private const string _strConexao = "Database=Viagem; Data Source=127.0.0.1; User Id=root; Password=''";

         public void Insert(Compra cp){

             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             /* 
             Usuário Administrador - tipo: 1
            Usuário  Comum - tipo: 2 
             */

             string sql ="INSERT INTO pacote(idusuario, idpacote, valor, total, pagamento) ";
             sql = sql + "VALUES (@IdUsuario, @IdPacote, @Valor, @Total, @Pagamento)";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@IdUsuario", cp.IdUsuario);
            comando.Parameters.AddWithValue("@IdPacote", cp.IdPacote);
            comando.Parameters.AddWithValue("@Valor", cp.Valor);
            comando.Parameters.AddWithValue("@Total", cp.Total);
            comando.Parameters.AddWithValue("@Pagamento", cp.Pagamento);                       

            comando.ExecuteNonQuery();

            conexao.Close();

         }

         public void Excluir(Compra cp){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "DELETE FROM compra WHERE idcompra = @IdComprar";
             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@IdCompra",cp.IdCompra);
             comando.ExecuteNonQuery();
             conexao.Close();
         }

         public void Editar(Compra cp){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "UPDATE pacote SET nome = @IdUsuario, idpacote = @IdPacote, ";
             sql = sql + "valor = @Valor, total = @Total, pagamento = @Pagamento";
             sql = sql + "WHERE id = @Id";

             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@IdUsuario", cp.IdUsuario);
             comando.Parameters.AddWithValue("@IdPacote", cp.IdPacote);
             comando.Parameters.AddWithValue("@Valor", cp.Valor);
             comando.Parameters.AddWithValue("@Total", cp.Total);
             comando.Parameters.AddWithValue("@Pagamento", cp.Pagamento);
           }

             public List<Compra> Listar(){
                  MySqlConnection conexao = new MySqlConnection(_strConexao);  
                  conexao.Open();

                  string sql = "SELECT * FROM compra";

                  MySqlCommand comando = new MySqlCommand(sql, conexao);

                  MySqlDataReader reader = comando.ExecuteReader();

                  List<Compra> lista = new List<Compra>();

                  while (reader.Read()){
                       Compra compra = new Compra();

                        compra.IdCompra = reader.GetInt32("idcompra");
                        if (!reader.IsDBNull(reader.GetOrdinal("IdUsuario")))
                            compra.IdUsuario = reader.GetInt32("IdUsuario");
                        if (!reader.IsDBNull(reader.GetOrdinal("IdPacote")))
                            compra.IdPacote = reader.GetInt32("IdPacote");    
                        if (!reader.IsDBNull(reader.GetOrdinal("Valor")))
                            compra.Valor = reader.GetDouble("Valor"); 
                        if (!reader.IsDBNull(reader.GetOrdinal("Total")))
                            compra.Total = reader.GetDouble("Total");
                        if (!reader.IsDBNull(reader.GetOrdinal("Pagamento")))
                            compra.Pagamento = reader.GetInt32("Pagamento");                          
                           
                            lista.Add(compra);
                  }
                  conexao.Close();
                  return lista;
             }
    }
}