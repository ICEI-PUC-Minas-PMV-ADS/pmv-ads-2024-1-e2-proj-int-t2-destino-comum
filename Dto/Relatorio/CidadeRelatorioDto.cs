using System.ComponentModel.DataAnnotations;

namespace DestinoComum2.Dto.Relatorio
{
    public class CidadeRelatorioDto
    {
        public int IdCidade { get; set; }

        public string Capa { get; set; } = string.Empty;

        public string Nome { get; set; } = string.Empty;

        [Display(Name = "País")]
        public string Pais { get; set; } = string.Empty;

        [Display(Name = "Descrição")]
        public string Descricao { get; set; } = string.Empty; //breve descrição sobre a cidade

        [Display(Name = "Tipo de Destino")]
        public string TipoDestino { get; set; } = string.Empty;

        public DateTime? DataUltimaAtualizacao { get; set; } = DateTime.Now;
        public string Clima { get; set; } = string.Empty;

        [Display(Name = "Ponto Turístico")]
        public string PontoTuristico { get; set; } = string.Empty;

        [Display(Name = "Alimentação")]
        public string Alimentacao { get; set; } = string.Empty;

        public string Transporte { get; set; } = string.Empty;

        public string Acessibilidade { get; set; } = string.Empty;

    }
}
