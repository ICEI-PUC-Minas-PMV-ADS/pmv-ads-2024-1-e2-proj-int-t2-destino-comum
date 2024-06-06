using DestinoComum2.Dto;
using DestinoComum2.Models;

namespace DestinoComum.Service.CidadeService
{
    public interface ICidadedeInterface
    {
        Task<List<CidadeModel>> BuscarCidades();
        bool VerificaExisteCadastro(CidadeCriacaoDto cidadesCriacaoDto);
        Task<CidadeModel> Cadastrar(CidadeCriacaoDto cidadeCriacaoDto, IFormFile foto );
        Task<CidadeModel> BuscarCidadePorId(int? id);
        Task<ComentarioModel> BuscarCidadePorId(int? id, UsuarioModel usuarioSessao);
        Task<CidadeModel> Editar(CidadeEdicaoDto cidadeCriacaoDto, IFormFile foto);
        Task<List<CidadeModel>> BuscarCidadesFiltro(string pesquisar);



    }
}
