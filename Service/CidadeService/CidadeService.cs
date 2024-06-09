using AutoMapper;
using DestinoComum2.Dto;
using DestinoComum2.Models;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DestinoComum.Service.CidadeService
{
    public class CidadeService : ICidadedeInterface
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private string _caminhoServidor;

        public CidadeService(AppDbContext context, IWebHostEnvironment sistema, IMapper mapper)
        {
            _context = context;
            _caminhoServidor = sistema.WebRootPath;
            _mapper = mapper;
        }

        public async Task<List<CidadeModel>> BuscarCidades()
        {
            try
            {
                return await _context.Cidades.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao buscar cidades.", ex);
            }
        }

        public bool VerificaExisteCadastro(CidadeCriacaoDto cidadesCriacaoDto)
        {
            try
            {
                var cidadeBanco = _context.Cidades.FirstOrDefault(cidade => cidade.Nome == cidadesCriacaoDto.Nome);
                if (cidadeBanco != null) { return false; }
                return true;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<CidadeModel> Cadastrar(CidadeCriacaoDto cidadeCriacaoDto, IFormFile foto)
        {
            try 
            {
                var nomeCaminhoDaImagem = GeraCaminhoArquivo(foto);

                //var cidade = new CidadeModel
                //{
                //    Capa = nomeCaminhoDaImagem,
                //    Nome = cidadeCriacaoDto.Nome,
                //    Pais = cidadeCriacaoDto.Pais,
                //    Descricao = cidadeCriacaoDto.Descricao,
                //    TipoDestino = cidadeCriacaoDto.TipoDestino,
                //    Clima = cidadeCriacaoDto.Clima,
                //    PontoTuristico = cidadeCriacaoDto.PontoTuristico,
                //    Alimentacao = cidadeCriacaoDto.Alimentacao,
                //    Transporte = cidadeCriacaoDto.Transporte,
                //    Acessibilidade = cidadeCriacaoDto.Acessibilidade,
                //};

                var cidade = _mapper.Map<CidadeModel>(cidadeCriacaoDto);
                cidade.Capa = nomeCaminhoDaImagem;

                _context.Add(cidade);
                await _context.SaveChangesAsync();

                return cidade;
            }

            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public async Task<CidadeModel> BuscarCidadePorId(int? id)
        {
            try 
            {
                var cidade = await _context.Cidades.FirstOrDefaultAsync(c => c.IdCidade == id);
                return cidade;

            }

            catch (Exception ex) 
            {
                throw new Exception(ex.Message); 
            }
        }

        public async Task<CidadeModel> Editar(CidadeEdicaoDto cidadeEdicaoDto, IFormFile foto)
        {
            try
            {
                var cidade = await _context.Cidades.FirstOrDefaultAsync(c => c.IdCidade == cidadeEdicaoDto.IdCidade);

                var nomeCaminhoDaImagem = "";

                if (foto != null)
                {
                    string caminhoCapaExistente = _caminhoServidor + "\\Imagem\\" + cidade.Capa;
                    if (File.Exists(caminhoCapaExistente))
                    {
                        File.Delete(caminhoCapaExistente);
                    }
                    nomeCaminhoDaImagem = GeraCaminhoArquivo(foto);
                }

                var cidadeModel = _mapper.Map<CidadeModel>(cidadeEdicaoDto);

                if (nomeCaminhoDaImagem != "")
                {
                    cidadeModel.Capa = nomeCaminhoDaImagem;
                }
                else
                {
                    cidadeModel.Capa = cidade.Capa;
                }

                cidadeModel.DataUltimaAtualizacao = DateTime.Now;

                // Remova o rastreamento da entidade existente
                _context.Entry(cidade).State = EntityState.Detached;

                // Associe a entidade atualizada ao contexto
                _context.Attach(cidadeModel);

                // Marque a entidade como modificada
                _context.Entry(cidadeModel).State = EntityState.Modified;

                await _context.SaveChangesAsync();
                return cidadeModel;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string GeraCaminhoArquivo(IFormFile foto) 
        {
            var codigoUnico = Guid.NewGuid().ToString();
            var nomeCaminhoDaImagem = foto.FileName.Replace(" ", "").ToLower() + codigoUnico  + ".png";

            string caminhoSalvarImagens = _caminhoServidor + "\\Imagem\\";
            if (!Directory.Exists(caminhoSalvarImagens)) { Directory.CreateDirectory(caminhoSalvarImagens); }
            using (var stream = System.IO.File.Create(caminhoSalvarImagens + nomeCaminhoDaImagem)) { foto.CopyToAsync(stream).Wait(); }

            return nomeCaminhoDaImagem;
        }

        public async Task<List<CidadeModel>> BuscarCidadesFiltro(string pesquisar)
        {
            try 
            {
                var cidades = await _context.Cidades.Where(cidade => cidade.Nome.Contains(pesquisar)).ToListAsync();
                return cidades;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<ComentarioModel> BuscarCidadePorId(int? id, UsuarioModel usuarioSessao)
        {
            try
            {
                //Usuario Deslogado
                if(usuarioSessao == null)
                {
                    var comentarioSemUsuario = await _context.Comentarios.Include(cidade=> cidade.Cidade).FirstOrDefaultAsync(comentario => comentario.CidadeComentarioId == id);

                    if(comentarioSemUsuario == null)
                    {
                        var cidade = await BuscarCidadePorId(id);

                        var comentarioBanco = new ComentarioModel()
                        {
                            Cidade = cidade,
                            Usuario = null,
                        };
                        return comentarioBanco;
                    }
                    return comentarioSemUsuario;
                }

                var comentario = await _context.Comentarios
                    .Include(cidade => cidade.Cidade)
                    .Include(usuario => usuario.Usuario)
                    .FirstOrDefaultAsync(comentario => comentario.CidadeComentarioId== id && comentario.DataComentario != null && comentario.Usuario.Id == usuarioSessao.Id);

                if(comentario == null)
                {
                    var cidade = await BuscarCidadePorId (id);
                    var comentarioBanco = new ComentarioModel()
                    {
                        Cidade = cidade,
                        Usuario = usuarioSessao,
                    };

                    return comentarioBanco;
                }

                return comentario;

            }

            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }



        }
    }


}




