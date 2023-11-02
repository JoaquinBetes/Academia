using DB;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Comision : Conector
    {
        #region Getters

        public static List<Entities.Comision> GetAll()
        { return DB.Comision.GetAll(); }

        public static Entities.Comision GetById(int id) 
        { return DB.Comision.GetById(id); }

        public static List<Entities.Comision> getByPlan(int idPlan)
        { return DB.Comision.getByPlan(idPlan); }
        #endregion
        #region Create
        public static void CreateComision(string descripcion, int anioEspecialidad, int idPlan)
        { DB.Comision.CreateComision(descripcion, anioEspecialidad, idPlan); }
        #endregion
        #region Update
        public static void UpdateComision(Entities.Comision comision)
        { DB.Comision.UpdateComision(comision); }
        #endregion
            #region Delete

            public static void DeleteComision(int id)
        { DB.Comision.DeleteComision(id); }

        #endregion
    }
}
