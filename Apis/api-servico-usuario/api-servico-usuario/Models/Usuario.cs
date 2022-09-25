using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static api_servico_usuario.Models.LinkDto;

namespace api_servico_usuario.Models
{
    [Table("Usuarios")]
    public class Usuario : LinksHATEOS
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [JsonIgnore]
        public string Senha { get; set; }
        [Required]
        public bool Ativo { get; set; }
        [Required]
        public Perfil Perfil { get; set; }

        public  Passageiro Passageiro { get; set; }

    }

    public enum Perfil
    {
        [Display(Name = "Usuario")]
        Usuario,
        [Display(Name = "Motorista")]
        Motorista
    }
}