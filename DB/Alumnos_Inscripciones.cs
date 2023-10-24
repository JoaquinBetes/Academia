using Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Alumnos_Inscripciones : Conector
    {
        #region Getters

        public static List<Entities.Alumnos_Inscripciones> GetAll()
        {
            List<Entities.Alumnos_Inscripciones> alumnoInscripciones = new List<Entities.Alumnos_Inscripciones>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Alumnos_Inscripciones;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idInscripcion = Convert.ToInt32(reader["IdInscripcion"]);
                        int idAlumno = Convert.ToInt32(reader["IdAlumno"]);
                        int idCurso = Convert.ToInt32(reader["IdCurso"]);
                        string condicion = reader["Condicion"].ToString();
                        int nota = Convert.ToInt32(reader["Nota"]);
                        Entities.Alumnos_Inscripciones AlumnoInscripcion = new Entities.Alumnos_Inscripciones(idInscripcion, idAlumno, idCurso, condicion, nota);
                        alumnoInscripciones.Add(AlumnoInscripcion);
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
            return alumnoInscripciones;
        }

        public static List<Entities.Alumnos_Inscripciones> GetAllByCurso(int idCurso)
        {
            List<Entities.Alumnos_Inscripciones> alumnoInscripciones = new List<Entities.Alumnos_Inscripciones>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Alumnos_Inscripciones WHERE IdCurso = @idCurso;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@idCurso", idCurso);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idInscripcion = Convert.ToInt32(reader["IdInscripcion"]);
                        int idAlumno = Convert.ToInt32(reader["IdAlumno"]);
                        string condicion = reader["Condicion"].ToString();
                        int nota = Convert.ToInt32(reader["Nota"]);
                        Entities.Alumnos_Inscripciones AlumnoInscripcion = new Entities.Alumnos_Inscripciones(idInscripcion, idAlumno, idCurso, condicion, nota);
                        alumnoInscripciones.Add(AlumnoInscripcion);
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
            return alumnoInscripciones;
        }

        #endregion
        #region Create

        public static void CreateInscripcion(int idAlumno, int idCurso, string condicion, int nota)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Alumnos_Inscripciones (IdAlumno, IdCurso, Condicion, Nota) " +
                                           "VALUES (@idAlumno, @idCurso, @condicion, @nota)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@idAlumno", idAlumno);
                        command.Parameters.AddWithValue("@idCurso", idCurso);
                        command.Parameters.AddWithValue("@condicion", condicion);
                        command.Parameters.AddWithValue("@nota", nota);

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
