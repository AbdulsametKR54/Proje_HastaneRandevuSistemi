namespace Proje_HastaneRandevuSistemi
{
    partial class FrmDoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPaneli));
            groupBox5 = new GroupBox();
            msbSifre = new MaskedTextBox();
            btnSil = new Button();
            txtSoyad = new TextBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            label8 = new Label();
            msbTC = new MaskedTextBox();
            cmbBrans = new ComboBox();
            txtAd = new TextBox();
            label9 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(msbSifre);
            groupBox5.Controls.Add(btnSil);
            groupBox5.Controls.Add(txtSoyad);
            groupBox5.Controls.Add(btnGuncelle);
            groupBox5.Controls.Add(btnEkle);
            groupBox5.Controls.Add(label8);
            groupBox5.Controls.Add(msbTC);
            groupBox5.Controls.Add(cmbBrans);
            groupBox5.Controls.Add(txtAd);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label7);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(22, 59);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(326, 380);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Doktor Paneli";
            // 
            // msbSifre
            // 
            msbSifre.Location = new Point(117, 226);
            msbSifre.Mask = "00000000";
            msbSifre.Name = "msbSifre";
            msbSifre.Size = new Size(197, 40);
            msbSifre.TabIndex = 12;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.Location = new Point(216, 280);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(98, 43);
            btnSil.TabIndex = 14;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(117, 92);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(197, 40);
            txtSoyad.TabIndex = 9;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Bisque;
            btnGuncelle.Location = new Point(117, 329);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(197, 43);
            btnGuncelle.TabIndex = 15;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientInactiveCaption;
            btnEkle.Location = new Point(117, 280);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(93, 43);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 234);
            label8.Name = "label8";
            label8.Size = new Size(82, 32);
            label8.TabIndex = 4;
            label8.Text = "Şifre:";
            // 
            // msbTC
            // 
            msbTC.Location = new Point(117, 184);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 11;
            msbTC.ValidatingType = typeof(int);
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(117, 138);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(197, 40);
            cmbBrans.TabIndex = 10;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(117, 46);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(197, 40);
            txtAd.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 187);
            label9.Name = "label9";
            label9.Size = new Size(54, 32);
            label9.TabIndex = 5;
            label9.Text = "TC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 141);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 3;
            label7.Text = "Branş:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 95);
            label5.Name = "label5";
            label5.Size = new Size(92, 32);
            label5.TabIndex = 1;
            label5.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 49);
            label4.Name = "label4";
            label4.Size = new Size(55, 32);
            label4.TabIndex = 0;
            label4.Text = "Ad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 24);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 18;
            label1.Text = "Doktor Paneli";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(365, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(886, 362);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // FrmDoktorPaneli
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1263, 451);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox5);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorPaneli";
            Text = "FrmDoktorPaneli";
            Load += FrmDoktorPaneli_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private TextBox txtSoyad;
        private Button btnGuncelle;
        private Button btnEkle;
        private MaskedTextBox msbTC;
        private ComboBox cmbBrans;
        private TextBox txtAd;
        private Label label9;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label8;
        private Button btnSil;
        private Label label1;
        private DataGridView dataGridView1;
        private MaskedTextBox msbSifre;
    }
}