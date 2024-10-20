namespace Proje_HastaneRandevuSistemi
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            groupBox1 = new GroupBox();
            btnGüncelle = new Button();
            lblAdSoyad = new Label();
            lblTC = new Label();
            txtAdSoyad = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnDuyuruOlustur = new Button();
            rctDuyuru = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnRandevu = new Button();
            btnBrans = new Button();
            btnDoktor = new Button();
            groupBox5 = new GroupBox();
            btnKaydet = new Button();
            msbTC = new MaskedTextBox();
            cmbDoktor = new ComboBox();
            cmbBrans = new ComboBox();
            msbSaat = new MaskedTextBox();
            msbTarih = new MaskedTextBox();
            txtId = new TextBox();
            cbDurum = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox6 = new GroupBox();
            dataGridView2 = new DataGridView();
            btnDuyurular = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(9, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 153);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sekreter Detay";
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(63, 108);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(251, 39);
            btnGüncelle.TabIndex = 4;
            btnGüncelle.Text = "Bilgilerini Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Corbel", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblAdSoyad.Location = new Point(206, 77);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(52, 28);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "Null";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Corbel", 13.8F, FontStyle.Bold | FontStyle.Italic);
            lblTC.Location = new Point(206, 43);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(52, 28);
            lblTC.TabIndex = 2;
            lblTC.Text = "Null";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.AutoSize = true;
            txtAdSoyad.Location = new Point(63, 77);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(137, 32);
            txtAdSoyad.TabIndex = 1;
            txtAdSoyad.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 40);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 0;
            label2.Text = "TC Kimlik No:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDuyuruOlustur);
            groupBox2.Controls.Add(rctDuyuru);
            groupBox2.Location = new Point(9, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 293);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuruOlustur
            // 
            btnDuyuruOlustur.Location = new Point(80, 244);
            btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            btnDuyuruOlustur.Size = new Size(178, 43);
            btnDuyuruOlustur.TabIndex = 6;
            btnDuyuruOlustur.Text = "Oluştur";
            btnDuyuruOlustur.UseVisualStyleBackColor = true;
            btnDuyuruOlustur.Click += btnDuyuruOlustur_Click;
            // 
            // rctDuyuru
            // 
            rctDuyuru.Location = new Point(3, 36);
            rctDuyuru.Name = "rctDuyuru";
            rctDuyuru.Size = new Size(354, 202);
            rctDuyuru.TabIndex = 0;
            rctDuyuru.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(450, 16);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(328, 41);
            label1.TabIndex = 12;
            label1.Text = "Sekreter Bilgi Sayfası";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(882, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 132);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(757, 157);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(341, 209);
            groupBox4.TabIndex = 14;
            groupBox4.TabStop = false;
            groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(335, 170);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDuyurular);
            groupBox3.Controls.Add(btnRandevu);
            groupBox3.Controls.Add(btnBrans);
            groupBox3.Controls.Add(btnDoktor);
            groupBox3.Location = new Point(12, 485);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(736, 94);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hızlı Erişim";
            // 
            // btnRandevu
            // 
            btnRandevu.Location = new Point(374, 39);
            btnRandevu.Name = "btnRandevu";
            btnRandevu.Size = new Size(178, 43);
            btnRandevu.TabIndex = 7;
            btnRandevu.Text = "Randevu Liste";
            btnRandevu.UseVisualStyleBackColor = true;
            btnRandevu.Click += btnRandevu_Click;
            // 
            // btnBrans
            // 
            btnBrans.Location = new Point(190, 39);
            btnBrans.Name = "btnBrans";
            btnBrans.Size = new Size(178, 43);
            btnBrans.TabIndex = 6;
            btnBrans.Text = "Branş Paneli";
            btnBrans.UseVisualStyleBackColor = true;
            btnBrans.Click += btnBrans_Click;
            // 
            // btnDoktor
            // 
            btnDoktor.Location = new Point(6, 39);
            btnDoktor.Name = "btnDoktor";
            btnDoktor.Size = new Size(178, 43);
            btnDoktor.TabIndex = 5;
            btnDoktor.Text = "Doktor Paneli";
            btnDoktor.UseVisualStyleBackColor = true;
            btnDoktor.Click += btnDoktor_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnKaydet);
            groupBox5.Controls.Add(msbTC);
            groupBox5.Controls.Add(cmbDoktor);
            groupBox5.Controls.Add(cmbBrans);
            groupBox5.Controls.Add(msbSaat);
            groupBox5.Controls.Add(msbTarih);
            groupBox5.Controls.Add(txtId);
            groupBox5.Controls.Add(cbDurum);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(378, 60);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(373, 435);
            groupBox5.TabIndex = 16;
            groupBox5.TabStop = false;
            groupBox5.Text = "Randevu Paneli";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(117, 375);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(197, 43);
            btnKaydet.TabIndex = 7;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // msbTC
            // 
            msbTC.Location = new Point(117, 287);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 13;
            msbTC.ValidatingType = typeof(int);
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(117, 236);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(197, 40);
            cmbDoktor.TabIndex = 12;
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(117, 190);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(197, 40);
            cmbBrans.TabIndex = 11;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // msbSaat
            // 
            msbSaat.Location = new Point(117, 144);
            msbSaat.Mask = "00:00";
            msbSaat.Name = "msbSaat";
            msbSaat.Size = new Size(197, 40);
            msbSaat.TabIndex = 10;
            msbSaat.ValidatingType = typeof(DateTime);
            // 
            // msbTarih
            // 
            msbTarih.Location = new Point(117, 92);
            msbTarih.Mask = "00/00/0000";
            msbTarih.Name = "msbTarih";
            msbTarih.Size = new Size(197, 40);
            msbTarih.TabIndex = 9;
            msbTarih.ValidatingType = typeof(DateTime);
            // 
            // txtId
            // 
            txtId.Location = new Point(117, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(197, 40);
            txtId.TabIndex = 8;
            // 
            // cbDurum
            // 
            cbDurum.AutoSize = true;
            cbDurum.Location = new Point(147, 333);
            cbDurum.Name = "cbDurum";
            cbDurum.Size = new Size(106, 36);
            cbDurum.TabIndex = 7;
            cbDurum.Text = "Durum";
            cbDurum.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 290);
            label9.Name = "label9";
            label9.Size = new Size(54, 32);
            label9.TabIndex = 5;
            label9.Text = "TC:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 239);
            label8.Name = "label8";
            label8.Size = new Size(99, 32);
            label8.TabIndex = 4;
            label8.Text = "Doktor:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 198);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 3;
            label7.Text = "Branş:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 147);
            label6.Name = "label6";
            label6.Size = new Size(77, 32);
            label6.TabIndex = 2;
            label6.Text = "Saat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 95);
            label5.Name = "label5";
            label5.Size = new Size(83, 32);
            label5.TabIndex = 1;
            label5.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 49);
            label4.Name = "label4";
            label4.Size = new Size(51, 32);
            label4.TabIndex = 0;
            label4.Text = "Id:";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dataGridView2);
            groupBox6.Location = new Point(757, 372);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(341, 208);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(335, 169);
            dataGridView2.TabIndex = 0;
            // 
            // btnDuyurular
            // 
            btnDuyurular.Location = new Point(558, 39);
            btnDuyurular.Name = "btnDuyurular";
            btnDuyurular.Size = new Size(172, 43);
            btnDuyurular.TabIndex = 8;
            btnDuyurular.Text = "Duyurular";
            btnDuyurular.UseVisualStyleBackColor = true;
            btnDuyurular.Click += btnDuyurular_Click;
            // 
            // FrmSekreterDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1108, 591);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmSekreterDetay";
            Text = "Sekreter Detay";
            Load += FrmSekreterDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnGüncelle;
        private Label lblAdSoyad;
        private Label lblTC;
        private Label txtAdSoyad;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnDuyuruOlustur;
        private RichTextBox rctDuyuru;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private GroupBox groupBox3;
        private Button btnBrans;
        private Button btnDoktor;
        private GroupBox groupBox5;
        private MaskedTextBox msbTarih;
        private TextBox txtId;
        private CheckBox cbDurum;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox cmbBrans;
        private MaskedTextBox msbSaat;
        private ComboBox cmbDoktor;
        private MaskedTextBox msbTC;
        private Button btnKaydet;
        private GroupBox groupBox6;
        private DataGridView dataGridView2;
        private Button btnRandevu;
        private Button btnDuyurular;
    }
}