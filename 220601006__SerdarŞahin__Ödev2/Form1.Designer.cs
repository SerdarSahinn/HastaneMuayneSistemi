namespace _220601006__SerdarŞahin__Ödev2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            baslıklbl = new Label();
            MenugroupBox1 = new GroupBox();
            hastaeklemebtnn = new Button();
            hastalistebtn = new Button();
            hastasilmebtn = new Button();
            hastaguncellemebtn = new Button();
            cksbtn = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            MenugroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // baslıklbl
            // 
            baslıklbl.AutoSize = true;
            baslıklbl.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            baslıklbl.Location = new Point(154, 36);
            baslıklbl.Name = "baslıklbl";
            baslıklbl.Size = new Size(436, 46);
            baslıklbl.TabIndex = 7;
            baslıklbl.Text = "HASTANE MUAYNE SİSTEMİ";
            // 
            // MenugroupBox1
            // 
            MenugroupBox1.Controls.Add(pictureBox6);
            MenugroupBox1.Controls.Add(pictureBox5);
            MenugroupBox1.Controls.Add(pictureBox4);
            MenugroupBox1.Controls.Add(pictureBox3);
            MenugroupBox1.Controls.Add(hastaeklemebtnn);
            MenugroupBox1.Controls.Add(hastalistebtn);
            MenugroupBox1.Controls.Add(hastasilmebtn);
            MenugroupBox1.Controls.Add(hastaguncellemebtn);
            MenugroupBox1.Location = new Point(31, 112);
            MenugroupBox1.Name = "MenugroupBox1";
            MenugroupBox1.Size = new Size(884, 326);
            MenugroupBox1.TabIndex = 6;
            MenugroupBox1.TabStop = false;
            MenugroupBox1.Text = "Menü";
            // 
            // hastaeklemebtnn
            // 
            hastaeklemebtnn.BackColor = SystemColors.ControlDarkDark;
            hastaeklemebtnn.Location = new Point(45, 120);
            hastaeklemebtnn.Name = "hastaeklemebtnn";
            hastaeklemebtnn.Size = new Size(173, 94);
            hastaeklemebtnn.TabIndex = 0;
            hastaeklemebtnn.Text = "Hasta Ekle";
            hastaeklemebtnn.UseVisualStyleBackColor = false;
            hastaeklemebtnn.Click += hastaeklemebtnn_Click;
            // 
            // hastalistebtn
            // 
            hastalistebtn.BackColor = SystemColors.ControlDarkDark;
            hastalistebtn.Location = new Point(663, 120);
            hastalistebtn.Name = "hastalistebtn";
            hastalistebtn.Size = new Size(185, 94);
            hastalistebtn.TabIndex = 3;
            hastalistebtn.Text = "Hasta Listesi";
            hastalistebtn.UseVisualStyleBackColor = false;
            hastalistebtn.Click += hastalistebtn_Click;
            // 
            // hastasilmebtn
            // 
            hastasilmebtn.BackColor = SystemColors.ControlDarkDark;
            hastasilmebtn.Location = new Point(241, 120);
            hastasilmebtn.Name = "hastasilmebtn";
            hastasilmebtn.Size = new Size(173, 94);
            hastasilmebtn.TabIndex = 1;
            hastasilmebtn.Text = "Hasta Silme";
            hastasilmebtn.UseVisualStyleBackColor = false;
            hastasilmebtn.Click += hastasilmebtn_Click;
            // 
            // hastaguncellemebtn
            // 
            hastaguncellemebtn.BackColor = SystemColors.ControlDarkDark;
            hastaguncellemebtn.Location = new Point(446, 120);
            hastaguncellemebtn.Name = "hastaguncellemebtn";
            hastaguncellemebtn.Size = new Size(173, 94);
            hastaguncellemebtn.TabIndex = 2;
            hastaguncellemebtn.Text = "Hasta Güncelleme";
            hastaguncellemebtn.UseVisualStyleBackColor = false;
            hastaguncellemebtn.Click += hastaguncellemebtn_Click;
            // 
            // cksbtn
            // 
            cksbtn.BackColor = Color.FromArgb(192, 0, 0);
            cksbtn.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cksbtn.Location = new Point(921, 390);
            cksbtn.Name = "cksbtn";
            cksbtn.Size = new Size(201, 48);
            cksbtn.TabIndex = 8;
            cksbtn.Text = "Çıkış Yap";
            cksbtn.UseVisualStyleBackColor = false;
            cksbtn.Click += cksbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1128, 390);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ControlDark;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(585, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(123, 105);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(708, 221);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(84, 92);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(80, 220);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(98, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(282, 220);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(95, 93);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(503, 220);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(86, 93);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1276, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cksbtn);
            Controls.Add(baslıklbl);
            Controls.Add(MenugroupBox1);
            Name = "Form1";
            Text = "Form1";
            MenugroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label baslıklbl;
        private GroupBox MenugroupBox1;
        private Button hastaeklemebtnn;
        private Button hastalistebtn;
        private Button hastasilmebtn;
        private Button hastaguncellemebtn;
        private Button cksbtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}