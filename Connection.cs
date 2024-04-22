using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLiQuanCaPhe
{
    internal class Connection
    {
        private static string stringconnection = @"Data Source=QUANGHUY2004\HUYPC04;Initial Catalog=game;Integrated Security=True";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }
    }
}
