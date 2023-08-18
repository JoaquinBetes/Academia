﻿using DB;
using Entities;

namespace Business
{
    public class Persona
    {
        #region Geters
        public static List<Entities.Persona> getDatos()
        { return DB.Persona.getDatos(); }
        public static Entities.Persona getPersona(int dni) 
        { return DB.Persona.getPersona(dni); }
        #endregion
        #region Create
        public static void CreatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento)
        { DB.Persona.CreatePersona(dni, nombre, apellido, telefono, direccion, email, fechaNacimiento); }
        #endregion
        #region Update
        public static void UpdatePersona(int dni, string nombre, string apellido, string telefono, string direccion, string email, DateTime fechaNacimiento, int id)
        { DB.Persona.UpdatePersona(dni, nombre, apellido, telefono, direccion, email, fechaNacimiento, id); }
        #endregion
        #region Delete
        public static void deletePersona(int id)
        { DB.Persona.deletePersona(id); }
        #endregion

        public static bool DniExists(int dni)
        {
            Entities.Persona persona = DB.Persona.getPersona(dni);
            
            return persona.DNI != 0;
        }

    }
}