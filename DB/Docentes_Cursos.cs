using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Docentes_Cursos : Conector
    {
        #region Getters

        public static List<Entities.Docentes_Cursos> GetAll()
        {
            List<Entities.Docentes_Cursos> docentesCursos = new List<Entities.Docentes_Cursos>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Docentes_Cursos;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idDictado = Convert.ToInt32(reader["IdDictado"]);
                        int idCurso = Convert.ToInt32(reader["IdCurso"]);
                        int idDocente = Convert.ToInt32(reader["IdDocente"]);
                        int cargo = Convert.ToInt32(reader["Cargo"]);
                        Entities.Docentes_Cursos docenteCurso = new Entities.Docentes_Cursos(idDictado, idCurso, idDocente, cargo);
                        docentesCursos.Add(docenteCurso);
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
            return docentesCursos;
        }

        #endregion
        #region Create

        public static void CreateInscripcion(int idCurso, int idDocente, int cargo)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Docentes_Cursos (IdCurso, IdDocente, Cargo) " +
                                           "VALUES (@idCurso, @idDocente, @cargo)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@idCurso", idCurso);
                        command.Parameters.AddWithValue("@idDocente", idDocente);
                        command.Parameters.AddWithValue("@cargo", cargo);

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
        #endregion
    }
}
