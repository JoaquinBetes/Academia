using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Plan : Conector
    {
        #region Getters
        public static List<Entities.Plan> getAll() 
        {
            List<Entities.Plan> planes = new List<Entities.Plan>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Planes;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // TODO VALIDACIONES del tipo si devuelve null, Nan o algo por es estilo poner "-" o "0"
                    {
                        int idPlan = Convert.ToInt32(reader["IDPlan"]);
                        string? descripcion = reader["Descripcion"].ToString();
                        int idEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]);
                        Entities.Plan plan = new Entities.Plan(idPlan, descripcion, idEspecialidad);
                        planes.Add(plan);
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
            return planes;
        }

        public static Entities.Plan getOne(string desc, int idEsp)
        {
            Entities.Plan? plan = null;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Planes WHERE Descripcion = @desc AND IdEspecialidad = @idEsp";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.Parameters.AddWithValue("@idEsp", idEsp);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        plan = new Entities.Plan
                        {
                            IdPlan = Convert.ToInt32(reader["IDPlan"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"])
                        };
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
            return plan;
        }

        public static Entities.Plan getById(int id)
        {
            Entities.Plan plan = new Entities.Plan();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Planes WHERE IDPlan = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        plan.IdPlan = id;
                        plan.Descripcion = reader["Descripcion"].ToString();
                        plan.IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]);
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
            return plan;
        }

        public static List<Entities.Plan> getByEspecialidad(int idEspecialidad) 
        { 
            List<Entities.Plan> planes = DB.Plan.getAll();
            var planesEspecialidad = planes.Where(plan => plan.IdEspecialidad == idEspecialidad).ToList();
            return planesEspecialidad;
        }

        #endregion
        #region Create
        public static void CreatePlan(string descripcion, int idEspecialidad)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Planes (Descripcion, IdEspecialidad) " +
                                           "VALUES (@desc, @idEsp)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@desc", descripcion);
                        command.Parameters.AddWithValue("@idEsp", idEspecialidad);

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
        public static void UpdatePlan(Entities.Plan plan)
        {

            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el UPDATE
                    string sqlQuery = "UPDATE Planes SET Descripcion = @descripcion, IdEspecialidad = @idEspecialidad WHERE IDPlan = @id";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@descripcion", plan.Descripcion);
                    command.Parameters.AddWithValue("@idEspecialidad", plan.IdEspecialidad);
                    command.Parameters.AddWithValue("@id", plan.IdPlan);

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
        public static void deletePlan(int id)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string deleteQuery = "DELETE FROM Planes WHERE IDPlan = @Id";

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
