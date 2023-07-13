using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Usuarioid { get; set; }
        public string NombreUsuario { get; set; }
        public int Legajo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public bool Habilitado { get; set; }
        public int PersonaId { get; set; }
        [ForeignKey(nameof(PersonaId))]
        public virtual Persona Persona { get; set; }
    }
}
