namespace Proje_HastaneRandevuSistemi
{
    partial class FrmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGiris));
            btnHastaGiris = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnHastaGiris
            // 
            btnHastaGiris.BackgroundImage = (Image)resources.GetObject("btnHastaGiris.BackgroundImage");
            btnHastaGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnHastaGiris.Location = new Point(25, 184);
            btnHastaGiris.Name = "btnHastaGiris";
            btnHastaGiris.Size = new Size(181, 198);
            btnHastaGiris.TabIndex = 0;
            btnHastaGiris.UseVisualStyleBackColor = true;
            btnHastaGiris.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(294, 184);
            button2.Name = "button2";
            button2.Size = new Size(196, 198);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(557, 184);
            button3.Name = "button3";
            button3.Size = new Size(176, 199);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(579, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 75);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Handwriting", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(124, 61);
            label1.Name = "label1";
            label1.Size = new Size(407, 29);
            label1.TabIndex = 5;
            label1.Text = "Özel Aga Heyeran Hastanesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 398);
            label2.Name = "label2";
            label2.Size = new Size(130, 29);
            label2.TabIndex = 6;
            label2.Text = "Hasta Girişi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 398);
            label3.Name = "label3";
            label3.Size = new Size(140, 29);
            label3.TabIndex = 7;
            label3.Text = "Doktor Girişi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(572, 398);
            label4.Name = "label4";
            label4.Size = new Size(161, 29);
            label4.TabIndex = 8;
            label4.Text = "Sekreter Girişi";
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(780, 475);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnHastaGiris);
            Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "FrmGiris";
            Text = "Aga Heyeran Özel Hastanesi Giriş";
            Load += GirisForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHastaGiris;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}