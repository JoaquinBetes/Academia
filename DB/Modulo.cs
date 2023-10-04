using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Modulo : Conector
    {
        public static Entities.Modulo getModulo(int idModulo)
        {
            Entities.Modulo modulo = new Entities.Modulo();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Modulos WHERE IdModulo = @idModulo";
                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@idModulo", idModulo);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        modulo.Descripcion = reader["Descripcion"].ToString();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return modulo;
        }
        public static List<Entities.Modulo> getModulos()
        {
            List <Entities.Modulo> modulos = new List<Entities.Modulo>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string sqlQuery = "SELECT * FROM Modulos";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["IdModulo"]);
                        string descripcion = reader["Descripcion"].ToString();
                        Entities.Modulo modulo = new Entities.Modulo(id, descripcion);
                        modulos.Add(modulo);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return modulos;
        }
    }
}
