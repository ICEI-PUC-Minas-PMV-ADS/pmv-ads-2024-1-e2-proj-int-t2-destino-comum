using DestinoComum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;

namespace DestinoComum.Controllers
{
    public class UsuarioController : Controller
    {
        readonly private AppDbContext _db;// Por padrão, quando se cria uma propriedade privada, adiciona-se "_".
        public UsuarioController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Login()
        {
            return View();
        }





        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Cadastrar([Bind("Id,Tipo,NomeUsuario,Email,Senha,ConfirmarSenha,CPF")] UsuarioModel usuario)
        {
            var ExisteEmail = await _db.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email);
            var ExisteCPF = await _db.Usuarios.FirstOrDefaultAsync(u => u.CPF == usuario.CPF);

            if (ExisteEmail != null)
            {
                ModelState.AddModelError("Email", "O email já está em uso.");
            }

            if (ExisteCPF != null)
            {
                ModelState.AddModelError("CPF", "O CPF já está em uso.");
            }

            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                usuario.ConfirmarSenha = BCrypt.Net.BCrypt.HashPassword(usuario.ConfirmarSenha);

                /*CPF.IMain main1 = new CPF.Main();
                var CPFok = main1.CPF(usuario.CPF);
                
                if (CPFok)
                {*/
                _db.Add(usuario);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
                /*}
                 else
                 {
                     ModelState.AddModelError("CPF", "O CPF é inválido.");
                     return View(usuario);
                 }*/


            }
            return View(usuario);
        }





    }
}

