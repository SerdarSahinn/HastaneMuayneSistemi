namespace _220601006__SerdarŞahin__Ödev2
{
    partial class hastasilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hastasilme));
            kilmliktxt = new TextBox();
            label1 = new Label();
            Hastagstrbtn = new Button();
            listView1 = new ListView();
            dataGridView1 = new DataGridView();
            silbtn = new Button();
            iptalbtn = new Button();
            groupBox1 = new GroupBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // kilmliktxt
            // 
            kilmliktxt.Location = new Point(87, 129);
            kilmliktxt.Name = "kilmliktxt";
            kilmliktxt.Size = new Size(125, 27);
            kilmliktxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 129);
            label1.Name = "label1";
            label1.Size = new Size(33, 28);
            label1.TabIndex = 1;
            label1.Text = "TC";
            // 
            // Hastagstrbtn
            // 
            Hastagstrbtn.BackColor = SystemColors.Info;
            Hastagstrbtn.Location = new Point(87, 194);
            Hastagstrbtn.Name = "Hastagstrbtn";
            Hastagstrbtn.Size = new Size(128, 44);
            Hastagstrbtn.TabIndex = 2;
            Hastagstrbtn.Text = "Hastayı Göster";
            Hastagstrbtn.UseVisualStyleBackColor = false;
            Hastagstrbtn.Click += Hastagstrbtn_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(17, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(558, 121);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(17, 247);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(558, 220);
            dataGridView1.TabIndex = 4;
            // 
            // silbtn
            // 
            silbtn.BackColor = Color.Lime;
            silbtn.Location = new Point(127, 182);
            silbtn.Name = "silbtn";
            silbtn.Size = new Size(94, 44);
            silbtn.TabIndex = 5;
            silbtn.Text = "Sil";
            silbtn.UseVisualStyleBackColor = false;
            silbtn.Click += silbtn_Click;
            // 
            // iptalbtn
            // 
            iptalbtn.BackColor = Color.Red;
            iptalbtn.Location = new Point(348, 182);
            iptalbtn.Name = "iptalbtn";
            iptalbtn.Size = new Size(94, 44);
            iptalbtn.TabIndex = 6;
            iptalbtn.Text = "İptal";
            iptalbtn.UseVisualStyleBackColor = false;
            iptalbtn.Click += iptalbtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(iptalbtn);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(silbtn);
            groupBox1.Location = new Point(278, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(595, 494);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hasta Bilgileri";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(12, 465);
            button1.Name = "button1";
            button1.Size = new Size(123, 41);
            button1.TabIndex = 7;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 465);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(448, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(74, 182);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(47, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(39, 194);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(42, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // hastasilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(924, 572);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(Hastagstrbtn);
            Controls.Add(label1);
            Controls.Add(kilmliktxt);
            Name = "hastasilme";
            Text = "hastasilme";
            Load += hastasilme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox kilmliktxt;
        private Label label1;
        private Button Hastagstrbtn;
        private ListView listView1;
        private DataGridView dataGridView1;
        private Button silbtn;
        private Button iptalbtn;
        private GroupBox groupBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}