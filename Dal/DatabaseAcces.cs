using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Dal
{
   public  class DatabaseAcces
    {
        public MySqlConnection conn;
        public DatabaseAcces()
        {
            conn = new MySqlConnection("server=studmysql01.fhict.local;Uid=dbi419727;Database=dbi419727;pwd=Testing;");
        }
    }
}
