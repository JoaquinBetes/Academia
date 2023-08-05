using DB;
using Entities;

namespace Business
{
    public class Persona
    {
        public static List<Entities.Persona> getDatos()
        {
            return DB.Persona.getDatos();
        }

        public static void CreatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            DB.Persona persona_datos = new DB.Persona();
            Entities.Persona persona_entidad = new Entities.Persona();
            persona_entidad.DNI = dni;
            persona_entidad.Nombre = nombre;
            persona_entidad.Apellido = apellido;
            persona_entidad.Telefono = telefono;
            persona_entidad.Direccion = direccion;
            persona_entidad.Email = email;
            persona_entidad.FechaNacimiento = fechaNacimiento;
            return persona_datos.CreatePersona();
        }
    }
}