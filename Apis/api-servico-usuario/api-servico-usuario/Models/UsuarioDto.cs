using System.ComponentModel.DataAnnotations;

namespace api_servico_usuario.Models
{
    public class UsuarioDto
    {
        public int? IdUsuario { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public bool Ativo { get; set; }
        [Required]
        public Perfil Perfil { get; set; }

        public Passageiro Passageiro { get; set; }
    }
}
