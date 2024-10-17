using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//1
using System.Data.SqlClient;

namespace tugas1db
{
    class koneksi
    {
        //2
        public SqlConnection GetConn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = REVISION-PC\\SQLEXPRESS; initial catalog=DB_KAYIS; integrated security=true";
            return Conn;
        }
    }
}
