using System.ComponentModel.DataAnnotations;

namespace api_servico_usuario.Models
{
    public class AuthenticateDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
