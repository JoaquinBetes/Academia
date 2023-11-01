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
        public static Entities.Plan getById(int id)
        { return DB.Plan.getById(id); }
        public static List<Entities.Plan> getByEspecialidad(int idEspecialidad)
        { return DB.Plan.getByEspecialidad(idEspecialidad); }
        #endregion
        #region Create
        public static void createPlan(string descripcion, int idEspecialidad)
        {
            DB.Plan.CreatePlan(descripcion, idEspecialidad);
        }
        #endregion
        #region Update
        public static void updatePlan(Entities.Plan plan)
        {
            DB.Plan.UpdatePlan(plan);
        }
        #endregion
        #region Delete
        public static void deletePlan(int id)
        { DB.Plan.deletePlan(id); }
        #endregion

        public static bool PlanExists(string desc, int idEsp)
        {
            Entities.Plan plan = DB.Plan.getOne(desc,idEsp);
            return plan != null;
        }
    }
}
