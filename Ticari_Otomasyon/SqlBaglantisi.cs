using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Bağlantı için ekle 
namespace Ticari_Otomasyon
{
     class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan=new SqlConnection(@"Data Source = DESKTOP-FA9OISU;Initial Catalog = TicariOtomasyon; Integrated Security = True");
            baglan.Open();
            return baglan;
        }
    }
}
