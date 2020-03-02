using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AplicatieFreeBook
{
    class CONNECT
    {
        public static string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|FreeBook.mdf;Integrated Security = True; Connect Timeout = 30";

        SqlConnection conn = new SqlConnection(constring);

        public SqlConnection GetConnection()
        {
            return conn;
        }

        public void openConnnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
