using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace NuclearReactor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void reactor2StateLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Meltdown Imminetnt";
            reactor1StateLabel.BackColor = Color.Purple;
            reactor2StateLabel.BackColor = Color.Purple;
            
            Refresh();
            Thread.Sleep(500);

            reactor1StateLabel.BackColor = Color.Green;
            reactor2StateLabel.BackColor = Color.Green;

            Refresh();
            Thread.Sleep(500);

            reactor1StateLabel.BackColor = Color.Purple;
            reactor2StateLabel.BackColor = Color.Purple;

            Refresh();
            Thread.Sleep(500);

            reactor1StateLabel.BackColor = Color.Green;
            reactor2StateLabel.BackColor = Color.Green;

        }

    }
}

