using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiAngularJS.Domain.Entities
{
    [Table("Estabelecimento")]
    public class Estabelecimento : DbEntity
    {
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
