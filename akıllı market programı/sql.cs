using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace akıllı_market_programı
{
    class sql
    {
        public static SqlConnection baglan()
        {
            SqlConnection baglan1=new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Market.mdf;Integrated Security=True");
            baglan1.Open();
            return baglan1;
        }
    }
}
