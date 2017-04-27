using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void messsend_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/sys " + "'" + messtxt.Text + "'";
        }

        private void copy_Click(object sender, EventArgs e)
        {
            String Resulttext = resultbox.Text;
            Clipboard.SetText(Resulttext);
        }
    }
}
