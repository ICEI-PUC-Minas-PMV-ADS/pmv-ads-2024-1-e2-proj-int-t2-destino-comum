using DestinoComum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DestinoComum.Controllers
    //teste
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

        // Agrupar as cidades pelo TipoDestino
        public async Task<IActionResult> Destino()
        {

            var cidadesAgrupadas = await _db.Cidades
                .GroupBy(c => c.TipoDestino)
                .ToListAsync();

            return View(cidadesAgrupadas);
        }

        // Pagina destino detalhada
        public async Task<IActionResult> DestinoDetalhe(Destino destino)
        {
            var cidades = await _db.Cidades
                .Where(c => c.TipoDestino == destino) 
                .ToListAsync();

            return View(cidades);
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
