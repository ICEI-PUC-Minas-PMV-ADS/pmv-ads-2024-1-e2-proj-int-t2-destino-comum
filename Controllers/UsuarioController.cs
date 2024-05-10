using DestinoComum2.Dto.Usuario;
using DestinoComum2.Enum;
using DestinoComum2.Models;
using DestinoComum2.Service.UsuarioService;
using Microsoft.AspNetCore.Mvc;

namespace DestinoComum2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioInterface _usuarioInterface;
        public UsuarioController(IUsuarioInterface usuarioInterface) 
        {
            _usuarioInterface = usuarioInterface;
        }
        public async Task<ActionResult> Index(int? id)
        {
            var usuarios = await _usuarioInterface.BuscarUsuarios(id);

            return View(usuarios);
        }

        [HttpGet]
        public ActionResult Cadastrar(int? id) 
        { 
            ViewBag.Perfil = PerfilEnum.Administrador;
            ViewBag.Id = id;

            if(id != null) 
            {
                ViewBag.Perfil = PerfilEnum.Cliente;
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Detalhes (int? id) 
        {
            if (id != null) 
            {
                var usuario = await _usuarioInterface.BuscarUsuarioPorId(id);
                return View(usuario);
            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public async Task<ActionResult> Editar (int? id)
        {
            if(id != null)
            {
                var usuario = await _usuarioInterface.BuscarUsuarioPorId(id);

                var usuarioEditado = new UsuarioEditarDto
                {
                    NomeCompleto = usuario.NomeCompleto,
                    Email = usuario.Email,
                    Usuario=usuario.Usuario,
                    Id = usuario.Id,
                    CPF = usuario.CPF,
                    Perfil = usuario.Perfil,
                };
                if (usuarioEditado.Perfil == PerfilEnum.Cliente)
                {
                    ViewBag.Perfil = PerfilEnum.Cliente;
                }
                else 
                {
                    ViewBag.Perfil = PerfilEnum.Administrador;
                }

                return View(usuarioEditado);
                }


            
            return RedirectToAction("Index");
        }




        [HttpPost]
        public async Task<ActionResult> Cadastrar(UsuarioCriacaoDto usuarioCriacaoDto) 
        {
            if (ModelState.IsValid)
            {
                if (!await _usuarioInterface.VerificaSeExisteUsuarioEmail(usuarioCriacaoDto)) // não existe este email cadastrado
                {
                    TempData["MensagemErro"] = "Já existe e-mail/usuário cadastrado";
                    return View(usuarioCriacaoDto);
                }

                //Cadastra o usuário

                var usuario = await _usuarioInterface.Cadastrar(usuarioCriacaoDto);
                TempData["MensagemSucesso"] = "Usuário cadastrado com sucesso";

                if(usuario.Perfil != PerfilEnum.Cliente) 
                {
                    return RedirectToAction("Index", "Funcionario");
                }

                return RedirectToAction("Index", "Cliente", new { Id = "0" });

            }
            else 
            {
                TempData["MensagemErro"] = "Verifique os dados preenchidos";
                return View(usuarioCriacaoDto);
            }

        }

        [HttpPost]
        public async Task<ActionResult> MudarSituacaoUsuario(UsuarioModel usuario)
        {
            if(usuario.Id != 0 && usuario.Id != null)
            {
                var usuarioBanco = await _usuarioInterface.MudarSituacaoUsuario(usuario.Id);

                
                    if(usuarioBanco.Situacao==true)
                    {
                        TempData["MensagemSucesso"] = "Usuário ativado com sucesso";
                    }
                    else
                    {
                        TempData["MensagemSucesso"] = "Usuário inativado com sucesso";
                    }

                    if(usuarioBanco.Perfil != PerfilEnum.Cliente)
                    {
                        return RedirectToAction("Index", "Funcionario");
                    }
                    else 
                    { 
                        return RedirectToAction("Index","Cliente", new { Id = "0" }); 
                    }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<ActionResult> Editar (UsuarioEditarDto usuarioEditarDto)
        {
            if(ModelState.IsValid)
            {
                var usuario = await _usuarioInterface.Editar(usuarioEditarDto);
                TempData["MensagemSucesso"] = "Usuário editado com sucesso";

                if(usuario.Perfil != PerfilEnum.Cliente)
                {
                    return RedirectToAction("Index", "Funcionario");
                }
                else
                {
                    return RedirectToAction("Index", "Cliente", new {Id="0"});

                }
            }
            else
            {
                TempData["MensagemErro"] = "Verifique os dados preenchidos";
                return View(usuarioEditarDto);
            }
        }

    }
}
