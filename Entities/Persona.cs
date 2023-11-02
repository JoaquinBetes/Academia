namespace Entities
{
    public class Persona
    {
        public int PersonaId { get; set; }
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Persona()
        {
            PersonaId = 0;
            Nombre = "-";
            Apellido = "-";
            DNI = 0;
            Telefono = "-";
            Direccion = "-";
            Email = "-";
            FechaNacimiento = DateTime.MinValue;
            IdPlan = 0;
        }

        public Persona(int personaId, string nombre, string apellido, int dni, string telefono, string direccion, string email, DateTime fechaNacimiento, int idPlan)
        {
            PersonaId = personaId;
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            FechaNacimiento = fechaNacimiento;
            IdPlan = idPlan;
        }
    }
}