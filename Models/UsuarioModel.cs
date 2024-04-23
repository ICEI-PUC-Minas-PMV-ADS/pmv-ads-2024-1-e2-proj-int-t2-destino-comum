using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DestinoComum.Models
{
    public enum TipoUsuario
    {
        Padrao,
        Administrador
    }
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        [Display(Name = "Codigo usuario")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar o tipo de usuário")]
        [Display(Name = "Tipo de Usuário")]
        public TipoUsuario Tipo { get; set; }

        [Required(ErrorMessage = "*Obrigatório informar o nome")]
        [Display(Name = "Nome do Usuário")]
        public string NomeUsuario { get; set; }

        [Required(ErrorMessage = "*Obrigatório informar o email")]
        [EmailAddress(ErrorMessage = "*Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Obrigatório digitar uma senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "*Obrigatório digitar a confirmação da senha")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas não são iguais")]
        [Display(Name = "Confirmar a senha")]
        public string ConfirmarSenha { get; set; }

        [Required(ErrorMessage = "*Obrigatório informar o CPF ")]

        [Display(Name = "Informe o CPF")]

        public string CPF { get; set; }


    }
}
