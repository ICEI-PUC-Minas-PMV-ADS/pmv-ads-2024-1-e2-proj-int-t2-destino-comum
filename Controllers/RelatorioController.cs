using AutoMapper;
using ClosedXML.Excel;
using DestinoComum.Service.CidadeService;
using DestinoComum2.Dto.Relatorio;
using DestinoComum2.Models;
using DestinoComum2.Service.RelatorioService;
using DestinoComum2.Service.SessaoService;
using DestinoComum2.Service.UsuarioService;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace DestinoComum2.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly ISessaoInterface _sessaoInterface;
        private readonly ICidadedeInterface _cidadedeInterface;
        private readonly IUsuarioInterface _usuarioInterface;
        private readonly IRelatorioInterface _relatorioInterface;
        private readonly IMapper _mapper;

        public RelatorioController(ISessaoInterface sessaoInterface, 
                                    ICidadedeInterface cidadedeInterface, 
                                    IUsuarioInterface usuarioInterface, 
                                    IRelatorioInterface relatorioInterface, 
                                    IMapper mapper) 
        {
            _sessaoInterface = sessaoInterface;
            _cidadedeInterface = cidadedeInterface;
            _usuarioInterface = usuarioInterface;
            _relatorioInterface = relatorioInterface;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult>Gerar (int id)
        {
            var tabela = new DataTable();
            switch (id)
            {
                case 1:
                    List<CidadeModel> cidades = await _cidadedeInterface.BuscarCidades();
                    List<CidadeRelatorioDto> dadosCidade = _mapper.Map < List<CidadeRelatorioDto>>(cidades);
                    tabela = _relatorioInterface.ColetarDados(dadosCidade, id);

                break;
                
                case 2:
                    List<UsuarioModel> clientes = await _usuarioInterface.BuscarUsuarios(0);
                    List<UsuarioRelatorioDto> dadosClientes = new List<UsuarioRelatorioDto>();

                    foreach (var cliente in clientes)
                    {
                        dadosClientes.Add(new UsuarioRelatorioDto
                        {
                            Id = cliente.Id,
                            NomeCompleto = cliente.NomeCompleto,
                            Usuario = cliente.Usuario,
                            Situacao = cliente.Situacao.ToString(),
                            Email = cliente.Email,
                            Perfil = cliente.Perfil.ToString(),
                            CPF = cliente.CPF,
                            DataCadastro = cliente.DataCadastro,
                            DataUltimaAtualizacao=cliente.DataUltimaAtualizacao
                        });
                    }

                    tabela = _relatorioInterface.ColetarDados(dadosClientes, id);

                break;

                case 3:
                    List<UsuarioModel> funcionarios = await _usuarioInterface.BuscarUsuarios(null);
                    List<UsuarioRelatorioDto> dadosFuncionarios = new List<UsuarioRelatorioDto>();

                    foreach (var funcionario in funcionarios)
                    {
                        dadosFuncionarios.Add(new UsuarioRelatorioDto
                        {
                            Id = funcionario.Id,
                            NomeCompleto = funcionario.NomeCompleto,
                            Usuario = funcionario.Usuario,
                            Situacao = funcionario.Situacao.ToString(),
                            Email = funcionario.Email,
                            Perfil = funcionario.Perfil.ToString(),
                            CPF = funcionario.CPF,
                            DataCadastro = funcionario.DataCadastro,
                            DataUltimaAtualizacao = funcionario.DataUltimaAtualizacao
                        });
                    }

                    tabela = _relatorioInterface.ColetarDados(dadosFuncionarios, id);

                    break;
            }

            
            using(XLWorkbook workbook = new XLWorkbook())
            {
                workbook.AddWorksheet(tabela, "Dados");
                using (MemoryStream ms = new MemoryStream())
                {
                    workbook.SaveAs(ms);
                    return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Dados.xls");
                }
            }
        }
    }
}
