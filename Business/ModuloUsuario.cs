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
        public static int getModuloId(int idModuloUsuario)
        {
            return DB.ModuloUsuario.getModuloId(idModuloUsuario);
        }
            #endregion
            #region Create
            public static void CreateModulosUsuario( string tipo, int IdUsuario)
        {
            List<Entities.Modulo> modulos = Business.Modulo.getModulos();
            foreach (Entities.Modulo modulo in modulos) 
            {
                if (tipo == "Administrador")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, true, true, true, true);
                }
                else if (modulo.Descripcion == "Personas" || modulo.Descripcion == "Usuarios")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, false, false, true, true);
                }
                else if (modulo.Descripcion == "Alumnos_Inscripciones" && tipo == "Alumno")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, true, false, false, true);
                }
                else if (modulo.Descripcion == "Alumnos_Inscripciones" && tipo == "Docente")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, true, false, false, true);
                }
                else
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, false, false, false, true);
                }
                
            }       
        }
        #endregion
    }
}
