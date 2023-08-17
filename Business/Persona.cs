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

        public static bool DniExists(int dni)
        {
            Entities.Persona persona = DB.Persona.getPersona(dni);
            
            return persona !=null;
        }

    }
}