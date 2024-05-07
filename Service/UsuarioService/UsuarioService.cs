using DestinoComum2.Dto.Usuario;
using DestinoComum2.Models;
using DestinoComum2.Service.Autenticacao;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using SQLitePCL;
using System.Data;

namespace DestinoComum2.Service.UsuarioService
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly AppDbContext _context;
        private readonly IAutenticacaoInterface _autenticacaoInterface;
        public UsuarioService(AppDbContext context, IAutenticacaoInterface autenticacaoInterface) 
        { 
            _context = context;
            _autenticacaoInterface = autenticacaoInterface;
        }

        public async Task<UsuarioModel> BuscarUsuarioPorId(int? id)
        {
            try 
            {   
                var usuario = await _context.Usuarios.FirstOrDefaultAsync(usuarioBanco => usuarioBanco.Id == id);
                return usuario;
            }
            catch (Exception ex) 
            {
                throw new Exception();
            }
        }

        public async Task<List<UsuarioModel>> BuscarUsuarios(int? id)
        {
            try 
            {
                var registros = new List<UsuarioModel>();
                if(id != null)
                {
                    registros = await _context.Usuarios.Where(cliente => cliente.Perfil == 0).ToListAsync(); // Perfil = 0 é cliente / Perfil = 1 é adm.
                }
                else
                {
                    registros = await _context.Usuarios.Where(cliente => cliente.Perfil != 0).ToListAsync();
                }

                return registros;



            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UsuarioCriacaoDto> Cadastrar(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            //try 
            //{
                _autenticacaoInterface.CriarSenhaHash(usuarioCriacaoDto.Senha, out byte[] senhaHash, out byte[] senhaSalt);

                var usuario = new UsuarioModel
                {
                    NomeCompleto = usuarioCriacaoDto.NomeCompleto,
                    Usuario = usuarioCriacaoDto.Usuario,
                    Email = usuarioCriacaoDto.Email,
                    Perfil = usuarioCriacaoDto.Perfil,
                    SenhaHash = senhaHash,
                    SenhaSalt = senhaSalt,
                    CPF = usuarioCriacaoDto.CPF,
                };

                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return usuarioCriacaoDto;


            //}
            //catch (Exception ex) 
            //{ 
            //    throw new Exception(); 
            //}
        }

        public async Task<UsuarioModel> Editar(UsuarioEditarDto usuarioEditarDto)
        {
            try 
            {
                var usuarioEditarBanco = await _context.Usuarios.FirstOrDefaultAsync(usuarioBanco => usuarioBanco.Id == usuarioEditarDto.Id  );

                if (usuarioEditarBanco != null)
                {
                    usuarioEditarBanco.NomeCompleto = usuarioEditarDto.NomeCompleto;
                    usuarioEditarBanco.Usuario = usuarioEditarDto.Usuario;
                    usuarioEditarBanco.Email = usuarioEditarDto.Email;
                    usuarioEditarBanco.Perfil = usuarioEditarDto.Perfil;
                    usuarioEditarBanco.CPF = usuarioEditarDto.CPF;
                    usuarioEditarBanco.DataUltimaAtualizacao = DateTime.Now;

                    _context.Update(usuarioEditarBanco);
                    await _context.SaveChangesAsync();

                    return usuarioEditarBanco;
                }

                return usuarioEditarBanco;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<UsuarioModel> MudarSituacaoUsuario(int id)
        {
            //try 
            //{
                var usuarioMudarSituacao = await _context.Usuarios.FirstOrDefaultAsync(usuarioBanco => usuarioBanco.Id == id);

                if (usuarioMudarSituacao != null)
                {
                    if (usuarioMudarSituacao.Situacao == true)
                    {
                        usuarioMudarSituacao.Situacao = false;
                        usuarioMudarSituacao.DataUltimaAtualizacao = DateTime.Now;
                    }
                    else
                    {
                        usuarioMudarSituacao.Situacao = true;
                        usuarioMudarSituacao.DataUltimaAtualizacao = DateTime.Now;

                    }
                    _context.Update(usuarioMudarSituacao);
                    await _context.SaveChangesAsync();

                    return usuarioMudarSituacao;

                }
                return usuarioMudarSituacao;


            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }

        public async Task<bool> VerificaSeExisteUsuarioEmail(UsuarioCriacaoDto usuarioCriacaoDto)
        {
            try 
            {
                var mesmoUsuario = await _context.Usuarios.FirstOrDefaultAsync(usuarioBanco => usuarioBanco.Email == usuarioCriacaoDto.Email ||
                                                                                               usuarioBanco.Usuario == usuarioCriacaoDto.Usuario);

                if(mesmoUsuario == null) 
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            { 
                throw new Exception();
            }
        }


    }
}
