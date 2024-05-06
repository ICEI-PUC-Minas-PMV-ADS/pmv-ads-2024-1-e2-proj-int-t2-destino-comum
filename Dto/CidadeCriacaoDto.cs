using System.ComponentModel.DataAnnotations;

namespace DestinoComum2.Dto
{
    public class CidadeCriacaoDto
    {
        [Key]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da cidade")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório informar o país da cidade")]
        [Display(Name = "País")]
        public string Pais { get; set; } = string.Empty;

        [Required(ErrorMessage = "Obrigatório fornecer uma breve descrição da cidade")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty; //breve descrição sobre a cidade

        [Required(ErrorMessage = "Obrigatório fornecer o tipo de destino")]
        [Display(Name = "Tipo de Destino")]
        public string TipoDestino { get; set; } = string.Empty;
        public DateTime? DataUltimaAtualizacao { get; set; } = DateTime.Now;

        //Informações sobre a cidade
        public string Clima { get; set; } = string.Empty;

        [Display(Name = "Ponto Turístico")]
        public string PontoTuristico { get; set; } = string.Empty;

        [Display(Name = "Alimentação")]
        public string Alimentacao { get; set; } = string.Empty;

        public string Transporte { get; set; } = string.Empty;

        public string Acessibilidade { get; set; } = string.Empty;


    }
}
