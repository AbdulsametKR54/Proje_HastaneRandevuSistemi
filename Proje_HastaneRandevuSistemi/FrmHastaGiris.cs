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
    public partial class FrmHastaGiris : Form
    {
        sqlBaglanti bgl = new sqlBaglanti();
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void HastaGirisForm_Load(object sender, EventArgs e)
        {
            msbTC.Focus();
        }

        private void linklKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FrmHastaKayıt();
            frm.Show();
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hasta where HastaTC=@k1 and HastaSifre=@k2", bgl.baglanti());
            komut.Parameters.AddWithValue("@k1", msbTC.Text);
            komut.Parameters.AddWithValue("@k2", msbSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form frm = new FrmHastaDetay(msbTC.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre girişi.");
            }
            bgl.baglanti().Close();

        }
    }
}
