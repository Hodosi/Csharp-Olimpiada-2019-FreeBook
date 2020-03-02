using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace AplicatieFreeBook
{
    public partial class FreeBookHome : Form
    {
        public FreeBookHome()
        {
            InitializeComponent();
        }

        CONNECT conn = new CONNECT();
        DBCheck check = new DBCheck();
        GLOBAL global = new GLOBAL();
        private void FreeBookHome_Load(object sender, EventArgs e)
        {
            load_stuff();
            check.checkDB();
            stergere();
            initializare();
            load_stuff();
        }

        public void load_stuff()
        {
            string fn = Application.StartupPath + @"\OJTI_2019_C#_resurse\sigla_Biblioteca_3.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
        }

        public void stergere()
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "DELETE FROM carti";
            command.Connection = conn.GetConnection();

            conn.openConnnection();
            command.ExecuteNonQuery();
            conn.closeConnnection();

            command = new SqlCommand();
            command.CommandText = "DELETE FROM imprumut";
            command.Connection = conn.GetConnection();

            conn.openConnnection();
            command.ExecuteNonQuery();
            conn.closeConnnection();

            command = new SqlCommand();
            command.CommandText = "DELETE FROM utilizatori";
            command.Connection = conn.GetConnection();

            conn.openConnnection();
            command.ExecuteNonQuery();
            conn.closeConnnection();
        }

        public void initializare()
        {
            SqlCommand command;
            string sir;
            string[] siruri;
            char split = '*';
            string fn = Application.StartupPath + @"\OJTI_2019_C#_resurse\carti.txt";
            StreamReader reader = new StreamReader(fn);

            while ((sir = reader.ReadLine()) != null)
            {
                siruri = sir.Split(split);
                command = new SqlCommand();
                command.CommandText = "INSERT INTO carti(titlu,autor,gen) VALUES(@tit,@au,@gen)";
                command.Connection = conn.GetConnection();

                //@tit,@au,@gen
                command.Parameters.Add("tit", SqlDbType.VarChar).Value = siruri[0];
                command.Parameters.Add("au", SqlDbType.VarChar).Value = siruri[1];
                command.Parameters.Add("gen", SqlDbType.VarChar).Value = siruri[2];

                conn.openConnnection();
                command.ExecuteNonQuery();
                conn.closeConnnection();

            }

            fn = Application.StartupPath + @"\OJTI_2019_C#_resurse\utilizatori.txt";
            reader = new StreamReader(fn);

            while ((sir = reader.ReadLine()) != null)
            {
                siruri = sir.Split(split);
                command = new SqlCommand();
                command.CommandText = "INSERT INTO utilizatori(email,parola,nume,prenume) VALUES(@em,@pass,@nm,@pnm)";
                command.Connection = conn.GetConnection();

                //@em,@pass,@nm,@pnm
                command.Parameters.Add("em", SqlDbType.VarChar).Value = siruri[0];
                command.Parameters.Add("pass", SqlDbType.VarChar).Value = siruri[1];
                command.Parameters.Add("nm", SqlDbType.VarChar).Value = siruri[2];
                command.Parameters.Add("pnm", SqlDbType.VarChar).Value = siruri[3];

                conn.openConnnection();
                command.ExecuteNonQuery();
                conn.closeConnnection();
            }

            fn = Application.StartupPath + @"\OJTI_2019_C#_resurse\imprumuturi.txt";
            reader = new StreamReader(fn);

            while ((sir = reader.ReadLine()) != null)
            {
                siruri = sir.Split(split);
                command = new SqlCommand();
                command.CommandText = "INSERT INTO imprumut(Id_Carte,email,data_imprumut) VALUES(@id,@em,@data)";
                command.Connection = conn.GetConnection();

                //@id,@em,@data
                int id_carte = getidCarte(siruri[0]);
                command.Parameters.Add("id", SqlDbType.Int).Value = id_carte;
                command.Parameters.Add("em", SqlDbType.VarChar).Value = siruri[1];
                command.Parameters.Add("data", SqlDbType.DateTime).Value = siruri[2];

                conn.openConnnection();
                command.ExecuteNonQuery();
                conn.closeConnnection();
            }

        }

        public int getidCarte(string carte)
        {
           // MessageBox.Show(carte);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT IdCarte FROM carti WHERE titlu=@car";
            command.Connection = conn.GetConnection();

            //@tit,@au,@gen
            command.Parameters.Add("car", SqlDbType.VarChar).Value = carte;

            //conn.openConnnection();

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            //MessageBox.Show(table.Rows.Count.ToString());
            return int.Parse(table.Rows[0][0].ToString());

            //conn.closeConnnection();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogareFreeBook frmLog = new LogareFreeBook();
            frmLog.ShowDialog();
            this.Close();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreeazaContFreeBook frmSign = new CreeazaContFreeBook();
            frmSign.ShowDialog();
            this.Close();
        }
    }
}
