using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AplicatieFreeBook
{
    class IMPRUMUT
    {
        CONNECT conn = new CONNECT();

        public bool insertImprumut(int id, string em, DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "INSERT INTO imprumut(Id_Carte,email,data_imprumut) VALUES(@id,@em,@data)";
            command.Connection = conn.GetConnection();

            //@id,@em,@data
            command.Parameters.Add("id", SqlDbType.Int).Value = id;
            command.Parameters.Add("em", SqlDbType.VarChar).Value = em;
            command.Parameters.Add("data", SqlDbType.DateTime).Value = date;

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


        public int nrcartiImprumutate(DateTime date)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM imprumut WHERE email=@em AND data_imprumut>@data ";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = GLOBAL.emailGlobal;
            command.Parameters.Add("data", SqlDbType.DateTime).Value = date;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows.Count.ToString());
        }

        public DataTable getcartiImprumutate()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT titlu AS Titlu,autor As Autor,imprumut.data_imprumut AS DataImprumut FROM carti INNER JOIN imprumut ON carti.IdCarte=imprumut.Id_Carte WHERE email=@em  ";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("em", SqlDbType.VarChar).Value = GLOBAL.emailGlobal;
            //command.Parameters.Add("data", SqlDbType.DateTime).Value = date;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataColumn getTitluCarti()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT titlu AS Titlu FROM carti INNER JOIN imprumut ON carti.IdCarte=imprumut.Id_Carte WHERE email=@em ";
            command.Connection = conn.GetConnection(); 

            command.Parameters.Add("em", SqlDbType.VarChar).Value = GLOBAL.emailGlobal;
            //command.Parameters.Add("data", SqlDbType.DateTime).Value = date;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            DataColumn columns = table.Columns[0];

            return columns;
        }

    }
}
