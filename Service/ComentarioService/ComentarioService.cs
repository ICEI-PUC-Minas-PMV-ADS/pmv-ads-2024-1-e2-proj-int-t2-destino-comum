using DestinoComum.Service.CidadeService;
using DestinoComum2.Models;
using DestinoComum2.Service.SessaoService;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using SQLitePCL;

namespace DestinoComum2.Service.ComentarioService
{
    public class ComentarioService : IComentarioInterface
    {
        private readonly ICidadedeInterface _cidadeInterface;
        private readonly AppDbContext _context;
        private readonly ISessaoInterface _sessaoInterface;

        public ComentarioService(ICidadedeInterface cidadeInterface, AppDbContext context, ISessaoInterface sessaoInterface)
        {
            _cidadeInterface = cidadeInterface;
            _context = context;
            _sessaoInterface = sessaoInterface;
        }

        public async Task<RespostaModel<ComentarioModel>> Comentar(int cidadeId)
        {
            RespostaModel<ComentarioModel> resposta = new RespostaModel<ComentarioModel>();
            try
            {
                var sessaoUsuario = _sessaoInterface.BuscarSessao() ;
                if(sessaoUsuario != null)
                {
                    resposta.Status = false;
                    resposta.Mensagem = "É necessário estar logado para comentar";
                    return resposta;
                }

                var cidade = await _cidadeInterface.BuscarCidadePorId(cidadeId);

                var comentario = new ComentarioModel
                {
                    UsuarioId = sessaoUsuario.Id,
                    CidadeComentarioId = cidade.IdCidade,
                    Usuario = sessaoUsuario,
                    Cidade = cidade
                };
                _context.Add(comentario);
                await _context.SaveChangesAsync();

                resposta.Dados = comentario;
                return resposta;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }



}
