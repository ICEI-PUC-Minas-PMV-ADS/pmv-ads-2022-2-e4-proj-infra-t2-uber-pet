using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_servico_usuario.Models
{
    [Table("Passageiros")]
    public class Passageiro
    {
        [Key]
        public int IdPassageiro { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string RG { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        public int IdUsuarioForeignKey { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<Pet> Pets { get; set;  }


    }
}
