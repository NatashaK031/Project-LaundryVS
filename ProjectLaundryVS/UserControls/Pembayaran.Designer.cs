namespace ProjectLaundryVS.UserControls
{
    partial class Pembayaran
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRiwayat = new System.Windows.Forms.Button();
            this.buttonPembayaran = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPesanan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TambahkanButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.PaymentBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.KembalianLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentLabel = new System.Windows.Forms.Label();
            this.HargaLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.NamaLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.IDSearchBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.buttonPembayaran.BackColor = System.Drawing.Color.Silver;
            this.buttonPembayaran.Location = new System.Drawing.Point(80, 13);
            this.buttonPembayaran.Name = "buttonPembayaran";
            this.buttonPembayaran.Size = new System.Drawing.Size(159, 38);
            this.buttonPembayaran.TabIndex = 58;
            this.buttonPembayaran.Text = "Pembayaran";
            this.buttonPembayaran.UseVisualStyleBackColor = false;
            this.buttonPembayaran.Click += new System.EventHandler(this.buttonPembayaran_Click);
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
            // buttonPesanan
            // 
            this.buttonPesanan.Location = new System.Drawing.Point(257, 13);
            this.buttonPesanan.Name = "buttonPesanan";
            this.buttonPesanan.Size = new System.Drawing.Size(159, 38);
            this.buttonPesanan.TabIndex = 57;
            this.buttonPesanan.Text = "Pesanan";
            this.buttonPesanan.UseVisualStyleBackColor = true;
            this.buttonPesanan.Click += new System.EventHandler(this.buttonPesanan_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TambahkanButton);
            this.panel2.Controls.Add(this.SearchButton);
            this.panel2.Controls.Add(this.PaymentBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.SubmitButton);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.IDSearchBox);
            this.panel2.Location = new System.Drawing.Point(-10, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 443);
            this.panel2.TabIndex = 47;
            // 
            // TambahkanButton
            // 
            this.TambahkanButton.Location = new System.Drawing.Point(561, 111);
            this.TambahkanButton.Name = "TambahkanButton";
            this.TambahkanButton.Size = new System.Drawing.Size(159, 38);
            this.TambahkanButton.TabIndex = 59;
            this.TambahkanButton.Text = "Tambahkan";
            this.TambahkanButton.UseVisualStyleBackColor = true;
            this.TambahkanButton.Click += new System.EventHandler(this.TambahkanButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(561, 42);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(159, 38);
            this.SearchButton.TabIndex = 58;
            this.SearchButton.Text = "Cari";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PaymentBox
            // 
            this.PaymentBox.Location = new System.Drawing.Point(288, 117);
            this.PaymentBox.Name = "PaymentBox";
            this.PaymentBox.Size = new System.Drawing.Size(227, 26);
            this.PaymentBox.TabIndex = 57;
            this.PaymentBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PaymentBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 56;
            this.label2.Text = "Pembayaran";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.StatusLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.KembalianLabel);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.PaymentLabel);
            this.panel3.Controls.Add(this.HargaLabel);
            this.panel3.Controls.Add(this.TotalLabel);
            this.panel3.Controls.Add(this.NamaLabel);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(30, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1015, 216);
            this.panel3.TabIndex = 55;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(789, 18);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(96, 26);
            this.StatusLabel.TabIndex = 66;
            this.StatusLabel.Text = "(Status)";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 29);
            this.label4.TabIndex = 65;
            this.label4.Text = "Kembalian :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 95);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 29);
            this.label5.TabIndex = 64;
            this.label5.Text = "Pembayaran (Rp.) :";
            // 
            // KembalianLabel
            // 
            this.KembalianLabel.AutoSize = true;
            this.KembalianLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KembalianLabel.Location = new System.Drawing.Point(261, 158);
            this.KembalianLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KembalianLabel.Name = "KembalianLabel";
            this.KembalianLabel.Size = new System.Drawing.Size(108, 29);
            this.KembalianLabel.TabIndex = 63;
            this.KembalianLabel.Text = "(Return)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(261, 124);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 29);
            this.label6.TabIndex = 62;
            this.label6.Text = "----------------------------";
            // 
            // PaymentLabel
            // 
            this.PaymentLabel.AutoSize = true;
            this.PaymentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentLabel.Location = new System.Drawing.Point(261, 95);
            this.PaymentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PaymentLabel.Name = "PaymentLabel";
            this.PaymentLabel.Size = new System.Drawing.Size(243, 29);
            this.PaymentLabel.TabIndex = 61;
            this.PaymentLabel.Text = "(Total Pembayaran)";
            // 
            // HargaLabel
            // 
            this.HargaLabel.AutoSize = true;
            this.HargaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HargaLabel.Location = new System.Drawing.Point(261, 55);
            this.HargaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HargaLabel.Name = "HargaLabel";
            this.HargaLabel.Size = new System.Drawing.Size(168, 29);
            this.HargaLabel.TabIndex = 60;
            this.HargaLabel.Text = "(Total Harga)";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(89, 55);
            this.TotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(162, 29);
            this.TotalLabel.TabIndex = 59;
            this.TotalLabel.Text = "Harga (Rp.) :";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NamaLabel
            // 
            this.NamaLabel.AutoSize = true;
            this.NamaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaLabel.Location = new System.Drawing.Point(261, 18);
            this.NamaLabel.Name = "NamaLabel";
            this.NamaLabel.Size = new System.Drawing.Size(91, 26);
            this.NamaLabel.TabIndex = 45;
            this.NamaLabel.Text = "(Nama)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 26);
            this.label13.TabIndex = 44;
            this.label13.Text = "Nama Pelanggan :";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(886, 393);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(159, 38);
            this.SubmitButton.TabIndex = 54;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
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
            // IDSearchBox
            // 
            this.IDSearchBox.Location = new System.Drawing.Point(288, 48);
            this.IDSearchBox.Name = "IDSearchBox";
            this.IDSearchBox.Size = new System.Drawing.Size(227, 26);
            this.IDSearchBox.TabIndex = 44;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(766, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 60;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Pembayaran";
            this.Size = new System.Drawing.Size(1060, 500);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRiwayat;
        private System.Windows.Forms.Button buttonPembayaran;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPesanan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IDSearchBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox PaymentBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label KembalianLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PaymentLabel;
        private System.Windows.Forms.Label HargaLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label NamaLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button TambahkanButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button button1;
    }
}
