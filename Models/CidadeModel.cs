using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DestinoComum.Models
{
    [Table("Cidades")]
    public class CidadeModel
    {
        [Key]
        public int IdCidade { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome da cidade")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o país da cidade")]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "Obrigatório fornecer uma breve descrição da cidade")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }//breve descrição sobre a cidade

        [Required(ErrorMessage = "Obrigatório fornecer o tipo de destino")]
        [Display(Name = "Tipo de Destino")]
        public string TipoDestino { get; set; }

        public DateTime? DataUltimaAtualizacao { get; set; } = DateTime.Now;

        //Informações sobre a cidade
        public string Clima { get; set; }

        [Display(Name = "Ponto Turístico")]
        public string PontoTuristico { get; set; }

        [Display(Name = "Alimentação")]
        public string Alimentacao { get; set; }

        public string Transporte { get; set; }

        public string Acessibilidade { get; set; }

    }


}
