using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Entities;
using System.Net;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DB
{
    public class Especialidad
    {
        public static string connectionString = "Server=.\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;Encrypt=false";
        //[key]
        //[databasegenerated(databasegeneratedoption.identity)]
        //public int idespecialidad { get; set; }
        //public string descripcion { get; set; }
        public static List<Entities.Especialidad> Get()
        {
            List<Entities.Especialidad> especialidades = new List<Entities.Especialidad>();
            string sqlQuery = "SELECT * FROM Especialidades";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(); // ya se ejecuto la consulta 
                    while (reader.Read())
                    {

                        Entities.Especialidad esp = new Entities.Especialidad();
                        esp.IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]);
                        esp.Descripcion = reader["Descripcion"].ToString();
                        especialidades.Add(esp);
                    }
                   
                    reader.Close();
                    connection.Close();
                    return especialidades;

                }
                catch (Exception ex)
                {

                    throw new Exception("Error al cargar la lista de especialidades" + ex.Message);
                }

            }

           
        }
        public static Entities.Especialidad Get(int id)
        {
            
            string sqlQuery = "SELECT * FROM Especialidades where idEspecialidad=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", id); 
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader(); // ya se ejecuto la consulta 
                    reader.Read();
                   
                    Entities.Especialidad esp = new Entities.Especialidad();
                    esp.IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]);
                    esp.Descripcion = reader["Descripcion"].ToString();
                  
                   

                    reader.Close();
                    connection.Close();
                    return esp;

                }
                catch (Exception ex)
                {

                    throw new Exception("Error al cargar la lista de especialidades" + ex.Message);
                }

            }

            
        }
        public static void Add(string desc)
        {
            string sqlQuery = "insert into Especialidades(Descripcion) values (@Descripcion)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@Descripcion", desc);
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
        public static void Update(int id,string desc)
        {
            string sqlQuery = "update Especialidades set descripcion=@Descripcion where idEspecialidad=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@Descripcion", desc);
                command.Parameters.AddWithValue("@id", id);
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
        public static void Delete(int id)
        {
            string sqlQuery = "delete from Especialidades where idEspecialidad=@id";
            using (SqlConnection connection = new SqlConnection(connectionString))
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

                    throw new Exception("Error al agregar el usuario" + ex.Message);
                }

            }

        }
    }
}
