using DestinoComum2.Dto.Home;
using DestinoComum2.Models;
using DestinoComum2.Service.Autenticacao;
using Microsoft.EntityFrameworkCore;

namespace DestinoComum2.Service.HomeService
{
    public class HomeService : IHomeInterface
    {
        private readonly AppDbContext _context;
        private readonly IAutenticacaoInterface _autenticacaoInterface;

        public HomeService(AppDbContext context, IAutenticacaoInterface autenticacaoInterface)
        {
            _context = context;
            _autenticacaoInterface = autenticacaoInterface;
        }
        public async Task<RespostaModel<UsuarioModel>> RealizarLogin(LoginDto loginDto)
        {
            RespostaModel<UsuarioModel> resposta = new RespostaModel<UsuarioModel>();
            //try
            //{
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(usuarioBanco => usuarioBanco.Email == loginDto.Email);
                if (usuario == null)
                {
                    resposta.Dados = null;
                    resposta.Mensagem = "Credenciais inválidas";
                    resposta.Status = false;

                    return resposta;
                }

                if (!_autenticacaoInterface.VerificaLogin(loginDto.Senha, usuario.SenhaHash, usuario.SenhaSalt))
                {
                    resposta.Dados = null;
                    resposta.Mensagem = "Credenciais inválidas";
                    resposta.Status = false;

                    return resposta;

                }

                resposta.Dados = usuario;
                resposta.Mensagem = "Login Efetuado com Sucesso";

                return resposta;

            //}
            //catch (Exception ex)
            //{
            //    resposta.Mensagem = ex.Message;
            //    resposta.Status = false;

            //    return resposta;
            //}



        }
    }
}
