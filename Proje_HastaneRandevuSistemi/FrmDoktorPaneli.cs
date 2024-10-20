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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            TabloYukle();
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();
        }
        public void TabloYukle()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@k1,@k2,@k3,@k4,@k5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txtAd.Text);
            komut.Parameters.AddWithValue("@k2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@k3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@k4", msbTC.Text);
            komut.Parameters.AddWithValue("@k5", msbSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TabloYukle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçim = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[seçim].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[seçim].Cells[3].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[seçim].Cells[4].Value.ToString();
            msbSifre.Text = dataGridView1.Rows[seçim].Cells[5].Value.ToString();
            msbTC.Text = dataGridView1.Rows[seçim].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
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
            TabloYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Delete From Tbl_Doktorlar where DoktorTC=@k1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@k1", msbTC.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            TabloYukle();
        }
    }
}
