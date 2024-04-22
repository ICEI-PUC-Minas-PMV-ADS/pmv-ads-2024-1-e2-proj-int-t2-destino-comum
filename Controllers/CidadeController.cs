using DestinoComum.Models;
using Microsoft.AspNetCore.Mvc;

namespace DestinoComum.Controllers
{
    public class CidadeController : Controller
    {
        readonly private AppDbContext _db;// Por padrão, quando se cria uma propriedade privada, adiciona-se "_".
        public CidadeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<CidadeModel> cidades = _db.Cidades;
            return View(cidades);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Editar(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            CidadeModel cidade = _db.Cidades.FirstOrDefault(x => x.IdCidade == id);

            if (cidade == null)
            {
                return NotFound();
            }

            return View(cidade);
        }

        public IActionResult Excluir(int id) 
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }

            CidadeModel cidade = _db.Cidades.FirstOrDefault(x=> x.IdCidade == id);

            if (cidade == null) 
            {
                return NotFound();
            }

            return View(cidade);
        }

        [HttpPost]
        public IActionResult Cadastrar(CidadeModel cidade)
        {
            if (ModelState.IsValid)
            {
                _db.Cidades.Add(cidade);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult Editar(CidadeModel cidade) 
        { 
            if (ModelState.IsValid) 
            { 
                _db.Cidades.Update(cidade);
                _db.SaveChanges();

                return RedirectToAction("Index");   
            } 

            return View(cidade);
        }

        [HttpPost]
        public IActionResult Excluir(CidadeModel cidade) 
        {
            if (cidade == null)
            {
                return NotFound();
            }
            _db.Cidades.Remove(cidade);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
