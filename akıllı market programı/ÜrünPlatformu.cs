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
    public partial class ÜrünPlatformu : Form
    {
        public ÜrünPlatformu()
        {
            InitializeComponent();
        }

        private void ÜrünPlatformu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet4.ürünler' table. You can move, or remove it, as needed.
            this.ürünlerTableAdapter.Fill(this.marketDataSet4.ürünler);
            // TODO: This line of code loads data into the 'marketDataSet3.urunler' table. You can move, or remove it, as needed.
            
            this.fiyatlandırmaTableAdapter.Fill(this.marketDataSet2.fiyatlandırma);
            // TODO: This line of code loads data into the 'marketDataSet1.urunler' table. You can move, or remove it, as needed.
            
            Giris frm1 = (Giris)Application.OpenForms["Form1"];
            groupBox2.Visible = false;
            groupBox1.Visible = false;
            if (Giris.gonderilecekveri == "Alım Satım Müdürü Girişi")
            {
                groupBox1.Visible = true;
                groupBox2.Visible = true;
            }

            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            string komut = "INSERT INTO ürünler (urun,fiyat,tane)VALUES(@P1,@P2,@P3)";
            SqlCommand kmt = new SqlCommand(komut, baglan);
            kmt.Parameters.AddWithValue("@P1", textBox4.Text);
            kmt.Parameters.AddWithValue("@P2", textBox5.Text);
            kmt.Parameters.AddWithValue("@P3", textBox3.Text);            
            kmt.ExecuteNonQuery();
            baglan.Close();
            this.ürünlerTableAdapter.Fill(this.marketDataSet4.ürünler);
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            string komut = "UPDATE ürünler set fiyat=@P2,tane=@P3 where urun=@P4";
            SqlCommand kmt = new SqlCommand(komut, baglan);
            kmt.Parameters.AddWithValue("@P2", textBox2.Text);
            kmt.Parameters.AddWithValue("@P3", textBox6.Text);
            kmt.Parameters.AddWithValue("@P4", textBox1.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
            this.ürünlerTableAdapter.Fill(this.marketDataSet4.ürünler);
            textBox2.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            DataTable ur = new DataTable();
            string urunum = "'"+textBox1.Text.ToString()+"'";
            SqlDataAdapter da = new SqlDataAdapter("select * from ürünler where urun="+urunum,baglan);
            da.Fill(ur);
            dataGridView1.DataSource = ur;
            baglan.Close();

            
        }
    }
}
