namespace Proje_HastaneRandevuSistemi
{
    partial class FrmHastaKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayıt));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAd = new TextBox();
            msbTC = new MaskedTextBox();
            txtSoyad = new TextBox();
            msbTelefon = new MaskedTextBox();
            txtSifre = new TextBox();
            cmbCinsiyet = new ComboBox();
            btnKayıtYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(20, 23);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 41);
            label1.TabIndex = 0;
            label1.Text = "Hasta Kayıt Sayfası";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 92);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 1;
            label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(114, 138);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 2;
            label3.Text = "Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 187);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 3;
            label4.Text = "Soyad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 245);
            label5.Name = "label5";
            label5.Size = new Size(149, 32);
            label5.TabIndex = 4;
            label5.Text = "Telefon No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 291);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 5;
            label6.Text = "Şifre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 342);
            label7.Name = "label7";
            label7.Size = new Size(110, 32);
            label7.TabIndex = 6;
            label7.Text = "Cinsiyet:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(175, 138);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(197, 40);
            txtAd.TabIndex = 8;
            // 
            // msbTC
            // 
            msbTC.Location = new Point(175, 92);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 7;
            msbTC.ValidatingType = typeof(int);
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(175, 187);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(197, 40);
            txtSoyad.TabIndex = 9;
            // 
            // msbTelefon
            // 
            msbTelefon.Location = new Point(175, 242);
            msbTelefon.Mask = "(999) 000-0000";
            msbTelefon.Name = "msbTelefon";
            msbTelefon.Size = new Size(197, 40);
            msbTelefon.TabIndex = 10;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(175, 288);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(197, 40);
            txtSifre.TabIndex = 11;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.Location = new Point(175, 334);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(197, 40);
            cmbCinsiyet.TabIndex = 12;
            // 
            // btnKayıtYap
            // 
            btnKayıtYap.BackColor = Color.FromArgb(192, 255, 192);
            btnKayıtYap.Location = new Point(175, 380);
            btnKayıtYap.Name = "btnKayıtYap";
            btnKayıtYap.Size = new Size(197, 42);
            btnKayıtYap.TabIndex = 13;
            btnKayıtYap.Text = "Kayıt Yap";
            btnKayıtYap.UseVisualStyleBackColor = false;
            btnKayıtYap.Click += btnKayıtYap_Click;
            // 
            // FrmHastaKayıt
            // 
            AcceptButton = btnKayıtYap;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(401, 446);
            Controls.Add(btnKayıtYap);
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
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaKayıt";
            Text = "Hasta Kayıt";
            Load += FrmHastaKayıt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAd;
        private MaskedTextBox msbTC;
        private TextBox txtSoyad;
        private MaskedTextBox msbTelefon;
        private TextBox txtSifre;
        private ComboBox cmbCinsiyet;
        private Button btnKayıtYap;
    }
}