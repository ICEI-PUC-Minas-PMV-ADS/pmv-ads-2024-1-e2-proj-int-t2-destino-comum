using Microsoft.EntityFrameworkCore;
using DestinoComum2.Dto.Usuario;

namespace DestinoComum2.Models
{
    public class AppDbContext : DbContext // classe responsável por gerar as tabelas no BD.
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<DestinoComum2.Dto.Usuario.UsuarioCriacaoDto> UsuarioCriacaoDto { get; set; }
        public DbSet<DestinoComum2.Dto.Usuario.UsuarioEditarDto> UsuarioEditarDto { get; set; }
        //public DbSet<ComentarioModel> Comentarios { get; set; }



    }
}
