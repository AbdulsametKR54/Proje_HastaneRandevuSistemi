namespace Proje_HastaneRandevuSistemi
{
    partial class FrmDoktorBilgiGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiGüncelle));
            btnGüncelle = new Button();
            txtSoyad = new TextBox();
            msbTC = new MaskedTextBox();
            txtAd = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            cmbBrans = new ComboBox();
            msbSifre = new MaskedTextBox();
            SuspendLayout();
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = Color.FromArgb(255, 224, 192);
            btnGüncelle.Location = new Point(204, 314);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(197, 42);
            btnGüncelle.TabIndex = 40;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(204, 167);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(197, 40);
            txtSoyad.TabIndex = 37;
            // 
            // msbTC
            // 
            msbTC.Location = new Point(204, 72);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 35;
            msbTC.ValidatingType = typeof(int);
            // 
            // txtAd
            // 
            txtAd.Location = new Point(204, 118);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(197, 40);
            txtAd.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(116, 271);
            label6.Name = "label6";
            label6.Size = new Size(82, 32);
            label6.TabIndex = 33;
            label6.Text = "Şifre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 167);
            label4.Name = "label4";
            label4.Size = new Size(92, 32);
            label4.TabIndex = 31;
            label4.Text = "Soyad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 118);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 30;
            label3.Text = "Ad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 72);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 29;
            label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(43, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(486, 41);
            label1.TabIndex = 28;
            label1.Text = "Doktor Bilgi Güncelleme Sayfası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 222);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 42;
            label5.Text = "Branş:";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(204, 219);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(197, 40);
            cmbBrans.TabIndex = 38;
            // 
            // msbSifre
            // 
            msbSifre.Location = new Point(204, 265);
            msbSifre.Mask = "00000000";
            msbSifre.Name = "msbSifre";
            msbSifre.Size = new Size(197, 40);
            msbSifre.TabIndex = 39;
            msbSifre.ValidatingType = typeof(int);
            // 
            // FrmDoktorBilgiGüncelle
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(555, 370);
            Controls.Add(msbSifre);
            Controls.Add(cmbBrans);
            Controls.Add(label5);
            Controls.Add(btnGüncelle);
            Controls.Add(txtSoyad);
            Controls.Add(msbTC);
            Controls.Add(txtAd);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorBilgiGüncelle";
            Text = "FrmDoktorBilgiGüncelle";
            Load += FrmDoktorBilgiGüncelle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGüncelle;
        private TextBox txtSoyad;
        private MaskedTextBox msbTC;
        private TextBox txtAd;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox cmbBrans;
        private MaskedTextBox msbSifre;
    }
}