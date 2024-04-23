using Microsoft.EntityFrameworkCore;

namespace DestinoComum.Models
{
    public class AppDbContext : DbContext // classe responsável por gerar as tabelas no BD.
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }


    }
}
