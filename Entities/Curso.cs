namespace Entities
{


    public class Curso
    {
        public int IdCurso { get; set; }
        public int IdMateria { get; set; }
        public int IdComision { get; set; }
        public int AnioCalendario { get; set; }
        public int Cupo { get; set; }

        public Curso()
        {
            IdCurso = 0;
            IdMateria = 0;
            IdComision = 0;
            AnioCalendario = 0;
            Cupo = 0;
        }

        public Curso(int idCurso, int idMateria, int idComision, int anioCalendario, int cupo)
        {
            IdCurso = idCurso;
            IdMateria = idMateria;
            IdComision = idComision;
            AnioCalendario = anioCalendario;
            Cupo = cupo;
        }
    }
}