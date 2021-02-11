namespace Atividade2.Models
{
    public class Compra
    {
         public int IdCompra{get; set;}
        public int IdUsuario {get; set;}
        public int IdPacote {get; set;}
        public double Valor {get; set;}
        public double Total {get; set;}
        public int Pagamento {get; set;} 
    }
}