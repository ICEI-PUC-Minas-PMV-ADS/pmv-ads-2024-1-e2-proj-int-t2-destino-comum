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


        public HomeController(ILogger<HomeController> logger, ISessaoInterface sessaoInterface, IHomeInterface homeInterface)
        {
            _logger = logger;
            _sessaoInterface = sessaoInterface;
            _homeInterface = homeInterface;
        }
        [HttpGet]
        public IActionResult Index()
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

            return View();
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
