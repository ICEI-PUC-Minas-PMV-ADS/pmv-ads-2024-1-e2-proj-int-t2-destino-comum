using DestinoComum2.Enum;
using System.ComponentModel.DataAnnotations;
namespace DestinoComum2.Dto.Usuario
{
    public class UsuarioEditarDto
    {
        [Display(Name = "Código do usuário")]
        public int Id { get; set; }

        [Required(ErrorMessage = "*Obrigatório informar o nome")]
        [Display(Name = "Nome do Usuário")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required(ErrorMessage = "*Obrigatório informar o usuário")]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; } = string.Empty;


        [Required(ErrorMessage = "*Obrigatório informar o email")]
        [EmailAddress(ErrorMessage = "*Email inválido")]
        public string Email { get; set; } = string.Empty;


        [Required(ErrorMessage = "Obrigatório selecionar um perfil de usuário")]
        [Display(Name = "Perfil do Usuário")]
        public PerfilEnum Perfil { get; set; }


        [Required(ErrorMessage = "*Obrigatório informar o CPF ")]
        [Display(Name = "Informe o CPF")]
        public string CPF { get; set; } = string.Empty;
    }
}
