using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Especialidad
    {
        #region Geters
        public static List<Entities.Especialidad> Get()
        { return DB.Especialidad.Get(); }
        public static Entities.Especialidad Get(int id)
        { return DB.Especialidad.Get(id); }
        #endregion
        #region Create
        public static void Add(string desc)
        { DB.Especialidad.Add( desc ); }
        #endregion
        #region Update
        public static void Update(int id, string desc)
        { DB.Especialidad.Update(id, desc); }
        #endregion
        #region Delete
        public static void Delete(int id)
        { DB.Especialidad.Delete(id); }

        #endregion
    }
}
