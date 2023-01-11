using Hexagon.Domains.Base;
using Hexagon.Domains.Enums;
using System.ComponentModel.DataAnnotations;

namespace Hexagon.Domains
{
    public class Pessoa : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
        public EstadoCivilEnum EstadoCivil { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

    }
}
