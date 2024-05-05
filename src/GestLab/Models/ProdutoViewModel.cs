using System.ComponentModel.DataAnnotations;

namespace GestLab.Models
{
    public class ProdutoViewModel
    {
        public string Cor { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        [Range(1, 40)]
        public int Quantidade { get; set; }
    }
}
