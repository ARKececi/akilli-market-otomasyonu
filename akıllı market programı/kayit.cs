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
using System.Data.OleDb;

namespace akıllı_market_programı
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        
        
        
        private void kayit_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = sql.baglan();
            string komut = "INSERT INTO Kayit (ID,Sifre,Eposta,Ad,Soyad)VALUES(@P1,@P2,@P3,@P4,@P5)";
            SqlCommand kmt = new SqlCommand(komut,baglan);
            kmt.Parameters.AddWithValue("@P1", textBox1.Text);
            kmt.Parameters.AddWithValue("@P2", textBox2.Text);
            kmt.Parameters.AddWithValue("@P3", textBox4.Text);
            kmt.Parameters.AddWithValue("@P4", textBox5.Text);
            kmt.Parameters.AddWithValue("@P5", textBox6.Text);
            kmt.ExecuteNonQuery();
            baglan.Close();
           
                
                 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
