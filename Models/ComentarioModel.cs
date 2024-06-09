using System.Text.Json.Serialization;

namespace DestinoComum2.Models
{
    public class ComentarioModel
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }

        [JsonIgnore]// não vai aparecer no banco o Usuario.
        public UsuarioModel Usuario { get; set; }

        public int CidadeComentarioId {  get; set; }

        [JsonIgnore]
        public CidadeModel Cidade { get; set; }

        public DateTime DataComentario {  get; set; } = DateTime.Now;

        public DateTime DataAtualizacaoComentario { get; set; }

    }
}


/*Há duas chaves estrangeiras nesta tabela:
- CidadeIdCidade, que referencia a tabela Cidades na coluna IdCidade.
- UsuarioId, que referencia a tabela Usuarios na coluna Id.

Isso significa que cada registro na tabela ComentarioModel está associado a uma cidade específica (referenciada pela coluna CidadeIdCidade) e 
a um usuário específico (referenciado pela coluna UsuarioId).*/