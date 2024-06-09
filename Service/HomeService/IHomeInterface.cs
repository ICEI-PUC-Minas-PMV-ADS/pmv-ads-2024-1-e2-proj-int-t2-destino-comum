using DestinoComum2.Dto.Home;
using DestinoComum2.Models;

namespace DestinoComum2.Service.HomeService
{
    public interface IHomeInterface
    {

        Task<RespostaModel<UsuarioModel>> RealizarLogin(LoginDto loginDto);

    }
}
