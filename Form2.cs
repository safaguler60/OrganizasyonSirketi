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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        Form3 form3 = new Form3();
        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici, sifre;
            int sifre2;
            kullanici = textBox1.Text;
            sifre = textBox2.Text;
            if (((kullanici=="safa") && (sifre=="1907"))||((kullanici=="admin")&&(sifre=="admin")))
            {
                this.Hide();
                form3.Show();
            }else
            {
                MessageBox.Show("Hatalı Şifre!"+"\n" + "Lütfen tekrar giriniz");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
