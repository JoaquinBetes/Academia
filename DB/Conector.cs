using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public abstract class Conector
    {
        protected static string ConnectionString { get; private set; }
        static Conector()
        {
            //ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Academia;User ID=net;Password=net;Trusted_Connection=false;Encrypt=false";
            ConnectionString = "Server=.\\SQLEXPRESS;Database=Academia2;Trusted_Connection=True;Encrypt=false";
        }
    }
}
