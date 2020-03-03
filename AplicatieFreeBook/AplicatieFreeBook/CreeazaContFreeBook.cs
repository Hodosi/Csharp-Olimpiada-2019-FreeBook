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
    public partial class CreeazaContFreeBook : Form
    {
        public CreeazaContFreeBook()
        {
            InitializeComponent();
        }

        UTILIZATOR util = new UTILIZATOR();
        private void button_signin_Click(object sender, EventArgs e)
        {
            string em = this.textBox_email.Text;
            string pass = this.textBox_pass.Text;
            string pass1 = this.textBox_pass1.Text;
            string nume = this.textBox_nume.Text;
            string prenume = this.textBox_prenume.Text;

            if (em.Trim().Equals("") || pass.Trim().Equals("") || pass1.Trim().Equals("") || nume.Trim().Equals("") || prenume.Trim().Equals(""))
            {
                MessageBox.Show("Campuri incomplete");
            }
            else if (util.emailExists(em))
            {
                MessageBox.Show("Emailul exista deja");
            }
            else if (pass != pass1)
            {
                MessageBox.Show("Parole diferite");
            }
            else if (util.insertUtilizator(em, pass, nume, prenume))
            {
                MessageBox.Show("Iregistrare cu succes");
                this.Hide();
                GLOBAL.emailGlobal = em;
                MeniuFreeBook frmMeniu = new MeniuFreeBook();
                frmMeniu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Eroare Inregistrare");
            }
        }
    }
}
