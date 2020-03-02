using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AplicatieFreeBook
{
    class DBCheck
    {
        CONNECT conn = new CONNECT();
        public void checkDB()
        {

            SqlCommand command = new SqlCommand();
            command.CommandText = "DBCC CHECKIDENT (carti,RESEED,0)";
            command.Connection = conn.GetConnection();

            conn.openConnnection();
            command.ExecuteNonQuery();
            conn.closeConnnection();

            command = new SqlCommand();
            command.CommandText = "DBCC CHECKIDENT (imprumut,RESEED,0)";
            command.Connection = conn.GetConnection();

            conn.openConnnection();
            command.ExecuteNonQuery();
            conn.closeConnnection();
        }
    }
}
