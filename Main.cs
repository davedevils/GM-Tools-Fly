using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM_Tools
{
    public partial class Main : Form
    {
        int Lang = 0;
        public Main()
        {
            InitializeComponent();
        }

        private void françaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lang = 0;
        }

        private void anglaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lang = 1;
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
            resultbox.Text = "/system " + "'" + messtxt.Text + "'";
        }

        private void copy_Click(object sender, EventArgs e)
        {
            String Resulttext = resultbox.Text;
            Clipboard.SetText(Resulttext);
        }

        private void mouvstop_Click(object sender, EventArgs e)
        {

            resultbox.Text = "/freeze " + playername.Text ;
        }

        private void mouvstart_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/Nofreeze " + playername.Text;
        }

        private void mute_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/MUTE " + playername.Text + " " + hourmute.Text;
        }

        private void miseÀJourParLesRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }

}
