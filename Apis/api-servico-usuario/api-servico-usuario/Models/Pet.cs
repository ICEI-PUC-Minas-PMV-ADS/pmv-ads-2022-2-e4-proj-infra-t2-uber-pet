using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static api_servico_usuario.Models.LinkDto;

namespace api_servico_usuario.Models
{
    [Table("Pets")]
    public class Pet : LinksHATEOS
    {
        [Key]
        public int IdPet { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Descricao { get; set; }
        [Required]
        public Animais Animal { get; set; }
        [Required]
        public PorteDoAnimal Porte { get; set; }
        public int PassageiroId { get; set; } 
        public Passageiro Passageiro { get; set; }

        public enum Animais
        {
            Cachorro,
            Gato,
            Passaros
        }

        public enum PorteDoAnimal
        {
            Pequeno,
            Medio,
            Grande
        }

    }
}
