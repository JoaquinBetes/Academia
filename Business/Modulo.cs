using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Modulo
    {
        #region Geters
        public static Entities.Modulo getModulo(int idModulo)
        { return DB.Modulo.getModulo(idModulo); }
        public static List<Entities.Modulo> getModulos()
        { return DB.Modulo.getModulos(); }
        #endregion
        }
}
