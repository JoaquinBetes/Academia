using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public abstract class Validaciones
    {
        public static Entities.ModuloUsuario? permisos( Entities.Usuario usuario, string tabla) 
        {
            Entities.ModuloUsuario? mod = null;
            List<Entities.ModuloUsuario> modulosUsuarios = Business.ModuloUsuario.getModulosUsuario(usuario.Id);
            foreach (Entities.ModuloUsuario moduloUsuario in modulosUsuarios)
            {
                int modId = Business.ModuloUsuario.getModuloId(moduloUsuario.IdModulo);
                Entities.Modulo? modulo = Business.Modulo.getModulo(modId);
                if (modulo != null && modulo.Descripcion.Equals(tabla))
                {
                    mod = moduloUsuario;
                }
            }
        return mod;
        }
    }
}
