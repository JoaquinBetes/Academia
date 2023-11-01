using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UIWeb.Models;

namespace UIWeb.Data
{
    public class UIWebContext : DbContext
    {
        public UIWebContext (DbContextOptions<UIWebContext> options)
            : base(options)
        {
        }

        public DbSet<UIWeb.Models.Usuario> Usuarios { get; set; } = default!;

        public DbSet<UIWeb.Models.Especialidad> Especialidades { get; set; } = default!;

        public DbSet<UIWeb.Models.Persona> Personas { get; set; } = default!;
    }
}
