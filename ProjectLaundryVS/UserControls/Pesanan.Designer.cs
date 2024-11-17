namespace ProjectLaundryVS
{
    partial class Pesanan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelHarga = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.EstimasiBox = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SatuanBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.JenisBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.JasaBox = new System.Windows.Forms.ComboBox();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.NamaBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRiwayat = new System.Windows.Forms.Button();
            this.buttonPembayaran = new System.Windows.Forms.Button();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatuanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(781, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Harga :";
            // 
            // LabelHarga
            // 
            this.LabelHarga.AutoSize = true;
            this.LabelHarga.Location = new System.Drawing.Point(885, 438);
            this.LabelHarga.Name = "LabelHarga";
            this.LabelHarga.Size = new System.Drawing.Size(38, 20);
            this.LabelHarga.TabIndex = 31;
            this.LabelHarga.Text = "Rp. ";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.EstimasiBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.SatuanBox);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.JenisBox);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.JasaBox);
            this.panel2.Controls.Add(this.IDBox);
            this.panel2.Controls.Add(this.NamaBox);
            this.panel2.Location = new System.Drawing.Point(-10, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 362);
            this.panel2.TabIndex = 43;
            // 
            // EstimasiBox
            // 
            this.EstimasiBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EstimasiBox.Location = new System.Drawing.Point(768, 129);
            this.EstimasiBox.Name = "EstimasiBox";
            this.EstimasiBox.Size = new System.Drawing.Size(227, 26);
            this.EstimasiBox.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 55;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(864, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 38);
            this.button2.TabIndex = 54;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SatuanBox
            // 
            this.SatuanBox.Location = new System.Drawing.Point(768, 51);
            this.SatuanBox.Name = "SatuanBox";
            this.SatuanBox.Size = new System.Drawing.Size(227, 26);
            this.SatuanBox.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(586, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 26);
            this.label7.TabIndex = 48;
            this.label7.Text = "Satuan (Kg)";
            // 
            // JenisBox
            // 
            this.JenisBox.FormattingEnabled = true;
            this.JenisBox.Items.AddRange(new object[] {
            "Cuci Setrika",
            "Cuci Lipat"});
            this.JenisBox.Location = new System.Drawing.Point(768, 207);
            this.JenisBox.Name = "JenisBox";
            this.JenisBox.Size = new System.Drawing.Size(227, 28);
            this.JenisBox.TabIndex = 52;
            this.JenisBox.Text = "Cuci Lipat";
            this.JenisBox.TextChanged += new System.EventHandler(this.JenisBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(586, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 26);
            this.label9.TabIndex = 49;
            this.label9.Text = "Estimasi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(586, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 26);
            this.label10.TabIndex = 50;
            this.label10.Text = "Jenis Cucian";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 26);
            this.label11.TabIndex = 47;
            this.label11.Text = "Jasa Layanan";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 26);
            this.label12.TabIndex = 42;
            this.label12.Text = "ID Pesanan";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(72, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 26);
            this.label13.TabIndex = 43;
            this.label13.Text = "Nama Pelanggan";
            // 
            // JasaBox
            // 
            this.JasaBox.FormattingEnabled = true;
            this.JasaBox.Items.AddRange(new object[] {
            "Bedcover Besar",
            "Bedcover Kecil",
            "Gorden",
            "T-Shirt",
            "Kameja",
            "Celana",
            "Pakain Jas",
            "Selimut/Sprey",
            ""});
            this.JasaBox.Location = new System.Drawing.Point(288, 206);
            this.JasaBox.Name = "JasaBox";
            this.JasaBox.Size = new System.Drawing.Size(227, 28);
            this.JasaBox.TabIndex = 46;
            this.JasaBox.Text = "T-Shirt";
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(288, 48);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(227, 26);
            this.IDBox.TabIndex = 44;
            // 
            // NamaBox
            // 
            this.NamaBox.Location = new System.Drawing.Point(288, 129);
            this.NamaBox.Name = "NamaBox";
            this.NamaBox.Size = new System.Drawing.Size(227, 26);
            this.NamaBox.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectLaundryVS.Properties.Resources._return;
            this.pictureBox1.Location = new System.Drawing.Point(7, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 44;
            this.label1.Text = "Cuci Lipat 1 Kg = Rp. 7000\r\nCuci Setrika 1Kg = Rp. 9000";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.buttonRiwayat);
            this.panel1.Controls.Add(this.buttonPembayaran);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonPesanan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 61);
            this.panel1.TabIndex = 45;
            // 
            // buttonRiwayat
            // 
            this.buttonRiwayat.Location = new System.Drawing.Point(431, 13);
            this.buttonRiwayat.Name = "buttonRiwayat";
            this.buttonRiwayat.Size = new System.Drawing.Size(159, 38);
            this.buttonRiwayat.TabIndex = 59;
            this.buttonRiwayat.Text = "Riwayat";
            this.buttonRiwayat.UseVisualStyleBackColor = true;
            this.buttonRiwayat.Click += new System.EventHandler(this.buttonRiwayat_Click);
            // 
            // buttonPembayaran
            // 
            this.buttonPembayaran.Location = new System.Drawing.Point(80, 13);
            this.buttonPembayaran.Name = "buttonPembayaran";
            this.buttonPembayaran.Size = new System.Drawing.Size(159, 38);
            this.buttonPembayaran.TabIndex = 58;
            this.buttonPembayaran.Text = "Pembayaran";
            this.buttonPembayaran.UseVisualStyleBackColor = true;
            this.buttonPembayaran.Click += new System.EventHandler(this.buttonPembayaran_Click);
            // 
            // buttonPesanan
            // 
            this.buttonPesanan.BackColor = System.Drawing.Color.Silver;
            this.buttonPesanan.Location = new System.Drawing.Point(257, 13);
            this.buttonPesanan.Name = "buttonPesanan";
            this.buttonPesanan.Size = new System.Drawing.Size(159, 38);
            this.buttonPesanan.TabIndex = 57;
            this.buttonPesanan.Text = "Pesanan";
            this.buttonPesanan.UseVisualStyleBackColor = false;
            this.buttonPesanan.Click += new System.EventHandler(this.buttonPesanan_Click);
            // 
            // Pesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelHarga);
            this.Name = "Pesanan";
            this.Size = new System.Drawing.Size(1060, 500);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SatuanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelHarga;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown SatuanBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox JenisBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox JasaBox;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox NamaBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker EstimasiBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRiwayat;
        private System.Windows.Forms.Button buttonPembayaran;
        private System.Windows.Forms.Button buttonPesanan;
    }
}
