using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DB
{
    public class Persona
    {
        public static string connectionString = "Server=.\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;Encrypt=false";
        public static List<Entities.Persona> getDatos()
        {
            List<Entities.Persona> personas = new List<Entities.Persona>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Personas;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // TODO VALIDACIONES del tipo si devuelve null, Nan o algo por es estilo poner "-" o "0"
                    {
                        int personaID = Convert.ToInt32(reader["PersonasId"]);
                        string? nombre = reader["Nombre"].ToString();
                        string? apellido = reader["Apellido"].ToString();
                        int DNI = Convert.ToInt32(reader["DNI"]);
                        string? telefono = reader["Telefono"].ToString();
                        string? direccion = reader["Direccion"].ToString();
                        string? email = reader["Email"].ToString();
                        DateTime fechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                        Entities.Persona persona = new Entities.Persona(personaID, nombre, apellido, DNI, telefono, direccion, email, fechaNacimiento);
                        personas.Add(persona);
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return personas;
        }

        public static void CreatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Personas (DNI, Nombre, Apellido, Telefono, Direccion, Email, FechaNacimiento, IDPlan) " +
                                       "VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Direccion, @Email, @FechaNacimiento, 222)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@DNI", dni);
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellido", apellido);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Direccion", direccion);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimiento);

                        connection.Open();

                        // Ejecutar el INSERT
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar si se insertaron filas correctamente
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Inserción exitosa");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar el registro");
                        }
                        connection.Close();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        public static Entities.Persona getPersona(int dni)
        {
            Entities.Persona persona = new Entities.Persona();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Personas WHERE DNI = @DNI";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@DNI", dni);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                        
                    if (reader.HasRows)
                    {
                        // Si se encontró la persona, aquí puedes mostrar los datos en algún control o realizar alguna acción
                        reader.Read();
                        persona.PersonaId = Convert.ToInt32(reader["PersonasId"]); ;
                        persona.Nombre = reader["Nombre"].ToString();
                        persona.Apellido = reader["Apellido"].ToString();
                        persona.DNI = Convert.ToInt32(reader["DNI"]);
                        persona.Telefono = reader["Telefono"].ToString();
                        persona.Direccion = reader["Direccion"].ToString();
                        persona.Email = reader["Email"].ToString();
                        persona.FechaNacimiento = Convert.ToDateTime(reader["FechaNacimiento"]);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return persona;
        }
    
        public static bool DniExists(int dni)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Comando SQL para el buscar DNI
                    string sqlQuery = "SELECT COUNT(*) FROM Personas WHERE DNI = @DNI";

                    connection.Open();

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@DNI", dni);

                    int count = (int)command.ExecuteScalar();

                    connection.Close();

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

        // Esto es del CodeFirstAPI, ignorarlo, lo dejo por si despues sirve para capa servicios
        /*public static async Task<List<Persona>?> getDatosAsync()
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
        }*/
    }
}