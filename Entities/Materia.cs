namespace Entities
{
   

    public class Materia
    {
        public int MateriaId { get; set; }
        public string Descripcion { get; set; }
        public int HsSemanales { get; set; }
        public int HsTotales { get; set; }
       

        public Materia()
        {
            MateriaId = 0;
            Descripcion = "-";
            HsSemanales= 0;
            HsTotales = 0;
          
        }

        public Materia(int materiaId, string descripcion, int hsSemanales, int hsTotales)
        {
            MateriaId = materiaId;
            Descripcion = descripcion;
            HsSemanales= hsSemanales;
            HsTotales = hsTotales;
           
        }
    }
}