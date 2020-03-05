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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Red)
            {
                MessageBox.Show("Perioada imprumutului a expirat!");
            }
            else
            {
                this.Hide();
                AfiseazaCarte frmcarte = new AfiseazaCarte();
                frmcarte.label_titlu.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                frmcarte.label_autor.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmcarte.ShowDialog();
                this.Show();
            }
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

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            //draw_utilizatori();
            loadcomobo();
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //draw_utilizatori();
            loadcomobo();
            draw_carti();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //draw_utilizatori();
            loadcomobo();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            draw_utilizatori();
        }

        public void draw_utilizatori()
        {
            //---------------------------------------------------
            Graphics graphics = this.panel_graf_utilizatori.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);
            Brush brush1 = new SolidBrush(Color.Blue);
            Brush brush2 = new SolidBrush(Color.White);
            Font font = new Font("Arial", 12);
            graphics.FillRectangle(brush2, 0, 0, this.panel_graf_utilizatori.ClientSize.Width, this.panel_graf_utilizatori.ClientSize.Height);
            //---------------------------------------------------
            string[] month = new string[] { "ian", "feb", "mar", "april", "mai", "iun", "iul", "aug", "sept", "oct", "noi", "dec" };
            //---------------------------------------------------
            int combodate = int.Parse(this.comboBox1.SelectedItem.ToString());
            //MessageBox.Show(combodate.ToString());
            DateTime date1 = new DateTime(combodate, 1, 1);
            combodate += 1;
            DateTime date2 = new DateTime(combodate, 1, 1);
            combodate -= 1;
            DataTable table = imp.getallCarti(date1, date2);
            //MessageBox.Show(table.Rows.Count.ToString());
            int grafHeight = this.panel_graf_utilizatori.ClientSize.Height;
            int grafWidht = this.panel_graf_utilizatori.ClientSize.Width;
            grafHeight -= 20;
            grafWidht -= 20;

            graphics.DrawLine(pen, 20, 20, 20, grafHeight);
            graphics.DrawLine(pen, 20, grafHeight, grafWidht, grafHeight);

            int lunaWidth = (grafWidht - 40) / 24;
            int unitWidht = (grafHeight - 40) / 10;
            for (int i = 1; i <= 12; i++)
            {
                graphics.DrawString(month[i - 1], font, brush, (lunaWidth * 2) * i, grafHeight);
                //graphics.DrawString("0", font, brush, (lunaWidth * 2) * i, grafHeight - 20);
            }
            for (int i = 10; i >= 1; i--)
            {
                graphics.DrawString(i.ToString(), font, brush, 0, unitWidht * (10 - i + 1));
            }
            int nrcartiluna;
            for (int i = 1; i < 12; i++)
            {
                date1 = new DateTime(combodate, i, 1);
                date2 = new DateTime(combodate, i + 1, 1);
                nrcartiluna = imp.getallCartiLuna(date1, date2);
                // MessageBox.Show(nrcartiluna.ToString());
                graphics.FillRectangle(brush1, (lunaWidth * 2) * i, unitWidht * (10 - nrcartiluna + 2), lunaWidth, (unitWidht * nrcartiluna));
                graphics.DrawString(nrcartiluna.ToString(), font, brush, (lunaWidth * 2) * i, unitWidht * (10 - nrcartiluna + 1));
            }

            //--------------pentru luna 12----------------------
            date1 = new DateTime(combodate, 12, 1);
            date2 = new DateTime(combodate + 1, 1, 1);
            nrcartiluna = imp.getallCartiLuna(date1, date2);
            // MessageBox.Show(nrcartiluna.ToString());
            graphics.FillRectangle(brush1, (lunaWidth * 2) * 12, unitWidht * (10 - nrcartiluna + 2), lunaWidth, (unitWidht * nrcartiluna));
            graphics.DrawString(nrcartiluna.ToString(), font, brush, (lunaWidth * 2) * 12, unitWidht * (10 - nrcartiluna + 1));

        }

        public void draw_carti()
        {
            Graphics graphics = this.panel_graf_carti.CreateGraphics();
            Pen pen = new Pen(Color.Black);
            Brush brush0black = new SolidBrush(Color.Black);
            Brush brush1red = new SolidBrush(Color.Red);
            Brush brush2green = new SolidBrush(Color.Green);
            Brush brush3yellow = new SolidBrush(Color.Yellow);
            Brush brush4purple = new SolidBrush(Color.Purple);
            Font fontTitlu = new Font("Arial", 22);
            Font fontcarti = new Font("Arial", 12);

            int grafHeight = this.panel_graf_carti.ClientSize.Height;
            int grafWidht = this.panel_graf_carti.ClientSize.Width;

            int cartCount = carte.getallCartiCount();
            int[] frecventa = new int[cartCount + 1];
            DataTable table = carte.getallCarti();
            for (int i = 1; i <= cartCount; i++)
            {
                frecventa[i] = 0;
            }
            for (int i = 0; i < table.Rows.Count; i++)
            {
                frecventa[int.Parse(table.Rows[i][0].ToString())]++;
            }

            int[] maxim = new int[5];
            int[] maximnr = new int[5];
            maxim[0] = 10000;
            for (int i = 1; i <= 4; i++)
            {
                maxim[i] = 1;
                for (int j = 1; j <= cartCount; j++)
                {
                    if (frecventa[maxim[i]] < frecventa[j])
                    {
                        maxim[i] = j;
                    }
                }
                maximnr[i] = frecventa[maxim[i]];
                frecventa[maxim[i]] = 0;
            }

            //for (int i = 1; i <= 4; i++)
            //{
            //    string titlu = carte.getallCartiByid(maxim[i]);
            //    //MessageBox.Show(titlu + "  " + maximnr[i].ToString());
            //}

            graphics.DrawString("Carti populare", fontTitlu, brush0black, grafWidht / 2 - 120, 10);
            graphics.DrawRectangle(pen, 20, grafHeight - 50, grafWidht - 40, 40);

            string titlu = carte.getallCartiByid(maxim[1]);
            graphics.FillRectangle(brush1red, 30, grafHeight - 40, 10, 20);
            graphics.DrawString(titlu, fontcarti, brush0black, 50, grafHeight - 40);
            titlu = carte.getallCartiByid(maxim[2]);
            graphics.FillRectangle(brush2green, 250, grafHeight - 40, 10, 20);
            graphics.DrawString(titlu, fontcarti, brush0black, 270, grafHeight - 40);
            titlu = carte.getallCartiByid(maxim[3]);
            graphics.FillRectangle(brush3yellow, 360, grafHeight - 40, 10, 20);
            graphics.DrawString(titlu, fontcarti, brush0black, 380, grafHeight - 40);
            titlu = carte.getallCartiByid(maxim[4]);
            graphics.FillRectangle(brush4purple, 550, grafHeight - 40, 10, 20);
            graphics.DrawString(titlu, fontcarti, brush0black, 570, grafHeight - 40);

            grafHeight -= 150;
            //float total = values.Sum();

            //// Draw the slices.
            //float start_angle = 0;
            //for (int i = 0; i < values.Length; i++)
            //{
            //    float sweep_angle = values[i] * 360f / total;
            //    gr.FillPie(brushes[i % brushes.Length],
            //        rect, start_angle, sweep_angle);
            //    gr.DrawPie(pens[i % pens.Length],
            //        rect, start_angle, sweep_angle);
            //    start_angle += sweep_angle;
            //}

            int total = maximnr.Sum();
            float start_angle = 0;
            float sweep_angle = maximnr[1] * 360 / total;
            graphics.FillPie(brush1red, 250, 50, 200, 200, start_angle, sweep_angle);
            start_angle += sweep_angle;
            sweep_angle = maximnr[2] * 360 / total;
            graphics.FillPie(brush2green, 250, 50, 200, 200, start_angle, sweep_angle);
            start_angle += sweep_angle;
            sweep_angle = maximnr[3] * 360 / total;
            graphics.FillPie(brush3yellow, 250, 50, 200, 200, start_angle, sweep_angle);
            start_angle += sweep_angle;
            sweep_angle = maximnr[4] * 360 / total;
            graphics.FillPie(brush4purple, 250, 50, 200, 200, start_angle, sweep_angle);

        }


        public void loadcomobo()
        {
            for (int i = 2000; i <= 2020; i++)
            {
                this.comboBox1.Items.Add(i);
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
