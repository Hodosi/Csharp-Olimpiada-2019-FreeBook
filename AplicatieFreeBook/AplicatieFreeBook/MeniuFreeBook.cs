using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplicatieFreeBook
{
    public partial class MeniuFreeBook : Form
    {
        public MeniuFreeBook()
        {
            InitializeComponent();
        }

        CONNECT conn = new CONNECT();
        IMPRUMUT imp = new IMPRUMUT();
        CARTI carte = new CARTI();
        private void MeniuFreeBook_Load(object sender, EventArgs e)
        {
            this.label_email.Text = GLOBAL.emailGlobal;
            this.dataGridView_disponibil.DataSource = carte.getCartiDisponibile();
            load_crtimpcntr();
        }

        public void load_crtimpcntr()
        {
            DataTable table = new DataTable();
            DateTime date;
            table = imp.getcartiImprumutate();
            table.Columns.Add("Data Disponibilitate", typeof(DateTime));
            table.Columns.Add("Index", typeof(string));
            //------------------------------------------------
            for (int i = 0; i < table.Rows.Count; i++)
            {
                date = DateTime.Parse(table.Rows[i][2].ToString());
                date = date.AddDays(30);
                table.Rows[i][3] = date;
                table.Rows[i][4] = (i + 1).ToString();
            }
            //------------------------------------------------
            this.dataGridView1.DataSource = table;
            //-----------------------------------------------
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int disponibil = 0;
            DataTable table = new DataTable();
            DateTime date;
            table = imp.getcartiImprumutate();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                date = DateTime.Parse(this.dataGridView1.Rows[i].Cells[3].Value.ToString());
                if (date < DateTime.Now)
                {
                    //MessageBox.Show("Hei");
                    disponibil++;
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
                else
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
            }
            this.progressBar1.Maximum = table.Rows.Count;
            this.progressBar1.Value = (table.Rows.Count - disponibil);
            this.label_disponibilitate.Text = (table.Rows.Count - disponibil).ToString() + "/" + table.Rows.Count.ToString();
        }



        private void dataGridView_disponibil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DateTime data = DateTime.Now.AddDays(-30);
                if (imp.nrcartiImprumutate(data) >= 3)
                {
                    MessageBox.Show("Nu mai puteti imprumuta carti!");
                    return;
                }
                int idcarte = getidCarte(this.dataGridView_disponibil.Rows[e.RowIndex].Cells[1].Value.ToString());
                string email = GLOBAL.emailGlobal;
                data = DateTime.Now;
                if (imp.insertImprumut(idcarte, email, data))
                {
                   // load_crtimpcntr();
                    MessageBox.Show("Carte imprumutata");
                }
            }
        }

        public int getidCarte(string carte)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT IdCarte FROM carti WHERE titlu=@car";
            command.Connection = conn.GetConnection();

            command.Parameters.Add("car", SqlDbType.VarChar).Value = carte;

            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return int.Parse(table.Rows[0][0].ToString());
        }
    }
}
