using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace DB
{
    public class Materia : Conector
    {
        #region Getters
        public static List<Entities.Materia> getAll()
        {
            List<Entities.Materia> materias = new List<Entities.Materia>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Materias;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // TODO VALIDACIONES del tipo si devuelve null, Nan o algo por es estilo poner "-" o "0"
                    {
                        int idMateria = Convert.ToInt32(reader["IdMateria"]);
                        string? descripcion = reader["Descripcion"].ToString();
                        int hsSemanales = Convert.ToInt32(reader["HsSemanales"]);
                        int hsTotales = Convert.ToInt32(reader["HsTotales"]);
                        int idPlan = Convert.ToInt32(reader["IDPlan"]);
                        Entities.Materia materia = new Entities.Materia(idMateria, descripcion,hsSemanales,hsTotales, idPlan);
                        materias.Add(materia);
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
            return materias;
        }

        public static Entities.Materia getOne(string desc, int idPlan)
        {
            Entities.Materia? materia = null;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Materias WHERE Descripcion = @desc AND IdPlan = @idPlan";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.Parameters.AddWithValue("@idPlan", idPlan);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        materia = new Entities.Materia    ///VERRRRRR
                        {
                            IdMateria = Convert.ToInt32(reader["IdMateria"]),
                            Descripcion = reader["Descripcion"].ToString(),
                            IdPlan = Convert.ToInt32(reader["IdPlan"]),
                            HsSemanales = Convert.ToInt32(reader["HsSemanales"]),
                            HsTotales = Convert.ToInt32(reader["HsTotales"]),
                      
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
            return materia;
        }

        public static Entities.Materia getById(int id)
        {
            Entities.Materia materia = new Entities.Materia();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Materias WHERE IdMateria = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        materia.IdMateria = id;
                        materia.Descripcion = reader["Descripcion"].ToString();
                        materia.IdPlan = Convert.ToInt32(reader["IdPlan"]);
                        materia.HsSemanales = Convert.ToInt32(reader["HsSemanales"]);
                        materia.HsTotales = Convert.ToInt32(reader["HsTotales"]);
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
            return materia;
        }
        #endregion
        #region Create
        public static void CreateMateria(string descripcion, int idEspecialidad)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Materias (Descripcion, IdEspecialidad) " +
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
        #endregion
        #region Delete
        public static void deleteMateria(int id)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string deleteQuery = "DELETE FROM Materias WHERE IdMateria = @Id";

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