﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavicKarloTimerKomponenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            labelVrijeme.Text = DateTime.Now.ToShortTimeString();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 licenca = new Form2();
            licenca.Show();
        }
    }
}
