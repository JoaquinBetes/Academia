using DB;


public class Program
{
    static void Main(string[] args)
    {
        DateTime fecha = new DateTime(1990, 5, 15);
        Entities.Usuario usuario = new Entities.Usuario();
        usuario.NombreUsuario = "AA";
        usuario.TipoUsuario = "EEE";
        usuario.Legajo = 22;
        usuario.Habilitado = true;
        usuario.Clave = "asd";
        Console.WriteLine(Business.Usuario.LegajoUsuarioExists(12333));
        
        Console.ReadLine();
    }
}