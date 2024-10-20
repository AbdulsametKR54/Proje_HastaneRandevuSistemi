namespace Proje_HastaneRandevuSistemi
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            msbSifre = new MaskedTextBox();
            label3 = new Label();
            btnGiris = new Button();
            label2 = new Label();
            msbTC = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // msbSifre
            // 
            msbSifre.Location = new Point(196, 152);
            msbSifre.Mask = "00000000";
            msbSifre.Name = "msbSifre";
            msbSifre.Size = new Size(197, 40);
            msbSifre.TabIndex = 11;
            msbSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 152);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 15;
            label3.Text = "Şifre:";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(192, 255, 192);
            btnGiris.Location = new Point(255, 198);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(138, 40);
            btnGiris.TabIndex = 14;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 90);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 12;
            label2.Text = "TC Kimlik No:";
            // 
            // msbTC
            // 
            msbTC.Location = new Point(196, 90);
            msbTC.Mask = "00000000000";
            msbTC.Name = "msbTC";
            msbTC.Size = new Size(197, 40);
            msbTC.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(399, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(66, 27);
            label1.Name = "label1";
            label1.Size = new Size(327, 41);
            label1.TabIndex = 8;
            label1.Text = "Sekreter Giriş Sayfası";
            // 
            // FrmSekreterGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(595, 251);
            Controls.Add(msbSifre);
            Controls.Add(label3);
            Controls.Add(btnGiris);
            Controls.Add(label2);
            Controls.Add(msbTC);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmSekreterGiris";
            Text = "SekreterGiris";
            Load += FrmSekreterGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox msbSifre;
        private Label label3;
        private Button btnGiris;
        private Label label2;
        private MaskedTextBox msbTC;
        private PictureBox pictureBox1;
        private Label label1;
    }
}