using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AplicatieFreeBook
{
    class UTILIZATOR
    {
        CONNECT conn = new CONNECT();

        public bool insertUtilizator(string em, string par, string nm, string pnm)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO utilizatori(email,parola,nume,prenume) VALUES(@em,@pass,@nm,@pnm)";
            command.Connection = conn.GetConnection();

            //@em,@pass,@nm,@pnm
            command.Parameters.Add("em", SqlDbType.VarChar).Value = em;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = par;
            command.Parameters.Add("nm", SqlDbType.VarChar).Value = nm;
            command.Parameters.Add("pnm", SqlDbType.VarChar).Value = pnm;

            conn.openConnnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnnection();
                return true;
            }
            else
            {
                conn.closeConnnection();
                return false;
            }
        }

        public bool emailExists(string em)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM utilizatori WHERE email=@em";
            command.Connection = conn.GetConnection();


            command.Parameters.Add("em", SqlDbType.VarChar).Value = em;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool userExists(string em,string pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM utilizatori WHERE email=@em AND parola=@pass";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = em;
            command.Parameters.Add("pass", SqlDbType.VarChar).Value = pass;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
