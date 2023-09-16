using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ModuloUsuario
    {
        #region Geters
        public static List<Entities.ModuloUsuario> getModulosUsuario(int idUsuario)
        {
            return DB.ModuloUsuario.getModulosUsuario(idUsuario);
        }
        #endregion
        #region Create
        public static void CreateModuloUsuario(int IdModuloUsuario, string tipo, int IdUsuario, bool Alta, bool Baja, bool Modificacion, bool Consulta)
        {
            int idModulo;
            if (tipo == "Alumno") { idModulo = 1; }
            else if (tipo == "Docente") { idModulo = 2; }
            else { idModulo = 3; }

            DB.ModuloUsuario.CreateModuloUsuario(IdModuloUsuario, idModulo, IdUsuario, Alta, Baja, Modificacion, Consulta);
        }
        #endregion
    }
}
