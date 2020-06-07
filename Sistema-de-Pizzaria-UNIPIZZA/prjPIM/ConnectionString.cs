using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPIM
{
    public static class connectionString
    {
        public static MySqlConnection conn()
        {
            string cstring = "Server=localhost;Database=unipizza;Uid=root;Pwd=;";
            MySqlConnection connect = new MySqlConnection(cstring);
            connect.Open();
            return connect;
        }
    }
}
