using DB;
using Entities;

namespace Business
{
    public class Persona
    {
        #region Geters
        public static List<Entities.Persona>? getDatos( Entities.Usuario usuario)
        {
            List<Entities.Persona> personas = new List<Entities.Persona>();
            Entities.ModuloUsuario? mod = null;
            List<Entities.ModuloUsuario> modulosUsuarios = Business.ModuloUsuario.getModulosUsuario(usuario.Id);
            foreach (Entities.ModuloUsuario moduloUsuario in modulosUsuarios)
            {
                int modId = Business.ModuloUsuario.getModuloId(moduloUsuario.IdModulo);
                Entities.Modulo? modulo = Business.Modulo.getModulo(modId);
                if (modulo != null && modulo.Descripcion.Equals("Personas"))
                {
                    mod = moduloUsuario;
                }
            }
            if (mod != null && mod.Consulta)
            {
                if (usuario.TipoUsuario.Equals("Alumno") || usuario.TipoUsuario.Equals("Docente"))
                {
                   personas.Add(DB.Persona.getPersonaById(Business.Usuario.getPersonaId(usuario.Legajo)));
                    return personas;
                }
                else return DB.Persona.getDatos();
            }
            
            return null; 
        }
        public static Entities.Persona? getPersona(int dni) 
        { 
            if (DB.Persona.getPersona(dni).DNI == 0) return null;
            else return DB.Persona.getPersona(dni);
        }
        public static int getDni(int personaId)
        { return DB.Persona.getDni(personaId); }
        #endregion
        #region Create
        public static void CreatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        { DB.Persona.CreatePersona(dni, nombre, apellido, telefono, direccion, email, fechaNacimiento); }
        #endregion
        #region Update
        public static void UpdatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento, int id)
        { DB.Persona.UpdatePersona(dni, nombre, apellido, telefono, direccion, email, fechaNacimiento, id); }
        #endregion
        #region Delete
        public static void deletePersona(int id)
        {
            List < Entities.Usuario > usuarios = DB.Usuario.getUsuariosPersona(id);
            foreach (Entities.Usuario usuario in usuarios)
            {
                Business.Usuario.deleteUsuario(usuario.Legajo);
            }
            DB.Persona.deletePersona(id); 
        }

        #endregion

        public static bool DniExists(int dni)
        {
            Entities.Persona persona = DB.Persona.getPersona(dni);
            
            return persona.DNI != 0;
        }

    }
}
