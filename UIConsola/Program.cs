using DB;


public class Program
{
    static void Main(string[] args)
    {
        List<Entities.Usuario> usuarios = Business.Usuario.getDatos();
        foreach (Entities.Usuario usuario in usuarios)
        {
            System.Console.WriteLine(usuario.TipoUsuario);
        }

        Console.ReadLine();
    }
}