using System.ComponentModel.DataAnnotations;

namespace DestinoComum2.Dto.Home
{
    public class LoginDto
    {
        [Required(ErrorMessage = "*Insira o email")]
        [EmailAddress(ErrorMessage = "*Email inválido")]
        public string Email { get; set; } 


        [Required(ErrorMessage = "*Insira a senha")]
        public String Senha { get; set; }
    }
}
