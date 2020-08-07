using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calcul_Buget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void miVenituri_Click(object sender, EventArgs e)
        {
            Form2 Venituri=new Form2(this);
            Venituri.Show();
        }

        private void miCheltuieli_Click(object sender, EventArgs e)
        {
            Form3 Cheltuieli = new Form3(this);
            Cheltuieli.Show();
        }

        private void balantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 Balanta = new Form4(this);
            Balanta.Show();
        }

        private void vexploatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 venituri_exploatare = new Form5(this);
            venituri_exploatare.Show();
        }

        private void vfinanciareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 venituri_financiare = new Form6(this);
            venituri_financiare.Show();
        }

        private void vextraordinareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 venituri_extraordinare = new Form7(this);
            venituri_extraordinare.Show();
        }

        private void cexploatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 cheltuieli_exploatare = new Form8(this);
            cheltuieli_exploatare.Show();
        }

        private void cfinanciareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 cheltuieli_financiare = new Form9(this);
            cheltuieli_financiare.Show();
        }

        private void cextraordinareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 cheltuieli_extraordinare = new Form10(this);
            cheltuieli_extraordinare.Show();
        }
    }
}
