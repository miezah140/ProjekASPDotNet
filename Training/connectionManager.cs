using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Training
{
    public static class connectionManager // buat class baru nama ini
    {
        public static SqlConnection GetConnection() //method baru
        {
            //get connection string from web.config
            var connection = ConfigurationManager.ConnectionStrings["DBTraining"].ToString();
            return new SqlConnection(connection);
        }
    }
}