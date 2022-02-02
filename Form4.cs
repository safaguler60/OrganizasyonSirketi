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
    public partial class Form4 : Form
    {
        OleDbConnection Veritabani_Baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=student.accdb");
        OleDbDataAdapter Veri_Adaptor;
        DataSet Veri_Seti;
        OleDbCommand Veri_Komutu;
        OleDbDataReader Veri_Oku;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veri_Adaptor = new OleDbDataAdapter("Select * from konser", Veritabani_Baglanti);
            Veri_Seti = new DataSet();
            Veritabani_Baglanti.Open();
            Veri_Adaptor.Fill(Veri_Seti, "konser");
            dataGridView1.DataSource = Veri_Seti.Tables["konser"];

            Veritabani_Baglanti.Close();
        }
    }
}
