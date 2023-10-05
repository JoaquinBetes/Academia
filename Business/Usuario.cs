using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Usuario
    {
        #region Geters
        public static int getUsuarioId(int legajo)
        { return DB.Usuario.getUsuarioId(legajo); }
        public static int getPersonaId(int legajo)
        { return DB.Usuario.getPersonaId(legajo); }
        public static Entities.Usuario? getUsuario(int legajo)
        {
            if (DB.Usuario.getUsuario(legajo).Legajo == 0) return null;
            else return DB.Usuario.getUsuario(legajo); 
        }
        public static Entities.Usuario? getUsuario(string nombreUsuario)
        { return DB.Usuario.getUsuario(nombreUsuario); }
        public static List<Entities.Usuario> getDatos()
        { return DB.Usuario.getDatos(); }
        #endregion
        #region Create
        public static void CreateUsuario(string nombreUsuario, string clave, string tipo, bool habilitado, int dni, int personaId, int legajo)
        { DB.Usuario.CreateUsuario(nombreUsuario, clave, tipo, habilitado, dni, personaId, legajo); }
        #endregion
        #region Update
        public static void UpdateUsuario(Entities.Usuario usuario)
        { DB.Usuario.UpdateUsuario(usuario); }
        #endregion
        #region Delete
        public static void deleteUsuario(int legajo)
        { DB.Usuario.deleteUsuario(legajo); }
        #endregion
        public static bool LegajoUsuarioExists(int legajo)
        {
            Entities.Usuario usuario = DB.Usuario.getUsuario(legajo);

            return usuario.Legajo != 0;
        }
        public static bool NombreUsuarioExists(string nombreUsuario)
        {
            Entities.Usuario usuario = DB.Usuario.getUsuario(nombreUsuario);

            return usuario.NombreUsuario != string.Empty;
        }
        public static bool MinimoUsuarios(int personaId)
        {
            return DB.Usuario.CountUsuarios(personaId) <= 1;
        }
        public static bool CampoVacio(string? campo) 
        {
            return campo == "";
        }
        public static bool ClaveInvalida(string clave)
        { 
            return clave.Length < 8;
        }
    }
}
