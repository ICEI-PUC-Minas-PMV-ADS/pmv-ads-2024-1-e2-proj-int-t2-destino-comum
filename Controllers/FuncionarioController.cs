using DestinoComum2.Service.UsuarioService;
using Microsoft.AspNetCore.Mvc;

namespace DestinoComum2.Controllers
{
    public class FuncionarioController : Controller
    {
        private readonly IUsuarioInterface _usuarioInterface;
        public FuncionarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }

        public IUsuarioInterface UsuarioInterface { get; }

        public async Task<ActionResult> Index()
        {
            var funcionarios = await _usuarioInterface.BuscarUsuarios(null);

            return View(funcionarios);
        }
    }
}
