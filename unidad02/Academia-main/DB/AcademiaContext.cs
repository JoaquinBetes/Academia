using Microsoft.EntityFrameworkCore;

namespace DB
{
    public class AcademiaContext: DbContext
    {
        public AcademiaContext( DbContextOptions<AcademiaContext> options )
            :base(options)
        { 
              
        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Especialidad> Especialidades { get; set;}
    }
}