using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Curso
    {
        #region Getters
        public static List<Entities.Curso> getAll()
        { return DB.Curso.getAll(); }
        public static Entities.Curso getOne(int idCurso)
        { return DB.Curso.getOne(idCurso); }
       
        #endregion

        #region Create
        public static void createCurso(int idMateria, int idComision, int anioCalendario, int cupo)
        {
            DB.Curso.CreateCurso(idMateria, idComision, anioCalendario, cupo);
        }
        #endregion

        #region Update
        public static void updateCurso(Entities.Curso curso)
        {
            DB.Curso.UpdateCurso(curso);
        }
        #endregion

        #region Delete
        public static void deleteCurso(int id)
        { DB.Curso.deleteCurso(id); }
        #endregion

        public static bool CursoExists( int idMateria, int idComision, int anioCalendario, int cupo)
        {
            Entities.Curso curso = DB.Curso.GetCursoByData(idMateria, idComision, anioCalendario, cupo);

            // Verifica si se encontró un curso con los mismos datos (excepto IdCurso) en la base de datos
            return curso != null ;
        }
    }
}