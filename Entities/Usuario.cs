using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        public string NombreUsuario { get; set; }
        public int Legajo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public bool Habilitado { get; set; }

    }
}
