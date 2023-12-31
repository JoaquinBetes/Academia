﻿using Entities;
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
        public static int getMateriaId(int idMateria)
        {
            int id = 0;
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para la consulta
                    string sqlQuery = "SELECT * FROM Materias WHERE IdMateria = @idMateria";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@idMateria", idMateria);

                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        id = Convert.ToInt32(reader["MateriaId"]);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                // Manejar errores si ocurre alguno al intentar conectarse a la base de datos.
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
            }
            return id;
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

        public static List<Entities.Materia> getByPlan(int idPlan)
        {

            List<Entities.Materia> materias = DB.Materia.getAll();
            var materiasPlan = materias.Where(materia => materia.IdPlan == idPlan).ToList();
            return materiasPlan;
        }

        public static List<Entities.Comision> getComisionesPorMateria(int idMateria)
        {
            List<Entities.Comision> comisiones = new List<Entities.Comision>();
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM Comisiones INNER JOIN Cursos ON Comisiones.IdComision = Cursos.IdComision WHERE Cursos.IdMateria = @idMateria;";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@idMateria", idMateria);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int idComision = Convert.ToInt32(reader["idComision"]);
                        string? descripcion = reader["Descripcion"].ToString();
                        int anioEspecialidad = Convert.ToInt32(reader["AnioEspecialidad"]);
                        int idPlan = Convert.ToInt32(reader["IDPlan"]);
                        Entities.Comision comision = new Entities.Comision(idComision, descripcion, anioEspecialidad, idPlan);
                        comisiones.Add(comision);
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
            return comisiones;
        }
        #endregion
        #region Create
        public static void CreateMateria(string descripcion, int hsSemanales, int hsTotales, int idP)
        {
            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el INSERT
                    string sqlInsert = "INSERT INTO Materias (Descripcion, HsSemanales, HsTotales ,IdPlan) " +
                                           "VALUES (@desc, @ht, @hs, @idP)";

                    // Crear el SqlCommand con el comando y la conexión
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        // Agregar parámetros al comando
                        command.Parameters.AddWithValue("@desc", descripcion);
                        command.Parameters.AddWithValue("@ht", hsSemanales);    
                        command.Parameters.AddWithValue("@hs", hsTotales);  
                        command.Parameters.AddWithValue("@idP", idP);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery(); // ya se ejecuto la consulta 
                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al agregar el usuario" + ex.Message);
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
        public static void UpdateMateria(Entities.Materia materia)
        {
            

            try
            {
                // Crear la SqlConnection
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Comando SQL para el UPDATE
                    string sqlQuery = "UPDATE Materias SET Descripcion = @descripcion, HsSemanales = @hsSemanales, HsTotales = @hsTotales, IdPlan = @idPlan WHERE IdMateria = @id";

                    // Crear el SqlCommand con el comando y la conexión
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@descripcion", materia.Descripcion);
                    command.Parameters.AddWithValue("@hsSemanales", materia.HsSemanales);
                    command.Parameters.AddWithValue("@hsTotales", materia.HsTotales);
                    command.Parameters.AddWithValue("@idPlan", materia.IdPlan);
                    command.Parameters.AddWithValue("@id",materia.IdMateria);

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