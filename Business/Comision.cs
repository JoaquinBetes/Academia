﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Comision
    {
        #region Getters

        public static List<Entities.Comision> GetAll()
        { return DB.Comision.GetAll(); }

        #endregion
        #region Create
        #endregion
        #region Update
        #endregion
        #region Delete

        public static void DeleteComision(int id)
        { DB.Comision.DeleteComision(id); }

        #endregion
    }
}