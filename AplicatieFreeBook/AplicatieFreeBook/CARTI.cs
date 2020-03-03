using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AplicatieFreeBook
{
    class CARTI
    {
        CONNECT conn = new CONNECT();

        public DataTable getCartiDisponibile()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT titlu,autor,gen FROM carti ";
            command.Connection = conn.GetConnection();

            //command.Parameters.Add("em", SqlDbType.VarChar).Value = GLOBAL.emailGlobal;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
