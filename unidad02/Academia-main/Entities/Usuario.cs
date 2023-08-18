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

        public Usuario()
        {
            NombreUsuario = string.Empty;
            Legajo = 0;
            Clave = string.Empty;
            TipoUsuario = string.Empty;
            Habilitado = false;
        }
        public Usuario(string nombreUsuario, int legajo, string clave, string tipoUsuario, bool habilitado)
        {
            NombreUsuario = nombreUsuario;
            Legajo = legajo;
            Clave = clave;
            TipoUsuario = tipoUsuario;
            Habilitado = habilitado;
        }
    }
}
