using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Modulo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Modulo(int id, string descripcion) 
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }
        public Modulo() 
        {
            this.Descripcion = "";
        }
    }
}
