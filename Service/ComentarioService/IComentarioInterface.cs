using DestinoComum2.Models;

namespace DestinoComum2.Service.ComentarioService
{
    public interface IComentarioInterface
    {
        Task<RespostaModel<ComentarioModel>> Comentar (int cidadeId);
    }
}
