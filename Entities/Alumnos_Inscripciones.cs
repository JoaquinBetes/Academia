using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Alumnos_Inscripciones
    {
        public int IdInscripcion { get; set; }
        public int IdAlumno { get; set; }
        public int IdCurso { get; set; }
        public string Condicion {  get; set; }
        public int Nota { get; set; }

        public Alumnos_Inscripciones() { }

        public Alumnos_Inscripciones(int idAlumno, int idCurso, string condicion, int nota)
        {
            IdAlumno = idAlumno;
            IdCurso = idCurso;
            Condicion = condicion;
            Nota = nota;
        }
    }
}
