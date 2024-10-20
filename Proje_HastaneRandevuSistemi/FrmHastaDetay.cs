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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay(string HastaTC)
        {
            InitializeComponent();
            tc = HastaTC;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FrmHastaBilgiGuncelle(tc);
            frm.Show();
        }
        public string tc;
        sqlBaglanti bgl = new sqlBaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;
            //Hasta Detay
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hasta where HastaTC=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Rapor Geçmişi
            RaporGecmis();

            //Branşlar
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }
        public void RaporGecmis()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC=" + lblTC.Text, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            //Doktorlar
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@k1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@k1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'" + "and RandevuDoktor='" + cmbDoktor.Text + "' and RandevuDurum=0", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtRandevuId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut7 = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@l1,HastaSikayet=@l2 where RandevuId=@l3", bgl.baglanti());
            komut7.Parameters.AddWithValue("@l1", lblTC.Text);
            komut7.Parameters.AddWithValue("@l2",rtbSikayet.Text);
            komut7.Parameters.AddWithValue("@l3", txtRandevuId.Text);
            komut7.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            RaporGecmis();
        }
    }
}
