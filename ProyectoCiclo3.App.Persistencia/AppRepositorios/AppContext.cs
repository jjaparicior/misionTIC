using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Encomienda> Encomiendas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ProyectoCiclo3Amazon");
            }
        }
    }
}
