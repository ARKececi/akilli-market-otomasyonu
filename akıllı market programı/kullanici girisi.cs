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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static string gonderilecekveri;
        private void label3_Click(object sender, EventArgs e)
        {
            Giris frm1 = (Giris)Application.OpenForms["Giris"];

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(Giris.gonderilecekveri=="Müşteri Girişi")
                label3.Text = Giris.gonderilecekveri;
            if (Giris.gonderilecekveri == "Personel Girişi")
                label3.Text = Giris.gonderilecekveri;
            if (Giris.gonderilecekveri == "Alım Satım Müdürü Girişi")
                label3.Text = Giris.gonderilecekveri;
            if (Giris.gonderilecekveri == "Genel Müdür Girişi")
                label3.Text = Giris.gonderilecekveri;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Giris s = new Giris();
            s.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            if (Giris.gonderilecekveri == "Müşteri Girişi")
            {
                SqlConnection baglan = sql.baglan();
                SqlCommand komut = new SqlCommand("select * from Kayit where ID=@P1 and Sifre=@P2",baglan);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.Parameters.AddWithValue("@P2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş basarili");
                    gonderilecekveri = label3.Text;
                    Menü f = new Menü();
                    f.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Giriş basarisiz");
                baglan.Close();
                
            }
            if (Giris.gonderilecekveri == "Personel Girişi")
            {
                SqlConnection baglan = sql.baglan();
                SqlCommand komut = new SqlCommand("select * from gorevligirisi where Id=@P1 and şifre=@P2", baglan);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.Parameters.AddWithValue("@P2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("basarili");
                    gonderilecekveri = label3.Text;
                    Menü f = new Menü();
                    f.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("basarisiz");
                baglan.Close();
            }
            if (Giris.gonderilecekveri == "Alım Satım Müdürü Girişi")
            {
                SqlConnection baglan = sql.baglan();
                SqlCommand komut = new SqlCommand("select * from ASMüdürü where Id=@P1 and şifre=@P2", baglan);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.Parameters.AddWithValue("@P2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("basarili");
                    gonderilecekveri = label3.Text;
                    Menü f = new Menü();
                    f.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("basarisiz");
                baglan.Close();
            }
            if (Giris.gonderilecekveri == "Genel Müdür Girişi")
            {
                SqlConnection baglan = sql.baglan();
                SqlCommand komut = new SqlCommand("select * from genelmüdür where Id=@P1 and sifre=@P2", baglan);
                komut.Parameters.AddWithValue("@P1", textBox1.Text);
                komut.Parameters.AddWithValue("@P2", textBox2.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("basarili");
                    gonderilecekveri = label3.Text;
                    Menü f = new Menü();
                    f.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("basarisiz");
                baglan.Close();
            }
            
            
            


        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sifre_sıfırla f = new Sifre_sıfırla();
            f.Show();
            
        }
    }
}
