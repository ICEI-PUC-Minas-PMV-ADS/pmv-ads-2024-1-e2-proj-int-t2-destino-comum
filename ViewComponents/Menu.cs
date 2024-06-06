using DestinoComum2.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DestinoComum2.ViewComponents
{
    public class Menu : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("SessaoUsuario");

            if (string.IsNullOrEmpty(sessaoUsuario)) return View();

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
            return View(usuario);

        }

    }
}
