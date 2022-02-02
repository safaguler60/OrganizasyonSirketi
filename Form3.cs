using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalÖdev
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Form5 form5 = new Form5();
        private void button2_Click(object sender, EventArgs e)
        {
            form5.Show();
        }
        Form4 form4 = new Form4();
        private void button1_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Form6 form6 = new Form6();
        private void button3_Click(object sender, EventArgs e)
        {
            form6.Show();
        }
    }
}
