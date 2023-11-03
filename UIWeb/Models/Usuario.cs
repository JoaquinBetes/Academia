using System.ComponentModel.DataAnnotations;

namespace UIWeb.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "El campo Nombre de Usuario es obligatorio.")]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El campo Legajo es obligatorio.")]
        [RegularExpression(@"^\d{5}$", ErrorMessage = "El Legajo debe ser un número válido de 5 dígitos.")]
        public int Legajo { get; set; }

        [Required(ErrorMessage = "El campo Clave es obligatorio.")]
        [MinLength(5, ErrorMessage = "La Clave debe tener al menos 6 caracteres.")]
        public string Clave { get; set; }

        [Required(ErrorMessage = "El campo Tipo de Usuario es obligatorio.")]
        public string TipoUsuario { get; set; }
        public bool Habilitado { get; set; }
        public int PersonaId { get; set; }
        public int PlanId { get; set; }

    }
}
