using System.ComponentModel.DataAnnotations;

namespace UIWeb.Models
{
    public class Especialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }
        public string Descripcion { get; set; }

        public Especialidad()
        {
            IdEspecialidad = 0;
            Descripcion = string.Empty;
        }
    }
}
