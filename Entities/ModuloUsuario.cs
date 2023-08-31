using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ModuloUsuario
    {
        public int IdModulo { get; set; }
        public bool Alta { get; set; }
        public bool Baja { get; set; }
        public bool Modificacion { get; set; }
        public bool Consulta { get; set; }

        public ModuloUsuario( int idModulo, bool alta, bool baja, bool modificacion, bool consulta) 
        {
            this.IdModulo = idModulo;
            this.Alta = alta;
            this.Baja = baja;
            this.Modificacion = modificacion;
            this.Consulta = consulta;
        }
        public ModuloUsuario()
        {
            this.IdModulo = 0;
            this.Alta = false;
            this.Baja = false;
            this.Modificacion = false;
            this.Consulta = false;
        }
    }
}
