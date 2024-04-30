using EntityFrameworkLib.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkLib.Models
{
    public class Endereco : IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Rua { get; set; }
        public int? Numero { get; set; }

        [Required, MaxLength(30)]
        public string Cidade { get; set; }

        [Required, MaxLength(2)]
        public string Estado { get; set; }

        public override string ToString() => $"{Rua}, {(Numero.HasValue ? Numero.ToString() : "S/N")} / {Cidade} - {Estado}";
    }
}
