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

namespace DB
{
    public class Especialidad
    {
        private string connectionString = "Server=.\\\\SQLEXPRESS;Database=Academia;Trusted_Connection=True;Encrypt=false\"";
        //[key]
        //[databasegenerated(databasegeneratedoption.identity)]
        //public int idespecialidad { get; set; }
        //public string descripcion { get; set; }
        public static  List<Entities.Especialidad> Get()
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
                        esp.Descripcion = reader["Discripcion"].ToString();
                        especialidades.Add(esp);
                    }
                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {

                    throw new Exception("Error al cargar la lista de especialidades");
                }

            }

            return especialidades;
        }
    }
}
