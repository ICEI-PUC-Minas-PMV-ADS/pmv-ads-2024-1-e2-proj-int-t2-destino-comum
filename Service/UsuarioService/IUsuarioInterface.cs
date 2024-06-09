using DestinoComum2.Dto.Usuario;
using DestinoComum2.Models;

namespace DestinoComum2.Service.UsuarioService
{
    public interface IUsuarioInterface
    {
        Task<List<UsuarioModel>> BuscarUsuarios(int? id);
        Task<bool> VerificaSeExisteUsuarioEmail(UsuarioCriacaoDto usuarioCriacaoDto);
        Task<UsuarioCriacaoDto> Cadastrar(UsuarioCriacaoDto usuarioCriacaoDto);
        Task<UsuarioModel> BuscarUsuarioPorId(int? id );
        Task<UsuarioModel> MudarSituacaoUsuario(int id);
        Task<UsuarioModel> Editar(UsuarioEditarDto usuarioEditarDto);




    }
}
