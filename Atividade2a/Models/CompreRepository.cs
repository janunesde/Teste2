namespace Atividade2.Models
{
    public class CompreRepository
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
            comando.Parameters.AddWithValue("@Saida", cp.Saida);
            comando.Parameters.AddWithValue("@Pagamento", p.Pagamento);                       

            comando.ExecuteNonQuery();

            conexao.Close();

         }

         public void Excluir(Compra cp){
             MySqlConnection conexao = new MySqlConnection(_strConexao);
             conexao.Open();

             string sql = "DELETE FROM compra WHERE id = @Id";
             MySqlCommand comando = new MySqlCommand(sql, conexao);
             comando.Parameters.AddWithValue("@Id",p.Id);
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
             comando.Parameters.AddWithValue("@IdUsuario", p.IdUsuario);
             comando.Parameters.AddWithValue("@IdPacote", p.IdPacote);
             comando.Parameters.AddWithValue("@Valor", p.Valor);
             comando.Parameters.AddWithValue("@Total", p.Total);
             comando.Parameters.AddWithValue("@Pagamento", p.Pagamento);
           }

             public List<Pacote> Listar(){
                  MySqlConnection conexao = new MySqlConnection(_strConexao);  
                  conexao.Open();

                  string sql = "SELECT * FROM compra";

                  MySqlCommand comando = new MySqlCommand(sql, conexao);

                  MySqlDataReader reader = comando.ExecuteReader();

                  List<Pacote> lista = new List<Pacote>();

                  while (reader.Read()){
                       Compra compra = new Compra();

                        compra.Id = reader.GetInt32("id");
                        if (!reader.IsDBNull(reader.GetOrdinal("IdUsuario")))
                            compra.IdUsuario = reader.GetInt("IdUsuario");
                        if (!reader.IsDBNull(reader.GetOrdinal("IdPacote")))
                            pacote.IdPacote = reader.GetInt32("IdPacote");    
                        if (!reader.IsDBNull(reader.GetOrdinal("Valor")))
                            pacote.Valor = reader.GetDouble("Valor"); 
                        if (!reader.IsDBNull(reader.GetOrdinal("Total")))
                            pacote.Total = reader.GetDouble("Total");
                        if (!reader.IsDBNull(reader.GetOrdinal("Pagamento")))
                            pacote.Pagamento = reader.GetString("Pagamento");  
                        
                            lista.Add(compra);
                  }
                  conexao.Close();
                  return lista;
             }
    }
}