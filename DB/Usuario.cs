using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Entities;
using System.Net;

namespace DB
{
    public class Usuario
    {
        public static string connectionString = "Server=.\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;Encrypt=false";
        public static void CreateUsuario(string nombreUsuario, string clave, string tipo, bool habilitado , int dni, int personaId)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Usuarios (NombreUsuario, Legajo, Clave, TipoUsuario, Habilitado, PersonaId) " +
                                           "VALUES (@NombreUsuario, @Legajo, @Clave, @TipoUsuario, @Habilitado, @PersonaId)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@Legajo", 22);
                        command.Parameters.AddWithValue("@Clave", clave);
                        command.Parameters.AddWithValue("@TipoUsuario", tipo);
                        command.Parameters.AddWithValue("@Habilitado", habilitado);
                        command.Parameters.AddWithValue("@PersonaId", personaId);

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

        public static Entities.Usuario GetUsuario(string nombreUsuario) 
        {
            Entities.Usuario usuario = new Entities.Usuario();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Usuarios WHERE NombreUsuario = @nombreUsuario";

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.Read()) 
                    {
                        usuario.UsuarioId = Convert.ToInt32(reader["UsuarioId"]);
                        usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.Legajo = Convert.ToInt32(reader["Legajo"]);
                        usuario.Clave = reader["Clave"].ToString();
                        usuario.TipoUsuario = reader["TipoUsuario"].ToString();
                        usuario.Habilitado = (bool)reader["Habilitado"];
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return usuario;
        }
    }

}
