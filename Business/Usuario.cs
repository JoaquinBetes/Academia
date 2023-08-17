using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Usuario
    {
        public static bool NombreUsuarioExists(string nombreUsuario)
        {
            Entities.Usuario usuario = DB.Usuario.GetUsuario(nombreUsuario);

            return usuario.NombreUsuario != string.Empty;
        }
    }
}
