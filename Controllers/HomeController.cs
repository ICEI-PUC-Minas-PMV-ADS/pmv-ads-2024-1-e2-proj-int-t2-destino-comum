using DestinoComum.Service.CidadeService;
using DestinoComum2.Dto.Home;
using DestinoComum2.Models;
using DestinoComum2.Service.HomeService;
using DestinoComum2.Service.SessaoService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DestinoComum2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISessaoInterface _sessaoInterface;
        private readonly IHomeInterface _homeInterface;
        private readonly ICidadedeInterface _cidadedeInterface;

        public HomeController(ILogger<HomeController> logger, ISessaoInterface sessaoInterface, IHomeInterface homeInterface, ICidadedeInterface cidadedeInterface)
        {
            _logger = logger;
            _sessaoInterface = sessaoInterface;
            _homeInterface = homeInterface;
            _cidadedeInterface = cidadedeInterface;
        }
       
        [HttpGet]
        public async Task<ActionResult> Index(string pesquisar = null)
        {
            var usuarioSessao = _sessaoInterface.BuscarSessao();
            if (usuarioSessao != null)
            {
                ViewBag.LayoutPagina = "_Layout";
            }
            else
            {
                ViewBag.LayoutPagina = "_LayoutDeslogada";
            }

            if(pesquisar == null)
            {
                var cidadesBanco = await _cidadedeInterface.BuscarCidades();
                return View(cidadesBanco);
            }
            else
            {
                var cidadesBanco = await _cidadedeInterface.BuscarCidadesFiltro(pesquisar);
                return View(cidadesBanco);
            }

        }

        [HttpGet]
        public IActionResult Login() 
        {
            if(_sessaoInterface.BuscarSessao() != null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Sair() 
        {
            _sessaoInterface.RemoverSessao();
            TempData["MensagemSucesso"] = "Usuário Deslogado";
            return RedirectToAction("Login", "Home");
        }

        [HttpGet]
        public async Task<ActionResult>Detalhes(int? id)
        {
            var usuarioSessao = _sessaoInterface.BuscarSessao();
            if (usuarioSessao != null) 
            { 
                ViewBag.UsuarioLogado = usuarioSessao.Id;
                ViewBag.LayoutPagina = "_Layout";

            }
            else 
            {
                ViewBag.LayoutPagina = "_LayoutDeslogada";
            }

            var cidade = await _cidadedeInterface.BuscarCidadePorId(id, usuarioSessao);

            if(cidade.Usuario != null)
            {
                if(cidade.Usuario.Comentarios == null)
                {
                    ViewBag.Comentarios = "SemComentarios";
                }
            }

            return View(cidade);

        }




        [HttpPost]
        public async Task<ActionResult>Login (LoginDto loginDto)
        {
            if(ModelState.IsValid)
            {
                var login = await _homeInterface.RealizarLogin(loginDto);

                if(login.Status == false)
                {
                    TempData["MensagemErro"] = login.Mensagem;
                    return View(login.Dados);

                }
                if (login.Dados.Situacao == false)
                {
                    TempData["MensagemErro"] = "Procure o suporte para verificar o status de sua conta";
                    return View("Login");
                }

                _sessaoInterface.CriarSessao(login.Dados);
                TempData["MensagemSucesso"] = login.Mensagem;

                return RedirectToAction("Index");
            }
            else
            {
                return View(loginDto);
            }
        }

    }
}
