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
    public partial class FrmHastaBilgiGuncelle : Form
    {
        public FrmHastaBilgiGuncelle(string TC)
        {
            InitializeComponent();
            TCNo = TC;
        }

        sqlBaglanti bgl = new sqlBaglanti();
        public string TCNo;
        private void FrmHastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            msbTC.Focus();
            msbTC.Text = TCNo;

            //Hasta Bilgileri Aktarma
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hasta where HastaTC=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", msbTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[2].ToString();
                txtSoyad.Text = dr[3].ToString();
                msbTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hasta set HastaAd=@z1, HastaSoyad=@z2,HastaTelefon=@z3,HastaSifre=@z4,HastaCinsiyet=@z5 where HastaTC=@z6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@z6", msbTC.Text);
            komut2.Parameters.AddWithValue("@z1", txtAd.Text);
            komut2.Parameters.AddWithValue("@z2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@z3", msbTelefon.Text);
            komut2.Parameters.AddWithValue("@z4", txtSifre.Text);
            komut2.Parameters.AddWithValue("@z5", cmbCinsiyet.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
