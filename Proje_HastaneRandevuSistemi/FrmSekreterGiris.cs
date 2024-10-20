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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl= new sqlBaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Giriş Kontrol
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@l1 and SekreterSifre=@l2", bgl.baglanti());
            komut.Parameters.AddWithValue("@l1", msbTC.Text);
            komut.Parameters.AddWithValue("@l2", msbSifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if (dr.Read())
            {
                Form frm = new FrmSekreterDetay(msbTC.Text);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre girişi.");
            }
            bgl.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
