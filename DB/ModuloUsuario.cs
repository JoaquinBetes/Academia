using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class ModuloUsuario : Conector
    {
        #region Geters
        public static List<Entities.ModuloUsuario> getModulosUsuario(int idUsuario)
        {
            List<Entities.ModuloUsuario> modulosUsuario = new List<Entities.ModuloUsuario>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlQuery = "SELECT * FROM Modulos_Usuarios WHERE IdUsuario = @idUsuario";
                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    
                    while ( reader.Read() )
                    {
                        int idModuloUsuario = Convert.ToInt32(reader["IdModuloUsuario"]);
                        bool alta = Convert.ToInt32(reader["Alta"]) != 0;
                        bool baja = Convert.ToInt32(reader["Baja"]) != 0;
                        bool modificacion = Convert.ToInt32(reader["Modificacion"]) != 0;
                        bool consulta = Convert.ToInt32(reader["Consulta"]) != 0;
                        Entities.ModuloUsuario moduloUsuario = new Entities.ModuloUsuario(idModuloUsuario, alta, baja, modificacion, consulta);
                        modulosUsuario.Add(moduloUsuario);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return modulosUsuario;
        }

        #endregion

        #region Create
        public static void CreateModuloUsuario( int IdModulo, int IdUsuario,  bool Alta, bool Baja, bool Modificacion, bool Consulta)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Modulos_Usuarios ( IdModulo, IdUsuario, Alta, Baja, Modificacion, Consulta) " +
                                       "VALUES ( @IdModulo, @IdUsuario, @Alta, @Baja, @Modificacion, @Consulta)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@IdModulo", IdModulo);
                        command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
                        command.Parameters.AddWithValue("@Alta", Alta);
                        command.Parameters.AddWithValue("@Baja", Baja);
                        command.Parameters.AddWithValue("@Modificacion", Modificacion);
                        command.Parameters.AddWithValue("@Consulta", Consulta);

                        connection.Open();

                        // Ejecutar el INSERT
                        int rowsAffected = command.ExecuteNonQuery();
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

        public static void UpdateModuloUsuario(int moduloUsuarioId, bool alta, bool baja, bool modificacion, bool consulta)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string updateQuery = @"
                        UPDATE Modulos_Usuarios 
                        SET Alta = @alta,
                            Baja = @baja,
                            Modificacion = @modificacion,
                            Consulta = @consulta,
                        WHERE IdModuloUsuario = @moduloUsuarioId";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@alta", alta);
                    command.Parameters.AddWithValue("@baja", baja);
                    command.Parameters.AddWithValue("@modificacion", modificacion);
                    command.Parameters.AddWithValue("@consulta", consulta);
                    command.Parameters.AddWithValue("@moduloUsuarioId", moduloUsuarioId);

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
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        #endregion

        #region Delete
        #endregion

    }
}
