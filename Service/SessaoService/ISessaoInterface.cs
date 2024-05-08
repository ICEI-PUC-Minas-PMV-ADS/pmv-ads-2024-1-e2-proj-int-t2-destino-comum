using DestinoComum2.Models;

namespace DestinoComum2.Service.SessaoService
{
    public interface ISessaoInterface
    {
        UsuarioModel BuscarSessao();
        void CriarSessao(UsuarioModel usuario);
        void RemoverSessao();
    }
}
