using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Docentes_Cursos
    {
        #region Getters

        public static List<Entities.Docentes_Cursos> GetAll()
        { return DB.Docentes_Cursos.GetAll(); }

        #endregion
        #region Create

        public static void CreateInscripcion(int idCurso, int idDocente, int cargo)
        { DB.Docentes_Cursos.CreateInscripcion(idCurso, idDocente, cargo); }

        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
