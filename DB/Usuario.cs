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
    public class Usuario:Conector
    {
        #region Geters
        public static List<Entities.Usuario> getDatos()
        {
            List<Entities.Usuario> usuarios = new List<Entities.Usuario>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Usuarios;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // TODO VALIDACIONES del tipo si devuelve null, Nan o algo por es estilo poner "-" o "0"
                    {
                        object planIdValue = reader["PlanId"];
                        int IdPlan = planIdValue == DBNull.Value ? 0 : Convert.ToInt32(planIdValue);
                        int Id = Convert.ToInt32(reader["UsuarioId"]);
                        int Legajo = Convert.ToInt32(reader["Legajo"]);
                        string? nombreUsuario = reader["NombreUsuario"].ToString();
                        string? clave = reader["Clave"].ToString();
                        string? tipoUsuario = reader["TipoUsuario"].ToString();
                        bool habilitado = (bool)reader["Habilitado"];
                        Entities.Usuario usuario = new Entities.Usuario(Id, nombreUsuario, Legajo, clave, tipoUsuario, habilitado, IdPlan);
                        usuarios.Add(usuario);
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
            return usuarios;
        }
        public static int getUsuarioId(int legajo)
        {
            int id = 0;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Usuarios WHERE Legajo = @legajo";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@legajo", legajo);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        id = Convert.ToInt32(reader["UsuarioId"]);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return id;
        }
        public static int getPersonaId(int legajo)
        {
            int id = 0;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Usuarios WHERE Legajo = @legajo";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@legajo", legajo);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        id = Convert.ToInt32(reader["PersonaId"]);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return id;
        }
        public static Entities.Usuario getUsuario(int legajo) { 
            Entities.Usuario usuario = new Entities.Usuario();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Usuarios WHERE Legajo = @legajo";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@legajo", legajo);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Si se encontró la persona, aquí puedes mostrar los datos en algún control o realizar alguna acción
                        reader.Read();
                        usuario.Id = Convert.ToInt32(reader["UsuarioId"]);
                        usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.Legajo = Convert.ToInt32(reader["Legajo"]);
                        usuario.Clave = reader["Clave"].ToString();
                        usuario.TipoUsuario = reader["TipoUsuario"].ToString();
                        usuario.Habilitado = (Convert.ToInt32(reader["Habilitado"]) != 0);
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
        public static Entities.Usuario getUsuario(string nombreUsuario) 
        {
            Entities.Usuario usuario = new Entities.Usuario();
            string sqlQuery = "SELECT * FROM Usuarios WHERE NombreUsuario = @nombreUsuario";
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT

                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    
                    if (reader.Read()) 
                    {
                        usuario.Id = Convert.ToInt32(reader["UsuarioId"]);
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
        public static List<Entities.Usuario> getUsuariosPersona(int personaId)
        {
            List<Entities.Usuario> usuarios = new List<Entities.Usuario>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Usuarios WHERE PersonaId = @personaId;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@personaId", personaId);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // TODO VALIDACIONES del tipo si devuelve null, Nan o algo por es estilo poner "-" o "0"
                    {
                        object planIdValue = reader["PlanId"];
                        int IdPlan = planIdValue == DBNull.Value ? 0 : Convert.ToInt32(planIdValue);
                        int Id = Convert.ToInt32(reader["PersonaId"]);
                        string? nombre = reader["NombreUsuario"].ToString();
                        int legajo = Convert.ToInt32(reader["Legajo"]);
                        string? clave = reader["Clave"].ToString();
                        string? tipo = reader["TipoUsuario"].ToString();
                        bool habilitado = Convert.ToInt32(reader["Habilitado"]) != 0;
                        Entities.Usuario usuario = new Entities.Usuario(Id, nombre, legajo, clave, tipo, habilitado, IdPlan);
                        usuarios.Add(usuario);
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
            return usuarios;
        }
        #endregion
        #region Create
        public static void CreateUsuario(string nombreUsuario, string clave, string tipo, bool habilitado, int dni, int personaId, int legajo, int planId)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Usuarios (NombreUsuario, Legajo, Clave, TipoUsuario, Habilitado, PersonaId, PlanId) " +
                                           "VALUES (@NombreUsuario, @Legajo, @Clave, @TipoUsuario, @Habilitado, @PersonaId, @PlanId)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        command.Parameters.AddWithValue("@Legajo", legajo);
                        command.Parameters.AddWithValue("@Clave", clave);
                        command.Parameters.AddWithValue("@TipoUsuario", tipo);
                        command.Parameters.AddWithValue("@Habilitado", habilitado);
                        command.Parameters.AddWithValue("@PersonaId", personaId);
                        command.Parameters.AddWithValue("@PlanId", planId);

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
        public static void UpdateUsuario(Entities.Usuario usuario)
        {
            int id = Usuario.getUsuarioId(usuario.Legajo);
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string updateQuery = @"
                        UPDATE Usuarios
                        SET 
                            NombreUsuario = @nombre,
                            Legajo = @legajo,
                            Clave = @clave,
                            TipoUsuario = @tipo,
                            Habilitado = @habilitado,
                            PlanId = @planId
                        WHERE UsuarioId = @id";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@nombre", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("@legajo", usuario.Legajo);
                    command.Parameters.AddWithValue("@clave", usuario.Clave);
                    command.Parameters.AddWithValue("@tipo", usuario.TipoUsuario);
                    command.Parameters.AddWithValue("@habilitado", usuario.Habilitado);
                    command.Parameters.AddWithValue("@planId", usuario.IdPlan);
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
        public static void deleteUsuario(int legajo)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string deleteQuery = "DELETE FROM Usuarios WHERE Legajo = @legajo";

                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@legajo", legajo);

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
        public static int CountUsuarios(int personaId)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Usuarios WHERE PersonaId = @personaId";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@personaId", personaId);
                    int count = (int)command.ExecuteScalar();
                    return count;
                }
            }     
        }
    }
}

#region Geters

#endregion
#region Create

#endregion
#region Update

#endregion
#region Delete

#endregion