using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Comision : Conector
    {
        #region Getters

        public static List<Entities.Comision> GetAll()
        {
            List<Entities.Comision> comisiones = new List<Entities.Comision>();
            string sqlQuery = "SELECT * FROM Comisiones";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Entities.Comision comision = new Entities.Comision();
                        comision.IdComision = Convert.ToInt32(reader["IdComision"]);
                        comision.Descripcion = reader["Descripcion"].ToString();
                        comision.AnioEspecialidad = Convert.ToInt32(reader["AnioEspecialidad"]);
                        comision.IDPlan = Convert.ToInt32(reader["IDPlan"]);
                        comisiones.Add(comision);
                    }
                    reader.Close();
                    connection.Close();
                    return comisiones;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la lista de comisiones" + ex.Message);
                }
            }
        }

        public static Entities.Comision GetById(int id)
        {
            Entities.Comision comision = new Entities.Comision();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Comisiones WHERE IDComision = @id";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        comision.IdComision = id;
                        comision.Descripcion = reader["Descripcion"].ToString();
                        comision.AnioEspecialidad = Convert.ToInt32(reader["AnioEspecialidad"]);
                        comision.IDPlan = Convert.ToInt32(reader["IDPlan"]);
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
            return comision;
        }

        public static List<Entities.Comision> getByPlan(int idPlan)
        {

            List<Entities.Comision> comisiones = DB.Comision.GetAll();
            var comisionesPlan = comisiones.Where(comision => comision.IDPlan == idPlan).ToList();
            return comisionesPlan;
        }
        #endregion
        #region Create

        public static void CreateComision(string descripcion, int anioEspecialidad, int iDPlan)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Comisiones (Descripcion, AnioEspecialidad, IDPlan) " +
                                           "VALUES (@desc, @anioEsp, @idPlan)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@desc", descripcion);
                        command.Parameters.AddWithValue("@anioEsp", anioEspecialidad);
                        command.Parameters.AddWithValue("@idPlan", iDPlan);

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
        public static void UpdateComision(Entities.Comision comision)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el UPDATE
                    string sqlQuery = "UPDATE Comisiones SET Descripcion = @descripcion, AnioEspecialidad = @anioEspecialidad, IDPlan = @idPlan WHERE IdComision = @id";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@descripcion", comision.Descripcion);
                    command.Parameters.AddWithValue("@anioEspecialidad", comision.AnioEspecialidad);
                    command.Parameters.AddWithValue("@idPlan", comision.IDPlan);
                    command.Parameters.AddWithValue("@id", comision.IdComision);

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

        public static void DeleteComision(int id)
        {
            string sqlQuery = "DELETE FROM Comisiones WHERE IdComision=@id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery(); // ya se ejecuto la consulta 
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la comision" + ex.Message);
                }
            }
        }

        #endregion
    }
}
