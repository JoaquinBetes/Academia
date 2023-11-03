using System.ComponentModel.DataAnnotations;

namespace UIWeb.Models
{
    public class Persona
    {
        [Key]
        public int PersonasId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
