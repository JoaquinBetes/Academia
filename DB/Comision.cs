using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Comision : Conector
    {
        #region Getters

        public static List<Entities.Comision> GetAll()
        {
            List<Entities.Comision> comisiones = new List<Entities.Comision>();
            string sqlQuery = "SELECT * FROM Comisiones";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Entities.Comision comision = new Entities.Comision();
                        comision.IdComision = Convert.ToInt32(reader["IdComision"]);
                        comision.Descripcion = reader["Descripcion"].ToString();
                        comision.AnioEspecialidad = Convert.ToInt32(reader["AnioEspecialidad"]);
                        comision.IDPlan = Convert.ToInt32(reader["IDPlan"]);
                        comisiones.Add(comision);
                    }
                    reader.Close();
                    connection.Close();
                    return comisiones;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la lista de comisiones" + ex.Message);
                }
            }
        }

        #endregion
        #region Create
        #endregion
        #region Update
        #endregion
        #region Delete

        public static void DeleteComision(int id)
        {
            string sqlQuery = "DELETE FROM Comisiones WHERE IdComision=@id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
                    throw new Exception("Error al eliminar la comision" + ex.Message);
                }
            }
        }

        #endregion
    }
}
