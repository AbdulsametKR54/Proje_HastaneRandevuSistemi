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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay(string tc)
        {
            InitializeComponent();
            TC = tc;
        }
        string TC;
        sqlBaglanti bgl = new sqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDoktorBilgiGüncelle(TC);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDuyurular();
            frm.Show();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@k1", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Tablo
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rctRandevuDetay.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
