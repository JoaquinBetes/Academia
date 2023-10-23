using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Materia
    {
        #region Getters
        public static List<Entities.Materia> getAll()
        { return DB.Materia.getAll(); }
        public static Entities.Materia getOne(string desc, int idPlan)
        { return DB.Materia.getOne(desc, idPlan); }

        public static Entities.Materia getById(int id)
        { return DB.Materia.getById(id); }

        public static List<Entities.Materia> getByPlan(int idPlan)
        { return DB.Materia.getByPlan(idPlan); }
        #endregion
        #region Create
        public static void createMateria(string descripcion, int hsSemanales, int hsTotales, int idP)
        {
            DB.Materia.CreateMateria( descripcion, hsSemanales, hsTotales, idP);
        }
        #endregion
        #region Update
        public static void updateMateria(Entities.Materia materia)
        {
            DB.Materia.UpdateMateria(materia);
        }       
        #endregion
        #region Delete
        public static void deleteMateria(int id)
        { DB.Materia.deleteMateria(id); }
        #endregion

        public static bool MateriaExists(string desc, int idPlan)
        {
            Entities.Materia materia = DB.Materia.getOne(desc, idPlan);
            return materia != null;
        }
    }
}