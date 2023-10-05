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
    public class Curso : Conector
    {
        #region Getters
        public static List<Entities.Curso> getAll()
        {
            List<Entities.Curso> cursos = new List<Entities.Curso>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Cursos;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) // TODO VALIDACIONES del tipo si devuelve null, Nan o algo por es estilo poner "-" o "0"
                    {
                        int idCurso = Convert.ToInt32(reader["IdCurso"]);
                        int idMateria = Convert.ToInt32(reader["IdMateria"]);
                        int idComision = Convert.ToInt32(reader["IdComision"]);
                        int anioCalendario = Convert.ToInt32(reader["AnioCalendario"]);
                        int cupo = Convert.ToInt32(reader["Cupo"]);

                        Entities.Curso curso = new Entities.Curso(idCurso, idMateria, idComision, anioCalendario, cupo);
                        cursos.Add(curso);
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
            return cursos;
        }

        public static Entities.Curso getOne(int idCurso)
        {
            Entities.Curso curso = null;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Cursos WHERE IdCurso = @idCurso";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@idCurso", idCurso);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        curso = new Entities.Curso
                        {
                            IdCurso = idCurso,
                            IdMateria = Convert.ToInt32(reader["IdMateria"]),
                            IdComision = Convert.ToInt32(reader["IdComision"]),
                            AnioCalendario = Convert.ToInt32(reader["AnioCalendario"]),
                            Cupo = Convert.ToInt32(reader["Cupo"])
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
            return curso;
        }
        public static int GetPlanId(int idCurso)
        {
            int planId = 0;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para la consulta
                    string sqlQuery = "SELECT IdMateria FROM Cursos WHERE IdCurso = @idCurso";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@idCurso", idCurso);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        planId = Convert.ToInt32(reader["IdMateria"]);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return planId;
        }
        public static Entities.Curso GetCursoByData(int idMateria, int idComision, int anioCalendario, int cupo)
        {
            Entities.Curso curso = null;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Cursos WHERE IdMateria = @idMateria AND IdComision = @idComision AND AnioCalendario = @anioCalendario AND Cupo = @cupo";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@idMateria", idMateria);
                    command.Parameters.AddWithValue("@idComision", idComision);
                    command.Parameters.AddWithValue("@anioCalendario", anioCalendario);
                    command.Parameters.AddWithValue("@cupo", cupo);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        curso = new Entities.Curso
                        {
                            IdCurso = Convert.ToInt32(reader["IdCurso"]),
                            IdMateria = idMateria,
                            IdComision = idComision,
                            AnioCalendario = anioCalendario,
                            Cupo = cupo
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
            return curso;
        }
        #endregion

        #region Create
        public static void CreateCurso(int idMateria, int idComision, int anioCalendario, int cupo)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Cursos (IdMateria, IdComision, AnioCalendario, Cupo) " +
                                       "VALUES (@idMateria, @idComision, @anioCalendario, @cupo)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@idMateria", idMateria);
                        command.Parameters.AddWithValue("@idComision", idComision);
                        command.Parameters.AddWithValue("@anioCalendario", anioCalendario);
                        command.Parameters.AddWithValue("@cupo", cupo);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al agregar el curso" + ex.Message);
                        }
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
        public static void UpdateCurso(Entities.Curso curso)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el UPDATE
                    string sqlQuery = "UPDATE Cursos SET IdMateria = @idMateria, IdComision = @idComision, AnioCalendario = @anioCalendario, Cupo = @cupo WHERE IdCurso = @idCurso";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@idMateria", curso.IdMateria);
                    command.Parameters.AddWithValue("@idComision", curso.IdComision);
                    command.Parameters.AddWithValue("@anioCalendario", curso.AnioCalendario);
                    command.Parameters.AddWithValue("@cupo", curso.Cupo);
                    command.Parameters.AddWithValue("@idCurso", curso.IdCurso);

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
        public static void deleteCurso(int idCurso)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    string deleteQuery = "DELETE FROM Cursos WHERE IdCurso = @IdCurso";

                    connection.Open();
                    try
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@IdCurso", idCurso);

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