using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Json
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\vaduv\Desktop\Imagini\right-arrow.png");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\vaduv\Desktop\Imagini\down-arrow.png");
            }
        }

        private void membriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Membrii m = new Membrii();
            m.Show();
        }

        private void antrenoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Antrenori a = new Antrenori();
            a.Show();
        }

        private void adaugaAbonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdaugaAbonament aa = new AdaugaAbonament();
            aa.Show();
        }

        private void echipamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Echipament ec = new Echipament();
            ec.Show();
        }

        private void cautaMembriiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CautaMembrii cm = new CautaMembrii();
            cm.Show();
        }

        private void produseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produse pr = new Produse();
            pr.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Log Out! Confirm?", "LOG OUT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Form1 frm = new Form1();
                this.Hide();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
