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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top = label1.Top + 1;
          
            if (label1.Top % 5 == 0)
            {
                label1.ForeColor = Color.White;
            }else
            {
                label1.ForeColor = Color.Black;
            }
            
        }
    }
}
