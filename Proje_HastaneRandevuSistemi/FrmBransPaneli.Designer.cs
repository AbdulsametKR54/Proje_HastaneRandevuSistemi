namespace Proje_HastaneRandevuSistemi
{
    partial class FrmBransPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBransPaneli));
            groupBox5 = new GroupBox();
            btnSil = new Button();
            txtAd = new TextBox();
            btnGuncelle = new Button();
            btnEkle = new Button();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btnSil);
            groupBox5.Controls.Add(txtAd);
            groupBox5.Controls.Add(btnGuncelle);
            groupBox5.Controls.Add(btnEkle);
            groupBox5.Controls.Add(txtId);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label4);
            groupBox5.Location = new Point(12, 64);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(337, 250);
            groupBox5.TabIndex = 20;
            groupBox5.TabStop = false;
            groupBox5.Text = "Branş Paneli";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.Location = new Point(233, 138);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(98, 43);
            btnSil.TabIndex = 17;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(134, 92);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(197, 40);
            txtAd.TabIndex = 15;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Bisque;
            btnGuncelle.Location = new Point(134, 187);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(197, 43);
            btnGuncelle.TabIndex = 14;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.GradientInactiveCaption;
            btnEkle.Location = new Point(134, 138);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(93, 43);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(197, 40);
            txtId.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 95);
            label5.Name = "label5";
            label5.Size = new Size(127, 32);
            label5.TabIndex = 1;
            label5.Text = "Branş Ad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 46);
            label4.Name = "label4";
            label4.Size = new Size(123, 32);
            label4.TabIndex = 0;
            label4.Text = "Branş Id:";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(355, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(470, 232);
            dataGridView1.TabIndex = 22;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 29);
            label1.Name = "label1";
            label1.Size = new Size(148, 32);
            label1.TabIndex = 21;
            label1.Text = "Branş Paneli";
            // 
            // FrmBransPaneli
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(843, 336);
            Controls.Add(groupBox5);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "FrmBransPaneli";
            Text = "FrmBransPaneli";
            Load += FrmBransPaneli_Load;
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox5;
        private Button btnSil;
        private TextBox txtAd;
        private Button btnGuncelle;
        private Button btnEkle;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private DataGridView dataGridView1;
        private Label label1;
    }
}