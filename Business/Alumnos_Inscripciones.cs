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

        public static bool SuperaCupo(int idCurso)
        {
            if (DB.Alumnos_Inscripciones.GetAllByCurso(idCurso).Count >= DB.Curso.getOne(idCurso).Cupo)
            {
                return true;
            }
            else { return false; }
        }

        #endregion
        #region Create

        public static void CreateInscripcion(int idAlumno, int idCurso, string condicion, int nota)
        { DB.Alumnos_Inscripciones.CreateInscripcion(idAlumno, idCurso, condicion, nota); }

        #endregion
        #region Update
        public static void UpdateInscripcion(int idInscripcion, int idAlumno, int idCurso, string condicion, int nota)
        { DB.Alumnos_Inscripciones.Update(idInscripcion, idAlumno, idCurso, condicion, nota); }
        #endregion
        #region Delete
        #endregion
    }
}
