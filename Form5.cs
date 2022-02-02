using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FinalÖdev
{
    public partial class Form5 : Form
    {
        OleDbConnection Veritabani_Baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=student.accdb");
        OleDbDataAdapter Veri_Adaptor;
        DataSet Veri_Seti;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        public Form5()
        {
            InitializeComponent();
        }
        void Veri_Listele()
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from dügün", Veritabani_Baglanti);
            Veri_Seti = new DataSet();
            Veritabani_Baglanti.Open();
            Veri_Adaptor.Fill(Veri_Seti, "dügün");
            dataGridView1.DataSource = Veri_Seti.Tables["dügün"];

            Veritabani_Baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Listele();
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            Veritabani_Baglanti.Open();

            Veri_Komutu.Connection = Veritabani_Baglanti;
            Veri_Komutu.CommandText = "Insert into dügün (TC_Kimlik, Telefon_No, Ad_Soyad, Kac_Kişilik) values (" + "'" + Convert.ToDouble(textBox1.Text) + "','" + Convert.ToDouble(textBox2.Text)+"','" + textBox3.Text + "','" + Convert.ToDouble(textBox4.Text) + "' ) ";

            Veri_Komutu.ExecuteNonQuery();
            
            Veritabani_Baglanti.Close();
            Veri_Listele();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Veri_Komutu = new OleDbCommand();
            Veritabani_Baglanti.Open();

            Veri_Komutu.Connection = Veritabani_Baglanti;
            Veri_Komutu.CommandText = "Update dügün Set TC_Kimlik='"
                + Convert.ToDouble(textBox1.Text)
                + "' ,Telefon_No='"
                + Convert.ToDouble(textBox2.Text)
                + "' ,Ad_Soyad='"
                + textBox3.Text
                + "', Kac_Kişilik='"
                + Convert.ToDouble(textBox4.Text)
                + "' where TC_Kimlik='"
                + Convert.ToDouble(textBox1.Text)
                + "' ";

            Veri_Komutu.ExecuteNonQuery();

            Veritabani_Baglanti.Close();
            Veri_Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
