namespace Atividade2.Models
{
    public class Compre
    {
         public int IdCompra{get; set;}
        public int IdUsuario {get; set;}
        public int IdPacote {get; set;}
        public double Valor {get; set;}
        public double Total {get; set;}
        public string Pagamento {get; set;} 
    }
}