namespace UIWeb.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public int Legajo { get; set; }
        public string Clave { get; set; }
        public string TipoUsuario { get; set; }
        public bool Habilitado { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public Usuario()
        {
            UsuarioId = 0;
            NombreUsuario = string.Empty;
            Legajo = 0;
            Clave = string.Empty;
            TipoUsuario = string.Empty;
            Habilitado = false;
        }
        public Usuario(int id, string nombreUsuario, int legajo, string clave, string tipoUsuario, bool habilitado, int personaId)
        {
            this.UsuarioId = id;
            this.NombreUsuario = nombreUsuario;
            this.Legajo = legajo;
            this.Clave = clave;
            this.TipoUsuario = tipoUsuario;
            this.Habilitado = habilitado;
            this.PersonaId = personaId;
        }
    }
}
