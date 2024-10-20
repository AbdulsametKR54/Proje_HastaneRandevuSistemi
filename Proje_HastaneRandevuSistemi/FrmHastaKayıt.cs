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

namespace Proje_HastaneRandevuSistemi
{
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        private void FrmHastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnKayıtYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hasta (HastaTC,HastaAd,HastaSoyad,HastaTelefon,HastaSifre,HastaCinsiyet) values (@k1,@k2,@k3,@k4,@k5,@k6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", msbTC.Text);
            komut.Parameters.AddWithValue("@k2", txtAd.Text);
            komut.Parameters.AddWithValue("@k3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@k4", msbTelefon.Text);
            komut.Parameters.AddWithValue("@k5", txtSifre.Text);
            komut.Parameters.AddWithValue("@k6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Kaydedilmiştir. Şifreniz: " + txtSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
