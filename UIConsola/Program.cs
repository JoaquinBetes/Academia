using DB;


public class Program
{
    public static List<Entities.Persona>? getDatos(Entities.Usuario usuario)
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
                Console.WriteLine(mod.IdModulo);
            }
        }
        if (mod != null && mod.Consulta)
        {
            Console.WriteLine(mod.Consulta);
            
            if (usuario.TipoUsuario.Equals("Alumno") || usuario.TipoUsuario.Equals("Docente"))
            {
                int personaId = Business.Usuario.getPersonaId(usuario.Legajo);
                Console.WriteLine(personaId);
                personas.Add(DB.Persona.getPersonaById(personaId));
                Console.WriteLine(personas[0].Apellido);
                return personas;
            }
            else return DB.Persona.getDatos();
        }

        return null;
    }
    static void Main(string[] args)
    {
        Entities.ModuloUsuario? mod = null;
        Entities.Usuario usu = Business.Usuario.getUsuario(11111);

        getDatos(usu);
        Console.ReadLine();
        
    }
}