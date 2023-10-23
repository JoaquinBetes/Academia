using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Comision
    {
        public int IdComision { get; set; }
        public string Descripcion { get; set; }
        public int AnioEspecialidad { get; set; }
        public int IDPlan { get; set; }

        public Comision() { }

        public Comision (string descripcion, int anioEspecialidad, int iDPlan)
        {
            Descripcion = descripcion;
            AnioEspecialidad = anioEspecialidad;
            IDPlan = iDPlan;
        }
    }
}
