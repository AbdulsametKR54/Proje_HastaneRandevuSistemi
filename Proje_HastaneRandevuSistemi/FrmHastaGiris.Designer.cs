namespace Proje_HastaneRandevuSistemi
{
    partial class FrmHastaGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            msbTC = new MaskedTextBox();
            label2 = new Label();
            linklKayıt = new LinkLabel();
            btnGiris = new Button();
            label3 = new Label();
            msbSifre = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(101, 48);
            label1.Name = "label1";
            label1.Size = new Size(288, 41);
            label1.TabIndex = 0;
            label1.Text = "Hasta Giriş Sayfası";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(395, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // msbTC
            // 
            msbTC.Location = new Point(192, 111);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 111);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 4;
            label2.Text = "TC Kimlik No:";
            // 
            // linklKayıt
            // 
            linklKayıt.AutoSize = true;
            linklKayıt.Location = new Point(395, 176);
            linklKayıt.Name = "linklKayıt";
            linklKayıt.Size = new Size(105, 32);
            linklKayıt.TabIndex = 5;
            linklKayıt.TabStop = true;
            linklKayıt.Text = "Kayıt Ol";
            linklKayıt.LinkClicked += linklKayıt_LinkClicked;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(192, 255, 192);
            btnGiris.Location = new Point(251, 219);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(138, 40);
            btnGiris.TabIndex = 6;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 173);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // msbSifre
            // 
            msbSifre.Location = new Point(192, 173);
            msbSifre.Mask = "00000000";
            msbSifre.Name = "msbSifre";
            msbSifre.Size = new Size(197, 40);
            msbSifre.TabIndex = 3;
            msbSifre.UseSystemPasswordChar = true;
            // 
            // FrmHastaGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(596, 305);
            Controls.Add(msbSifre);
            Controls.Add(label3);
            Controls.Add(btnGiris);
            Controls.Add(linklKayıt);
            Controls.Add(label2);
            Controls.Add(msbTC);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaGiris";
            Text = "Hasta Giriş";
            Load += HastaGirisForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private MaskedTextBox msbTC;
        private Label label2;
        private LinkLabel linklKayıt;
        private Button btnGiris;
        private Label label3;
        private MaskedTextBox msbSifre;
    }
}