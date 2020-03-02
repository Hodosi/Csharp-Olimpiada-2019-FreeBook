using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AplicatieFreeBook
{
    public partial class LogareFreeBook : Form
    {
        public LogareFreeBook()
        {
            InitializeComponent();
        }

        UTILIZATOR util = new UTILIZATOR();
        private void button_Login_Click(object sender, EventArgs e)
        {
            string em = this.textBox_email.Text;
            string pass = this.textBox_parola.Text;

            if (util.userExists(em, pass))
            {
                this.Hide();
                GLOBAL.emailGlobal = em;
                MeniuFreeBook frmMENIU = new MeniuFreeBook();
                frmMENIU.ShowDialog();
                this.Close();
            }
            else
            {
               this.textBox_email.ResetText();
               this.textBox_parola.ResetText();
               MessageBox.Show("Eroare Autentificare"); 
            }
        }
    }
}
