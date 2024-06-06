using DestinoComum2.Service.UsuarioService;
using Microsoft.AspNetCore.Mvc;

namespace DestinoComum2.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IUsuarioInterface _usuarioInterface;
        public ClienteController(IUsuarioInterface usuarioInterface) 
        { 
            _usuarioInterface = usuarioInterface;
        }
        public async Task<ActionResult> Index(int? id)
        {
            var clientes = await _usuarioInterface.BuscarUsuarios(id);

            return View(clientes);
        }
    }
}
