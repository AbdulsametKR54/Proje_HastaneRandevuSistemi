namespace Proje_HastaneRandevuSistemi
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            groupBox1 = new GroupBox();
            btnGüncelle = new Button();
            lblAdSoyad = new Label();
            lblTC = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rctRandevuDetay = new RichTextBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox3 = new GroupBox();
            btnCıkıs = new Button();
            btnDuyuru = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGüncelle);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 153);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Doktor Detay";
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(63, 108);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(251, 39);
            btnGüncelle.TabIndex = 4;
            btnGüncelle.Text = "Bilgilerini Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += button1_Click;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 77);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 1;
            label3.Text = "Ad-Soyad:";
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(853, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(453, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(306, 41);
            label1.TabIndex = 6;
            label1.Text = "Doktor Bilgi Sayfası";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rctRandevuDetay);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 243);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Detay";
            // 
            // rctRandevuDetay
            // 
            rctRandevuDetay.Dock = DockStyle.Fill;
            rctRandevuDetay.Location = new Point(3, 36);
            rctRandevuDetay.Name = "rctRandevuDetay";
            rctRandevuDetay.Size = new Size(383, 204);
            rctRandevuDetay.TabIndex = 0;
            rctRandevuDetay.Text = "";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(407, 179);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(656, 346);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(650, 307);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCıkıs);
            groupBox3.Controls.Add(btnDuyuru);
            groupBox3.Location = new Point(15, 428);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 94);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hızlı Erişim";
            // 
            // btnCıkıs
            // 
            btnCıkıs.Location = new Point(199, 39);
            btnCıkıs.Name = "btnCıkıs";
            btnCıkıs.Size = new Size(178, 43);
            btnCıkıs.TabIndex = 6;
            btnCıkıs.Text = "Çıkış";
            btnCıkıs.UseVisualStyleBackColor = true;
            btnCıkıs.Click += btnCıkıs_Click;
            // 
            // btnDuyuru
            // 
            btnDuyuru.Location = new Point(6, 39);
            btnDuyuru.Name = "btnDuyuru";
            btnDuyuru.Size = new Size(178, 43);
            btnDuyuru.TabIndex = 5;
            btnDuyuru.Text = "Duyurular";
            btnDuyuru.UseVisualStyleBackColor = true;
            btnDuyuru.Click += button2_Click;
            // 
            // FrmDoktorDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(1075, 537);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmDoktorDetay";
            Text = "FrmDoktorDetay";
            Load += FrmDoktorDetay_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private Label lblTC;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private RichTextBox rctRandevuDetay;
        private GroupBox groupBox3;
        private Button btnGüncelle;
        private Button btnDuyuru;
        private Button btnCıkıs;
    }
}