namespace Proje_HastaneRandevuSistemi
{
    partial class FrmHastaBilgiGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgiGuncelle));
            btnGüncelle = new Button();
            cmbCinsiyet = new ComboBox();
            txtSifre = new TextBox();
            msbTelefon = new MaskedTextBox();
            txtSoyad = new TextBox();
            msbTC = new MaskedTextBox();
            txtAd = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.FromArgb(255, 224, 192);
            btnGüncelle.Location = new Point(180, 378);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(197, 42);
            btnGüncelle.TabIndex = 27;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(180, 332);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(197, 40);
            cmbCinsiyet.TabIndex = 26;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(180, 286);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(197, 40);
            txtSifre.TabIndex = 25;
            // 
            // msbTelefon
            // 
            msbTelefon.Location = new Point(180, 240);
            msbTelefon.Mask = "(999) 000-0000";
            msbTelefon.Name = "msbTelefon";
            msbTelefon.Size = new Size(197, 40);
            msbTelefon.TabIndex = 24;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(180, 185);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(197, 40);
            txtSoyad.TabIndex = 23;
            // 
            // msbTC
            // 
            msbTC.Location = new Point(180, 90);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 21;
            msbTC.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            txtAd.Location = new Point(180, 136);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(197, 40);
            txtAd.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(64, 340);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 20;
            label7.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 289);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 19;
            label6.Text = "Şifre:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 243);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 18;
            label5.Text = "Telefon No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 185);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 17;
            label4.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 136);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 16;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 90);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 15;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(19, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(469, 41);
            label1.TabIndex = 14;
            label1.Text = "Hasta Bilgi Güncelleme Sayfası";
            // 
            // FrmHastaBilgiGuncelle
            // 
            AcceptButton = btnGüncelle;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(503, 447);
            Controls.Add(btnGüncelle);
            Controls.Add(cmbCinsiyet);
            Controls.Add(txtSifre);
            Controls.Add(msbTelefon);
            Controls.Add(txtSoyad);
            Controls.Add(msbTC);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaBilgiGuncelle";
            Text = "FrmBilgiGuncelle";
            Load += FrmHastaBilgiGuncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGüncelle;
        private ComboBox cmbCinsiyet;
        private TextBox txtSifre;
        private MaskedTextBox msbTelefon;
        private TextBox txtSoyad;
        private MaskedTextBox msbTC;
        private TextBox txtAd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}