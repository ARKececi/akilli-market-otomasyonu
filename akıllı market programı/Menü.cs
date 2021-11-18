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
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        public static string veri;
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Giris frm1 = (Giris)Application.OpenForms["Form1"];
            
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void kişiBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = false;
        }

        private void ürünSayılarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
            
                
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet5.calisan' table. You can move, or remove it, as needed.
            this.calisanTableAdapter.Fill(this.marketDataSet5.calisan);
            // TODO: This line of code loads data into the 'marketDataSet.Kayit' table. You can move, or remove it, as needed.
            this.kayitTableAdapter.Fill(this.marketDataSet.Kayit);
            label8.Visible = false;
            textBox6.Visible = false;
            button11.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            
            if (Form2.gonderilecekveri == "Müşteri Girişi")
            {
                
                
                kişiBilgileriToolStripMenuItem.Visible = false;
                piyasaBilgileriToolStripMenuItem.Visible = false;
                maaşBilgileriToolStripMenuItem.Visible = false;
                
            }
            if (Form2.gonderilecekveri == "Personel Girişi")
            {
                piyasaBilgileriToolStripMenuItem.Visible = false;
                kişiBilgileriToolStripMenuItem.Visible = false;
                
                
                
            }
            if (Form2.gonderilecekveri == "Alım Satım Müdürü Girişi")
            {
                kişiBilgileriToolStripMenuItem.Visible = false;
                
            }

            if (Giris.gonderilecekveri == "Genel Müdür Girişi")
            {
                label8.Visible = true;
                button11.Visible = true;
                textBox6.Visible = true;
            }
        
        
        
        }

        

        private void yeniÜrünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünPlatformu f = new ÜrünPlatformu();
            f.Show();
            
            
            
            
            
           
        }

        private void menüToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ürünGrafikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

       
       

        private void müşteriBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
        }

       

        private void piyasaBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Bu menümüz şu an aktif değildir !!!", "Dikkat", MessageBoxButtons.OK);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text=dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox8.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            string komut = "UPDATE Kayit set Sifre=@P1,Eposta=@P2,Ad=@P3,Soyad=@P4 where ID=@P5";
            SqlCommand kmt = new SqlCommand(komut,baglan);
            kmt.Parameters.AddWithValue("@P1", textBox2.Text);
            kmt.Parameters.AddWithValue("@P2", textBox3.Text);
            kmt.Parameters.AddWithValue("@P3", textBox8.Text);
            kmt.Parameters.AddWithValue("@P4", textBox7.Text);
            kmt.Parameters.AddWithValue("@P5", textBox1.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
            

        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            string komut = "DELETE FROM Kayit where ID=@P1";
            SqlCommand ahmet = new SqlCommand(komut,baglan);
            ahmet.Parameters.AddWithValue("@P1",textBox1.Text);
            ahmet.ExecuteNonQuery();
            baglan.Close();
            this.kayitTableAdapter.Fill(this.marketDataSet.Kayit);
        }

        private void ürünAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜrünPlatformu f =new ÜrünPlatformu();
            f.Show();
        }

        private void maaşBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e) 
        {
            SqlConnection baglan = sql.baglan();
            string komut = "UPDATE calisan set maaş=@P1 where Id=@P2";
            SqlCommand kmt = new SqlCommand(komut, baglan);
            kmt.Parameters.AddWithValue("@P2", textBox5.Text);
            kmt.Parameters.AddWithValue("@P1", textBox6.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
            this.calisanTableAdapter.Fill(this.marketDataSet5.calisan);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            DataTable ur = new DataTable();
            string urunum = "'" + textBox5.Text.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter("select * from calisan where Id=" + urunum, baglan);
            da.Fill(ur);
            dataGridView2.DataSource = ur;
            baglan.Close();
            dataGridView2.DataSource = ur;
            if(textBox9.Text!="")
            {
                
                DataTable ad = new DataTable();
                string adım = "'" + textBox5.Text.ToString() + "'";
                SqlDataAdapter kaf = new SqlDataAdapter("select * from calisan where Id=" + adım, baglan);
                da.Fill(ad);
                dataGridView2.DataSource = ad;
                baglan.Close();
                dataGridView2.DataSource = ad;
            }
            if(textBox4.Text!="")
            {
                
                DataTable soy = new DataTable();
                string soyadım = "'" + textBox5.Text.ToString() + "'";
                SqlDataAdapter lam = new SqlDataAdapter("select * from calisan where Id=" + soyadım, baglan);
                da.Fill(soy);
                dataGridView2.DataSource = soy;
                baglan.Close();
                dataGridView2.DataSource = soy;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veri = "yap";
            
        }
    }
}
