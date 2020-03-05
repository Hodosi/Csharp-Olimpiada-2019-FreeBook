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

        public DataTable getallCarti()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT carti.IdCarte FROM carti INNER JOIN imprumut ON imprumut.Id_Carte=carti.IdCarte";
            command.Connection = conn.GetConnection();

            //command.Parameters.Add("em", SqlDbType.VarChar).Value = GLOBAL.emailGlobal;
            //command.Parameters.Add("date1", SqlDbType.DateTime).Value = date1;
            //command.Parameters.Add("date2", SqlDbType.DateTime).Value = date2;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }


        public string getallCartiByid(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT titlu FROM carti WHERE IdCarte=@id";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("id", SqlDbType.Int).Value =id;
            //command.Parameters.Add("date1", SqlDbType.DateTime).Value = date1;
            //command.Parameters.Add("date2", SqlDbType.DateTime).Value = date2;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows[0][0].ToString();
        }

        public int getallCartiCount()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM carti";
            command.Connection = conn.GetConnection();

            //command.Parameters.Add("em", SqlDbType.VarChar).Value = GLOBAL.emailGlobal;
            //command.Parameters.Add("date1", SqlDbType.DateTime).Value = date1;
            //command.Parameters.Add("date2", SqlDbType.DateTime).Value = date2;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table.Rows.Count;
        }
    }
}
