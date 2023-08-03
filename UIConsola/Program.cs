using DB;


public class Program
{
    static void Main(string[] args)
    {
        DateTime fecha = new DateTime(1990, 5, 15);
        Usuario.CreateUsuario("AAAA", 232323, "asdasdas", "asdasd",true);
        Console.ReadLine();
    }
}