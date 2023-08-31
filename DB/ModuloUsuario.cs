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
        public int IdModulo { get; set; }
        public int IdUsuario { get; set; }


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
    }
}
