using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trab001.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "NomeProduto")]
        public string Nome { get; set; }

        
        [Column("Valor",TypeName = "money")]
        [DataType(DataType.Currency)]
        [Display(Name = "Valor")]
        
        [Precision(18,2)]
        public decimal Valor { get; set; }
        
    }
}
