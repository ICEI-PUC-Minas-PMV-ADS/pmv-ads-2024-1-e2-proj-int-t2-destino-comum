using DestinoComum2.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DestinoComum2.Models
{
    [Table("Usuarios")]
    public class UsuarioModel
    {
        [Key]
        [Display(Name = "Código do usuário")]
        public int Id { get; set; }

        [Required(ErrorMessage = "*Obrigatório informar o nome")]
        [Display(Name = "Nome do Usuário")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; } = string.Empty;


        [Required(ErrorMessage = "*Obrigatório informar a situação do usuário")]
        [Display(Name = "SItuação do Usuário")]
        public bool Situacao { get; set; } = true;


        [Required(ErrorMessage = "*Obrigatório informar o email")]
        [EmailAddress(ErrorMessage = "*Email inválido")]
        public string Email { get; set; } = string.Empty;


        [Required(ErrorMessage = "*Obrigatório digitar uma senha")]
        public byte[] SenhaHash { get; set; }

        [Required]
        public byte[] SenhaSalt { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar o perfil de usuário")]
        [Display(Name = "Perfil do Usuário")]
        public PerfilEnum Perfil { get; set; }


        [Required(ErrorMessage = "*Obrigatório informar o CPF ")]
        [Display(Name = "Informe o CPF")]
        public string CPF { get; set; } = string.Empty;


        [Display(Name = "Data do Cadastro")]
        public DateTime? DataCadastro { get; set; } = DateTime.Now;


        [Display(Name = "Data da Alteração do Cadastro")]
        public DateTime? DataUltimaAtualizacao { get; set; } = DateTime.Now;


    }
}
