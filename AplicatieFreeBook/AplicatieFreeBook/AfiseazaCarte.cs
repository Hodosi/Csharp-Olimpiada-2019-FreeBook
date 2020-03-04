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
    public partial class AfiseazaCarte : Form
    {
        public AfiseazaCarte()
        {
            InitializeComponent();
        }

        private void AfiseazaCarte_Load(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\OJTI_2019_C#_resurse\cartipdf\" + this.label_titlu.Text + ".pdf";
            webBrowser1.Url = new Uri(fn);
        }
    }
}
