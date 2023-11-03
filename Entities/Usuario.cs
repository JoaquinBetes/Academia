using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public int IdPlan { get; set; }
        public string NombreUsuario { get; set; }
        public int Legajo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public bool Habilitado { get; set; }
        public int PersonaId { get; set; }

        public Usuario()
        {
            Id = 0;
            NombreUsuario = string.Empty;
            Legajo = 0;
            Clave = string.Empty;
            TipoUsuario = string.Empty;
            Habilitado = false;
            IdPlan = 0;
    }
        public Usuario(int id, string nombreUsuario, int legajo, string clave, string tipoUsuario, bool habilitado, int idPlan, int personaId)
        {
            this.Id = id;
            this.NombreUsuario = nombreUsuario;
            this.Legajo = legajo;
            this.Clave = clave;
            this.TipoUsuario = tipoUsuario;
            this.Habilitado = habilitado;
            this.IdPlan = idPlan;
            this.PersonaId = personaId;
        }
    }
}
