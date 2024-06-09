using AutoMapper;
using DestinoComum2.Dto.Relatorio;
using DestinoComum2.Enum;
using Newtonsoft.Json;
using System.Data;

namespace DestinoComum2.Service.RelatorioService
{
    public class RelatorioService : IRelatorioInterface
    {
        private readonly IMapper _mapper;

        public RelatorioService(IMapper mapper) 
        {
            _mapper = mapper;
        }
        public DataTable ColetarDados<T>(List<T> dados, int idRelatorio)
        {
            DataTable dataTable = new DataTable();
            dataTable.TableName = System.Enum.GetName(typeof(RelatorioEnum), idRelatorio);


            var colunas = dados.First().GetType().GetProperties();
            foreach (var coluna in colunas)
            {
                Type tipoColuna = coluna.PropertyType;

                // Verificar se o tipo é um tipo nullable e obter o tipo subjacente
                if (tipoColuna.IsGenericType && tipoColuna.GetGenericTypeDefinition() == typeof(Nullable<>))
                {
                    tipoColuna = Nullable.GetUnderlyingType(tipoColuna);
                }

                // Adicionar a coluna ao DataTable
                dataTable.Columns.Add(coluna.Name, tipoColuna);
            }


            switch (idRelatorio)
            {
                case 1://cidade
                    var dadosCidade = JsonConvert.SerializeObject(dados);
                    var dadosCidadeModel = JsonConvert.DeserializeObject<List<CidadeRelatorioDto>>(dadosCidade);

                    if (dadosCidadeModel != null)
                    {
                        return ExportarCidade(dataTable, dadosCidadeModel);
                    }

                break;

                case 2://clientes
                    var dadosCliente=JsonConvert.SerializeObject(dados);
                    var dadosClientesModel = JsonConvert.DeserializeObject<List<UsuarioRelatorioDto>>(dadosCliente);
                    if(dadosClientesModel != null)
                    {
                        return ExportarUsuario(dataTable, dadosClientesModel);
                    }

                    break;

                case 3://funcionarios(adms)
                    var dadosFuncionario = JsonConvert.SerializeObject(dados);
                    var dadosFuncionarioModel = JsonConvert.DeserializeObject<List<UsuarioRelatorioDto>>(dadosFuncionario);
                    if (dadosFuncionarioModel != null)
                    {
                        return ExportarUsuario(dataTable, dadosFuncionarioModel);
                    }

                    break;
            }
            return new DataTable();
        }

        private DataTable ExportarUsuario(DataTable data, List<UsuarioRelatorioDto> dados)
        {
            foreach (var dado in dados)
            {
                data.Rows.Add(dado.Id, dado.NomeCompleto, dado.Usuario, 
                              dado.Situacao == "True" ? "Ativo": "Inativo", dado.Email, dado.Perfil, dado.CPF, 
                              dado.DataCadastro, dado.DataUltimaAtualizacao );
            }

            return data;
        }

        private DataTable ExportarCidade(DataTable data, List<CidadeRelatorioDto> dados)
        {
            foreach (var dado in dados)
            {
                data.Rows.Add(dado.IdCidade, dado.Capa, dado.Nome, dado.Pais, dado.Descricao, dado.TipoDestino, dado.DataUltimaAtualizacao,
                              dado.Clima, dado.PontoTuristico, dado.Alimentacao, dado.Transporte, dado.Acessibilidade);
            }

            return data;
        }

    }
}
