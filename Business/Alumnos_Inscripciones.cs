using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Alumnos_Inscripciones
    {
        #region Getters

        public static List<Entities.Alumnos_Inscripciones> GetAll()
        { return DB.Alumnos_Inscripciones.GetAll(); }

        #endregion
        #region Create

        public static void CreateInscripcion(int idAlumno, int idCurso, string condicion, int nota)
        { DB.Alumnos_Inscripciones.CreateInscripcion(idAlumno, idCurso, condicion, nota); }

        #endregion
        #region Update
        #endregion
        #region Delete
        #endregion
    }
}
