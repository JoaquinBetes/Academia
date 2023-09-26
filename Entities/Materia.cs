namespace Entities
{
   

    public class Materia
    {
        public int IdMateria { get; set; }
        public string Descripcion { get; set; }
        public int HsSemanales { get; set; }
        public int HsTotales { get; set; }
        public int IdPlan { get; set; }


        public Materia()
        {
            IdMateria = 0;
            Descripcion = "-";
            HsSemanales= 0;
            HsTotales = 0;
            IdPlan = 0;
          
        }

        public Materia(int materiaId, string descripcion, int hsSemanales, int hsTotales, int idP)
        {
            IdMateria = materiaId;
            Descripcion = descripcion;
            HsSemanales= hsSemanales;
            HsTotales = hsTotales;
            IdPlan = idP;
           
        }
    }
}