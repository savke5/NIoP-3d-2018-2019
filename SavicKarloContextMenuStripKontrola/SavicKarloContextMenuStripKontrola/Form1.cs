using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavicKarloContextMenuStripKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lijevoNaDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;


        }

        private void desnoNaLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 licenca = new Form2();
            licenca.Show();
        }
    }
}
