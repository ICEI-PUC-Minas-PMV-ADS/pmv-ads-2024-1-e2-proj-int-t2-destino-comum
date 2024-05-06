using ClosedXML.Excel;
using DestinoComum2.Models;
using DestinoComum.Service.CidadeService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using System.Data;
using AutoMapper;
using DestinoComum2.Dto;


namespace DestinoComum2.Controllers
{
    //[Authorize(Roles = "Administrador")]
    public class CidadeController : Controller
    {
        private readonly ICidadedeInterface _cidadedeInterface;
        private readonly IMapper _mapper;
        public CidadeController(ICidadedeInterface cidadedeInterface, IMapper mapper)

        {
            _cidadedeInterface = cidadedeInterface;
            _mapper = mapper;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult<List<CidadeModel>>>Index()
        {
            var cidades = await _cidadedeInterface.BuscarCidades();
            return View(cidades);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Detalhes(int? id)
        {
            if (id != null)
            {
                var cidade = await _cidadedeInterface.BuscarCidadePorId(id);
                return View(cidade);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Editar(int? id)
        {
            if (id != null)
            {
                var cidade = await _cidadedeInterface.BuscarCidadePorId(id);
                var cidadeEdicaoDto = _mapper.Map<CidadeEdicaoDto>(cidade);

                return View(cidadeEdicaoDto);
            }
            return RedirectToAction("Index");
        }








        [HttpPost]
        public async Task<ActionResult> Cadastrar(CidadeCriacaoDto cidadesCriacaoDto, IFormFile foto)
        {
                if(foto != null)
                {
                    if (ModelState.IsValid)
                    {
                        if (!_cidadedeInterface.VerificaExisteCadastro(cidadesCriacaoDto))
                        {
                            TempData["MensagemErro"] = "Cidade já cadastrada";
                            return View(cidadesCriacaoDto);
                        }

                        var cidade = await _cidadedeInterface.Cadastrar(cidadesCriacaoDto, foto);
                        
                        TempData["MensagemSucesso"] = "Cidade cadastrada com sucesso";
                        return RedirectToAction("Index");
                    }
                    else 
                    {
                    TempData["MensagemErro"] = "Verifique os dados preenchidos";
                    return View(cidadesCriacaoDto); 
                    }
                }
                else 
                {
                TempData["MensagemErro"] = "Inclua uma imagem na capa";
                return View(cidadesCriacaoDto); 
                }
        }

        [HttpPost]
        public async Task<ActionResult> Editar(CidadeEdicaoDto cidadeEdicaoDto, IFormFile? foto)
        {
            if (ModelState.IsValid) 
            {
                var cidade = await _cidadedeInterface.Editar(cidadeEdicaoDto, foto);

                TempData["MensagemSucesso"] = "Cidade editada com sucesso";
                return RedirectToAction("Index");
            }
            else
            {
                TempData["MensagemErro"] = "Verifique os dados preenchidos";
                return View(cidadeEdicaoDto);
            }

        }


    }
}

