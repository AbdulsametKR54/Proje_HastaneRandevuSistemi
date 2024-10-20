using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_HastaneRandevuSistemi
{
    public partial class FrmDoktorBilgiGüncelle : Form
    {
        public FrmDoktorBilgiGüncelle(string Tc)
        {
            InitializeComponent();
            tc = Tc;
        }

        public string tc;
        sqlBaglanti bgl = new sqlBaglanti();
        private void FrmDoktorBilgiGüncelle_Load(object sender, EventArgs e)
        {
            msbTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msbTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[2].ToString();
                txtSoyad.Text = dr[3].ToString();
                cmbBrans.Text = dr[4].ToString();
                msbSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

            //Branşlar
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@k1,DoktorSoyad=@k2,DoktorBrans=@k3,DoktorSifre=@k5 where DoktorTC=@k4", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", txtAd.Text);
            komut2.Parameters.AddWithValue("@k2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@k3", cmbBrans.Text);
            komut2.Parameters.AddWithValue("@k4", msbTC.Text);
            komut2.Parameters.AddWithValue("@k5", msbSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
