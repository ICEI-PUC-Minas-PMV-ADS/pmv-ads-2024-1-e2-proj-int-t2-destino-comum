using System.Data;

namespace DestinoComum2.Service.RelatorioService
{
    public interface IRelatorioInterface
    {
        DataTable ColetarDados<T>(List<T> dados, int idRelatorio);
    }
}
