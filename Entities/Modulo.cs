using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Modulo
    {
        public string Descripcion { get; set; }

        public Modulo( string descripcion) 
        {
            this.Descripcion = descripcion;
        }
        public Modulo() 
        {
            this.Descripcion = "";
        }
    }
}
