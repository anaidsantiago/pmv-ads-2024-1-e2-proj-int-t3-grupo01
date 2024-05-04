namespace GestLab.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public ClienteModel Cliente { get; set; }
        public ReceitaModel Receita { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorPedido { get; set; }
    }
}
