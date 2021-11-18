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

namespace akıllı_market_programı
{
    
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        
        string kullanıcı, Şifre;
        public static string gonderilecekveri;
        private void button1_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button1.Text + " Girişi";
            Form2 goster = new Form2();
            goster.Show();
            this.Visible = false;
            
            
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button2.Text + " Girişi";
            Form2 goster = new Form2();
            goster.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button3.Text + " Girişi";
            Form2 goster = new Form2();
            goster.Show();
            this.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gonderilecekveri = button4.Text + " Girişi";
            Form2 goster = new Form2();
            goster.Show();
            this.Visible = false;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak istediğinize emin msiniz ?", "Uyarı", MessageBoxButtons.OKCancel);
            if (sonuc == DialogResult.OK)
                Giris.ActiveForm.Close();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayit f = new kayit();
            f.Show();
        }
    }
}
