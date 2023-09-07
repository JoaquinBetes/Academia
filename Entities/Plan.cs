using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Plan
    {
        public int IdPlan { get; set; }
        public string Descripcion { get; set; }
        public int IdEspecialidad { get; set; }

        public Plan() { }
        public Plan(int idPlan, string descripcion, int idEspecialidad) 
        { 
            IdPlan = idPlan;
            Descripcion = descripcion;
            IdEspecialidad = idEspecialidad;
        }
    }
}
