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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl=new sqlBaglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@l1 and DoktorSifre=@l2", bgl.baglanti());
            komut.Parameters.AddWithValue("@l1", msbTC.Text);
            komut.Parameters.AddWithValue("@l2", msbSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form frm = new FrmDoktorDetay(msbTC.Text);
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
