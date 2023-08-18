using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Especialidad
    {
        public int IdEspecialidad { get; set; }
        public string Descripcion { get; set; }

        public Especialidad() 
        { 
            IdEspecialidad = 0;
            Descripcion = string.Empty;
        }
    }
    
}
