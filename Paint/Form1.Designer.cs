namespace Paint
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
            this.comboBoxKalinlik = new System.Windows.Forms.ComboBox();
            this.btn_renk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.renk_secici = new System.Windows.Forms.PictureBox();
            this.btn_cizgi = new System.Windows.Forms.Button();
            this.btn_kare = new System.Windows.Forms.Button();
            this.btn_yuvarlak = new System.Windows.Forms.Button();
            this.btn_silgi = new System.Windows.Forms.Button();
            this.btn_kalem = new System.Windows.Forms.Button();
            this.btn_doldur = new System.Windows.Forms.Button();
            this.resim_rengi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resim = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.renk_secici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKalinlik
            // 
            this.comboBoxKalinlik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKalinlik.FormattingEnabled = true;
            this.comboBoxKalinlik.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "9",
            "11",
            "15",
            "20",
            "30",
            "50"});
            this.comboBoxKalinlik.Location = new System.Drawing.Point(712, 3);
            this.comboBoxKalinlik.Name = "comboBoxKalinlik";
            this.comboBoxKalinlik.Size = new System.Drawing.Size(60, 23);
            this.comboBoxKalinlik.TabIndex = 0;
            this.comboBoxKalinlik.SelectedIndexChanged += new System.EventHandler(this.comboBoxKalinlik_SelectedIndexChanged);
            // 
            // btn_renk
            // 
            this.btn_renk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_renk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_renk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_renk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_renk.ForeColor = System.Drawing.Color.Black;
            this.btn_renk.Image = global::Paint.Properties.Resources.color;
            this.btn_renk.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_renk.Location = new System.Drawing.Point(307, 27);
            this.btn_renk.Name = "btn_renk";
            this.btn_renk.Size = new System.Drawing.Size(50, 50);
            this.btn_renk.TabIndex = 2;
            this.btn_renk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_renk.UseVisualStyleBackColor = true;
            this.btn_renk.Click += new System.EventHandler(this.btn_renk_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.btn_kaydet);
            this.panel1.Controls.Add(this.btn_temizle);
            this.panel1.Controls.Add(this.renk_secici);
            this.panel1.Controls.Add(this.btn_cizgi);
            this.panel1.Controls.Add(this.btn_kare);
            this.panel1.Controls.Add(this.btn_yuvarlak);
            this.panel1.Controls.Add(this.btn_silgi);
            this.panel1.Controls.Add(this.btn_kalem);
            this.panel1.Controls.Add(this.btn_doldur);
            this.panel1.Controls.Add(this.resim_rengi);
            this.panel1.Controls.Add(this.comboBoxKalinlik);
            this.panel1.Controls.Add(this.btn_renk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 3;
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kaydet.Location = new System.Drawing.Point(712, 29);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(59, 31);
            this.btn_kaydet.TabIndex = 14;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_temizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.ForeColor = System.Drawing.Color.Black;
            this.btn_temizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_temizle.Location = new System.Drawing.Point(713, 66);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(59, 31);
            this.btn_temizle.TabIndex = 13;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // renk_secici
            // 
            this.renk_secici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.renk_secici.Image = global::Paint.Properties.Resources.color_palette;
            this.renk_secici.Location = new System.Drawing.Point(3, 3);
            this.renk_secici.Name = "renk_secici";
            this.renk_secici.Size = new System.Drawing.Size(250, 94);
            this.renk_secici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.renk_secici.TabIndex = 6;
            this.renk_secici.TabStop = false;
            this.renk_secici.MouseClick += new System.Windows.Forms.MouseEventHandler(this.renk_secici_MouseClick);
            // 
            // btn_cizgi
            // 
            this.btn_cizgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cizgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cizgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_cizgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cizgi.ForeColor = System.Drawing.Color.Black;
            this.btn_cizgi.Image = global::Paint.Properties.Resources.line;
            this.btn_cizgi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cizgi.Location = new System.Drawing.Point(644, 27);
            this.btn_cizgi.Name = "btn_cizgi";
            this.btn_cizgi.Size = new System.Drawing.Size(50, 50);
            this.btn_cizgi.TabIndex = 12;
            this.btn_cizgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cizgi.UseVisualStyleBackColor = true;
            this.btn_cizgi.Click += new System.EventHandler(this.btn_cizgi_Click);
            // 
            // btn_kare
            // 
            this.btn_kare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_kare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_kare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kare.ForeColor = System.Drawing.Color.Black;
            this.btn_kare.Image = global::Paint.Properties.Resources.rectangle;
            this.btn_kare.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kare.Location = new System.Drawing.Point(587, 27);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(50, 50);
            this.btn_kare.TabIndex = 11;
            this.btn_kare.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kare.UseVisualStyleBackColor = true;
            this.btn_kare.Click += new System.EventHandler(this.btn_kare_Click);
            // 
            // btn_yuvarlak
            // 
            this.btn_yuvarlak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_yuvarlak.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_yuvarlak.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_yuvarlak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_yuvarlak.ForeColor = System.Drawing.Color.Black;
            this.btn_yuvarlak.Image = global::Paint.Properties.Resources.circle;
            this.btn_yuvarlak.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_yuvarlak.Location = new System.Drawing.Point(531, 27);
            this.btn_yuvarlak.Name = "btn_yuvarlak";
            this.btn_yuvarlak.Size = new System.Drawing.Size(50, 50);
            this.btn_yuvarlak.TabIndex = 10;
            this.btn_yuvarlak.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_yuvarlak.UseVisualStyleBackColor = true;
            this.btn_yuvarlak.Click += new System.EventHandler(this.btn_yuvarlak_Click);
            // 
            // btn_silgi
            // 
            this.btn_silgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_silgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_silgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_silgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_silgi.ForeColor = System.Drawing.Color.Black;
            this.btn_silgi.Image = global::Paint.Properties.Resources.eraser;
            this.btn_silgi.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_silgi.Location = new System.Drawing.Point(475, 27);
            this.btn_silgi.Name = "btn_silgi";
            this.btn_silgi.Size = new System.Drawing.Size(50, 50);
            this.btn_silgi.TabIndex = 9;
            this.btn_silgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_silgi.UseVisualStyleBackColor = true;
            this.btn_silgi.Click += new System.EventHandler(this.btn_silgi_Click);
            // 
            // btn_kalem
            // 
            this.btn_kalem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kalem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_kalem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_kalem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kalem.ForeColor = System.Drawing.Color.Black;
            this.btn_kalem.Image = global::Paint.Properties.Resources.pencil;
            this.btn_kalem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_kalem.Location = new System.Drawing.Point(419, 27);
            this.btn_kalem.Name = "btn_kalem";
            this.btn_kalem.Size = new System.Drawing.Size(50, 50);
            this.btn_kalem.TabIndex = 8;
            this.btn_kalem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kalem.UseVisualStyleBackColor = true;
            this.btn_kalem.Click += new System.EventHandler(this.btn_kalem_Click);
            // 
            // btn_doldur
            // 
            this.btn_doldur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_doldur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_doldur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_doldur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doldur.ForeColor = System.Drawing.Color.Black;
            this.btn_doldur.Image = global::Paint.Properties.Resources.bucket;
            this.btn_doldur.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_doldur.Location = new System.Drawing.Point(363, 27);
            this.btn_doldur.Name = "btn_doldur";
            this.btn_doldur.Size = new System.Drawing.Size(50, 50);
            this.btn_doldur.TabIndex = 7;
            this.btn_doldur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_doldur.UseVisualStyleBackColor = true;
            this.btn_doldur.Click += new System.EventHandler(this.btn_doldur_Click);
            // 
            // resim_rengi
            // 
            this.resim_rengi.BackColor = System.Drawing.Color.White;
            this.resim_rengi.Location = new System.Drawing.Point(259, 29);
            this.resim_rengi.Name = "resim_rengi";
            this.resim_rengi.Size = new System.Drawing.Size(42, 40);
            this.resim_rengi.TabIndex = 6;
            this.resim_rengi.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 24);
            this.panel2.TabIndex = 4;
            // 
            // resim
            // 
            this.resim.BackColor = System.Drawing.Color.White;
            this.resim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resim.Location = new System.Drawing.Point(0, 0);
            this.resim.Name = "resim";
            this.resim.Size = new System.Drawing.Size(784, 511);
            this.resim.TabIndex = 5;
            this.resim.TabStop = false;
            this.resim.Click += new System.EventHandler(this.Resim_Click);
            this.resim.Paint += new System.Windows.Forms.PaintEventHandler(this.resim_Paint);
            this.resim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.resim_MouseClick);
            this.resim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resim_MouseDown);
            this.resim.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resim_MouseMove);
            this.resim.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resim_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resim);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resim_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resim_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resim_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.renk_secici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBoxKalinlik;
        private Button btn_renk;
        private Panel panel1;
        private Panel panel2;
        private PictureBox resim;
        private Button resim_rengi;
        private Button btn_cizgi;
        private Button btn_kare;
        private Button btn_yuvarlak;
        private Button btn_silgi;
        private Button btn_kalem;
        private Button btn_doldur;
        private PictureBox renk_secici;
        private Button btn_kaydet;
        private Button btn_temizle;
    }
}