using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Lucky.Data
{
    public class DataBase
    {
        public DataBase() { }

        public static SqlConnection getConnection()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConectaDBLucky"].ConnectionString);
            return cn;

        }
    }
}
