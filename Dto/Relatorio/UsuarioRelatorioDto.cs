using DestinoComum2.Enum;
using System.ComponentModel.DataAnnotations;

namespace DestinoComum2.Dto.Relatorio
{
    public class UsuarioRelatorioDto
    {

        [Display(Name = "Código do usuário")]
        public int Id { get; set; }

        [Display(Name = "Nome do Usuário")]
        public string NomeCompleto { get; set; } = string.Empty;

        [Display(Name = "Usuário")]
        public string Usuario { get; set; } = string.Empty;

        [Display(Name = "SItuação do Usuário")]
        public string Situacao { get; set; }

        public string Email { get; set; } = string.Empty;
              
        [Display(Name = "Perfil do Usuário")]
        public string Perfil { get; set; }

        [Display(Name = "Informe o CPF")]
        public string CPF { get; set; } = string.Empty;

        [Display(Name = "Data do Cadastro")]
        public DateTime? DataCadastro { get; set; } = DateTime.Now;

        [Display(Name = "Data da Alteração do Cadastro")]
        public DateTime? DataUltimaAtualizacao { get; set; } = DateTime.Now;


    }
}
