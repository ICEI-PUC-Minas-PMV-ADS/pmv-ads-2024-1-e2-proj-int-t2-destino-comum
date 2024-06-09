using DestinoComum.Service.CidadeService;
using DestinoComum2.Service.ComentarioService;
using DestinoComum2.Service.SessaoService;
using Microsoft.AspNetCore.Mvc;

namespace DestinoComum2.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly ISessaoInterface _sessaoInterface;
        private readonly ICidadedeInterface _cidadedeInterface;
        private readonly IComentarioInterface _comentarioInterface;

        public ComentarioController(ISessaoInterface sessaoInterface, ICidadedeInterface cidadedeInterface, IComentarioInterface comentarioInterface) 
        {
            _sessaoInterface = sessaoInterface;
            _cidadedeInterface = cidadedeInterface;
            _comentarioInterface = comentarioInterface;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Comentar (int id)
        {
            var sessaoUsuario = _sessaoInterface.BuscarSessao();
            if(sessaoUsuario == null)
            {
                TempData["MensagemErro"] = "É necessário estar logado para comentar";
                return RedirectToAction("Login", "Home");
            }

            var comentar = await _comentarioInterface.Comentar(id);
            TempData["MensagemSucesso"] = "Comentário realizado com sucesso";

            return RedirectToAction("Index", "Home");
        }
    }
}
