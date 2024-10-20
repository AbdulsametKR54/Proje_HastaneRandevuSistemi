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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            TabloYukle();
        }
        public void TabloYukle()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@k1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", txtAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            TabloYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Delete From Tbl_Branslar where BransId=@k1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@k1", txtId.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            TabloYukle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçim = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[seçim].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[seçim].Cells[1].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut5 = new SqlCommand("Update Tbl_Branslar Set BransAd=@k1 where BransId=@k4", bgl.baglanti());
            komut5.Parameters.AddWithValue("@k1",txtAd.Text);
            komut5.Parameters.AddWithValue("@k4",txtId.Text);
            komut5.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            TabloYukle();
        }
    }
}
