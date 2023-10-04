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
        public static void CreateModulosUsuario( string tipo, int IdUsuario, bool Alta, bool Baja, bool Modificacion, bool Consulta)
        {
            List<Entities.Modulo> modulos = Business.Modulo.getModulos();
            foreach (Entities.Modulo modulo in modulos) 
            {

                if (modulo.Descripcion == "Persona" || modulo.Descripcion == "Usuario")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, false, false, true, true);
                }
                else if (modulo.Descripcion == "Inscripcion" && tipo == "Alumno")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, true, false, false, true);
                }
                else if (modulo.Descripcion == "Inscripcion" && tipo == "Docente")
                {
                    DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, true, false, false, true);
                }
                else if (tipo == "Administrador")
                {
                    if (modulo.Descripcion == "Persona" || modulo.Descripcion == "Usuario" || modulo.Descripcion == "Inscripcion")
                    {
                        DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, true, true, true, true);
                    }
                    else 
                    {
                        DB.ModuloUsuario.CreateModuloUsuario(modulo.Id, IdUsuario, false, false, true, true);
                    }
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
