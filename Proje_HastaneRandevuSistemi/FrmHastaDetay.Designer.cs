namespace Proje_HastaneRandevuSistemi
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            linkLabel1 = new LinkLabel();
            lblAdSoyad = new Label();
            lblTC = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            txtRandevuId = new TextBox();
            label4 = new Label();
            label8 = new Label();
            btnRandevu = new Button();
            cmbDoktor = new ComboBox();
            rtbSikayet = new RichTextBox();
            label7 = new Label();
            cmbBrans = new ComboBox();
            groupBox3 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 128);
            label1.Font = new Font("Corbel", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(456, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(354, 41);
            label1.TabIndex = 1;
            label1.Text = "Hasta Randevu Sayfası";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1189, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(lblAdSoyad);
            groupBox1.Controls.Add(lblTC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(26, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(389, 153);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Detay";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(63, 109);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(195, 32);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Bilgileri Güncelle";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 83);
            label6.Name = "label6";
            label6.Size = new Size(116, 32);
            label6.TabIndex = 4;
            label6.Text = "Branşlar:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtRandevuId);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnRandevu);
            groupBox2.Controls.Add(cmbDoktor);
            groupBox2.Controls.Add(rtbSikayet);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cmbBrans);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(26, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 340);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Randevu Al";
            // 
            // txtRandevuId
            // 
            txtRandevuId.Enabled = false;
            txtRandevuId.Location = new Point(141, 34);
            txtRandevuId.Name = "txtRandevuId";
            txtRandevuId.Size = new Size(212, 40);
            txtRandevuId.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 37);
            label4.Name = "label4";
            label4.Size = new Size(51, 32);
            label4.TabIndex = 12;
            label4.Text = "Id:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 175);
            label8.Name = "label8";
            label8.Size = new Size(108, 32);
            label8.TabIndex = 11;
            label8.Text = "Şikayet:";
            // 
            // btnRandevu
            // 
            btnRandevu.Location = new Point(141, 287);
            btnRandevu.Name = "btnRandevu";
            btnRandevu.Size = new Size(212, 47);
            btnRandevu.TabIndex = 10;
            btnRandevu.Text = "Randevu Al";
            btnRandevu.UseVisualStyleBackColor = true;
            btnRandevu.Click += btnRandevu_Click;
            // 
            // cmbDoktor
            // 
            cmbDoktor.FormattingEnabled = true;
            cmbDoktor.Location = new Point(141, 129);
            cmbDoktor.Name = "cmbDoktor";
            cmbDoktor.Size = new Size(212, 40);
            cmbDoktor.TabIndex = 7;
            cmbDoktor.SelectedIndexChanged += cmbDoktor_SelectedIndexChanged;
            // 
            // rtbSikayet
            // 
            rtbSikayet.Location = new Point(141, 175);
            rtbSikayet.Name = "rtbSikayet";
            rtbSikayet.Size = new Size(212, 106);
            rtbSikayet.TabIndex = 9;
            rtbSikayet.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 132);
            label7.Name = "label7";
            label7.Size = new Size(99, 32);
            label7.TabIndex = 9;
            label7.Text = "Doktor:";
            // 
            // cmbBrans
            // 
            cmbBrans.FormattingEnabled = true;
            cmbBrans.Location = new Point(141, 80);
            cmbBrans.Name = "cmbBrans";
            cmbBrans.Size = new Size(212, 40);
            cmbBrans.TabIndex = 6;
            cmbBrans.SelectedIndexChanged += cmbBrans_SelectedIndexChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridView1);
            groupBox3.Location = new Point(421, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(762, 223);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Randevu Geçmişi";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(756, 184);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView2);
            groupBox4.Location = new Point(424, 293);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(973, 226);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 36);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(967, 187);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellDoubleClick;
            // 
            // FrmHastaDetay
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1409, 531);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmHastaDetay";
            Text = "Hasta Detay";
            Load += FrmHastaDetay_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label lblAdSoyad;
        private Label lblTC;
        private Label label3;
        private Label label2;
        private Label label6;
        private GroupBox groupBox2;
        private ComboBox cmbBrans;
        private RichTextBox rtbSikayet;
        private Button btnRandevu;
        private Label label8;
        private ComboBox cmbDoktor;
        private Label label7;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private LinkLabel linkLabel1;
        private TextBox txtRandevuId;
        private Label label4;
    }
}