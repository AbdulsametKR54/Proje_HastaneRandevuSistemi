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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay(string tc)
        {
            InitializeComponent();
            TC = tc.ToString();
        }
        public string TC;
        sqlBaglanti bgl = new sqlBaglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            //SekreterDetay
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@l1", bgl.baglanti());
            komut.Parameters.AddWithValue("@l1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşlar
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            //Doktor
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar', DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            bgl.baglanti().Close();

            //Branş Combobox Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();


        }
        private void btnDoktor_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void btnBrans_Click(object sender, EventArgs e)
        {
            Form frm = new FrmBransPaneli();
            frm.Show();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            Form frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@l1,@l2,@l3,@l4)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@l1", msbTarih.Text);
            komut3.Parameters.AddWithValue("@l2", msbSaat.Text);
            komut3.Parameters.AddWithValue("@l3", cmbBrans.Text);
            komut3.Parameters.AddWithValue("@l4", cmbDoktor.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturulmuştur");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            //Doktorları combobox Aktarma
            SqlCommand komut3 = new SqlCommand("Select (DoktorAd + ' ' + DoktorSoyad) From Tbl_Doktorlar where DoktorBrans=@l1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@l1", cmbBrans.Text);
            SqlDataReader d3 = komut3.ExecuteReader();
            while (d3.Read())
            {
                cmbDoktor.Items.Add(d3[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@d1)", bgl.baglanti());
            komut3.Parameters.AddWithValue("@d1", rctDuyuru.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
    }
}