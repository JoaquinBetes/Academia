using DB;


public class Program
{
    static void Main(string[] args)
    {
        DateTime fecha = new DateTime(1990, 5, 15);
        Usuario.CreateUsuario("AAAA", "asdasdas", "asdasd",true,39453700,1);
        Console.ReadLine();
    }
}