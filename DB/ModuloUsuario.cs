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
        public int Id { get; set; }
        //public int IdModulo { get; set; }
        public int IdUsuario { get; set; }

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
                        int idModulo = Convert.ToInt32(reader["Alta"]);
                        bool alta = Convert.ToInt32(reader["Alta"]) != 0;
                        bool baja = Convert.ToInt32(reader["Baja"]) != 0;
                        bool modificacion = Convert.ToInt32(reader["Modificacion"]) != 0;
                        bool consulta = Convert.ToInt32(reader["Consulta"]) != 0;
                        Entities.ModuloUsuario moduloUsuario = new Entities.ModuloUsuario(idModulo, alta, baja, modificacion, consulta);
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
        public static void CreateModulo(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Modulos_Usuarios (IdModuloUsuario, IdModulo, IdUsuario, Alta, Baja, Modificacion, Consulta) " +
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

        #region
        #endregion

        #region
        #endregion

    }
}
