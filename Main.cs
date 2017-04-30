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
        Credit creditpage = null;
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

        private void miseÀJourParLesRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResManager Data1 = new ResManager();

            Data1.LoadRes("data.res");
            Data1.SaveAllDecryptRes();
            Data1.EmptyMemory();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (creditpage == null)
            {
                creditpage = new Credit();
                creditpage.Show();
                creditpage.FormClosed += delegate { creditpage = null; };
            }
            else
            {
                creditpage.Activate();
            }
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
            resultbox.Text = "/nofreeze " + playername.Text;
        }

        private void mute_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/MUTE " + playername.Text + " " + hourmute.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/teleport " + playername.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/summon " + playername.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/out " + playername.Text;
        }

        private void ud_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/undying ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/noundying ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/undying2 ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/inv ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/noinv ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultbox.Text = "/getgold " + penyaqt.Text;
        }
    }

}
