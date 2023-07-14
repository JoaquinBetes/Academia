using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

public class Program
{
    static async Task Main(string[] args)
    {
        using (HttpClient httpClient = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("http://localhost:5000/api/Especialidad");
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                List<Especialidad>? especialidades = JsonConvert.DeserializeObject<List<Especialidad>>(responseBody);
                var personas = await Persona.getDatosAsync();
                
                
                foreach (Persona persona in personas)
                {
                    Console.WriteLine($"Nombre: {persona.Nombre}, F.Nacimiento: {persona.FechaNacimiento}");
                }
                DateTime specificDate = new DateTime(2022, 1, 1);
                Persona.CreatePersona(333333, "Max", "Demian", "384726666", "lavalle 666", "maxdem@gmail.com", specificDate, 22);
                foreach (Especialidad especialidad in especialidades)
                {
                    Console.WriteLine($"Id: {especialidad.IdEspecialidad}, Descripcion: {especialidad.Descripcion}");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Error al realizar la solicitud HTTP: {ex.Message}");
            }
        }
    }
}