using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Docentes_Cursos
    {
        public int IdDictado {  get; set; }
        public int IdCurso { get; set; }
        public int IdDocente { get; set; }
        public int Cargo { get; set; }

        public Docentes_Cursos() { }
        public Docentes_Cursos (int idDictado, int idCurso, int idDocente, int cargo) 
        { 
            IdDictado = idDictado;
            IdCurso = idCurso; 
            IdDocente = idDocente;
            Cargo = cargo;
        }
    }
}
