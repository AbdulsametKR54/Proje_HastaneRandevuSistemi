using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_HastaneRandevuSistemi
{
    internal class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            // Şifreleme devre dışı bırakıldı
            SqlConnection baglan = new SqlConnection("Data Source=AbdulsametKR\\SQLEXPRESS;Initial Catalog=HastaneDatabase;Integrated Security=True;Encrypt=False");
            baglan.Open();
            return baglan;
        }
    }
}
