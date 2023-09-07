using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Plan
    {
        #region Getters
        public static List<Entities.Plan> getAll()
        { return DB.Plan.getAll(); }
        public static Entities.Plan getOne(string desc, int idEsp) 
        { return DB.Plan.getOne(desc, idEsp); }
        #endregion
        #region Create
        public static void createPlan(string descripcion, int idEspecialidad)
        {
            DB.Plan.CreatePlan(descripcion, idEspecialidad);
        }
        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion

        public static bool PlanExists(string desc, int idEsp)
        {
            Entities.Plan plan = DB.Plan.getOne(desc,idEsp);
            return plan != null;
        }
    }
}
