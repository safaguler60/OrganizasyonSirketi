using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalÖdev
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

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

       

     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
        }
        int sayac = 0;
        Form2 form2 = new Form2();
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac=sayac+5;
            progressBar1.Value = sayac;
            if (progressBar1.Value ==100)
            {
                timer1.Stop();
                this.Hide();
                form2.Show();
            }
        }
    }
}
