using Entities;
using Microsoft.Data.SqlClient;
using System.Net;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DB
{
    public class Persona : Conector
    {
        #region Geters
        public static List<Entities.Persona> getDatos()
        {
            List<Entities.Persona> personas = new List<Entities.Persona>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        public static Entities.Persona getPersonaById(int id)
        {
            Entities.Persona persona = new Entities.Persona();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Personas WHERE PersonasId = @id";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@id", id);

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
        public static Entities.Persona getPersona(int dni)
        {
            Entities.Persona persona = new Entities.Persona();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        public static int getDni(int personaId)
        {
            int dni = 0;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT DNI FROM Personas WHERE PersonasId = @personaId";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@personaId", personaId);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Si se encontró la persona, aquí puedes mostrar los datos en algún control o realizar alguna acción
                        reader.Read();
                        dni = Convert.ToInt32(reader["DNI"]); ;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return dni;
        }
        #endregion
        #region Create
        public static void CreatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        #endregion
        #region Update
        public static void UpdatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento, int id)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string updateQuery = @"
                        UPDATE Personas
                        SET DNI = @dni,
                            Nombre = @nombre,
                            Apellido = @apellido,
                            Telefono = @telefono,
                            Direccion = @direccion,
                            Email = @email,
                            FechaNacimiento = @fechaNacimiento
                        WHERE PersonasId = @id";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al actualizar la base de datos: " + ex.Message);
                    }
                    finally
                    {
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
        #endregion
        #region Delete
        public static void deletePersona(int id)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string deleteQuery = "DELETE FROM Personas WHERE PersonasId = @Id";

                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Id", id);

                            int rowsAffected = command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error al actualizar la base de datos: " + ex.Message);
                    }
                    finally
                    {
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
        #endregion
    }
}