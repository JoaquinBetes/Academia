using Microsoft.Data.SqlClient;


namespace DB
{
    public class Especialidad:Conector
    {
        #region Geters
        public static List<Entities.Especialidad> Get()
        {
            List<Entities.Especialidad> especialidades = new List<Entities.Especialidad>();
            string sqlQuery = "SELECT * FROM Especialidades";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
            Entities.Especialidad esp = new Entities.Especialidad();
            string sqlQuery = "SELECT * FROM Especialidades where idEspecialidad=@id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@id", id);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        esp.IdEspecialidad = Convert.ToInt32(reader["IdEspecialidad"]);
                        esp.Descripcion = reader["Descripcion"].ToString();
                    }

                    reader.Close();
                    connection.Close();
                    return esp;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al cargar la lista de especialidades: " + ex.Message);
                }
            }
        }
        #endregion
        #region Create
        public static void Add(string desc)
        {
            string sqlQuery = "insert into Especialidades(Descripcion) values (@Descripcion)";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        #endregion
        #region Update
        public static void Update(int id, string desc)
        {
            string sqlQuery = "update Especialidades set descripcion=@Descripcion where idEspecialidad=@id";
            using (SqlConnection connection = new SqlConnection(ConnectionString))
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
        #endregion
        #region Delete
        public static void Delete(int id)
        {
            string sqlQuery = "delete from Especialidades where idEspecialidad=@id";
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
                    throw new Exception("Error al eliminar la especialidad" + ex.Message);
                }
            }
        }
        #endregion

    }
}
