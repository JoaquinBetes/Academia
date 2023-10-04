using DB;


public class Program
{
    static void Main(string[] args)
    {
        List<Entities.Modulo> modulos = Business.Modulo.getModulos();
        foreach (Entities.Modulo modulo in modulos)
        {
            System.Console.WriteLine(modulo.Descripcion);
        }

        Console.ReadLine();
    }
}