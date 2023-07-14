using Azure;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaId { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IDPlan { get; set; }


        public static async Task<List<Persona>?> getDatosAsync()
        {
            // Realizar la solicitud HTTP a la API
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync("http://localhost:5000/api/Persona");
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();

                    List<Persona>? personas = JsonConvert.DeserializeObject<List<Persona>>(responseBody);
                    return personas;
                }
                catch (HttpRequestException ex)
                {
                    Console.WriteLine($"Error al realizar la solicitud HTTP: {ex.Message}");
                    return null;
                }
            }
        }

        public static void CreatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento, int idPlan) {
            // Crear una instancia de HttpClient
            using (HttpClient httpClient = new HttpClient())
            {
                // URL del endpoint del controlador Persona
                string url = "http://localhost:5000/api/Persona";

                // Crear una nueva instancia de Persona con los datos
                Persona nuevaPersona = new Persona();
                nuevaPersona.PersonaId = 0;
                nuevaPersona.DNI = dni;
                nuevaPersona.Nombre = nombre;
                nuevaPersona.Apellido = apellido;
                nuevaPersona.Direccion = direccion;
                nuevaPersona.Email = email;
                nuevaPersona.Telefono = telefono;
                nuevaPersona.FechaNacimiento = fechaNacimiento;
                nuevaPersona.IDPlan = idPlan;
                
                // Serializar la persona en formato JSON
                string jsonPersona = JsonConvert.SerializeObject(nuevaPersona);

                // Configurar el encabezado y el contenido de la solicitud
                StringContent content = new StringContent(jsonPersona, Encoding.UTF8, "application/json");

                // Realizar la solicitud HTTP POST
                HttpResponseMessage response = httpClient.PostAsync(url, content).Result;

                // Verificar el estado de la respuesta
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("La persona se ha insertado correctamente.");
                }
                else
                {
                    Console.WriteLine("Error al insertar la persona: " + response.StatusCode);
                }
            }
        }
    }
}