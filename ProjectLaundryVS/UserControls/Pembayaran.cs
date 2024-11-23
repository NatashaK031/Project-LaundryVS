using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLaundryVS.UserControls
{
    public partial class Pembayaran : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        private string Nama, Status;
        private int Harga, Payment, Kembalian;

        public Pembayaran()
        {
            InitializeComponent();

            alamat = "server=localhost; database=projectlaundry; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            timer1.Start();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KembalianLabel.Text))
            {
                MessageBox.Show("Mohon Masukkan Jumlah Pembayaran!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(Kembalian < 0)
            {
                MessageBox.Show("Pembayaran Tidak Cukup!");
                return;
            }
            if (Status == "Lunas")
            {
                MessageBox.Show("Pesanan ini telah lunas!");
                return;
            }
            UpdateSQL();  

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            NamaLabel.Text = Nama;
            StatusLabel.Text = Status;
            HargaLabel.Text = Harga.ToString();
            PaymentLabel.Text = Payment.ToString();
            
            Kembalian = Payment - Harga; 
            KembalianLabel.Text = Kembalian.ToString();

            if(Status == "Lunas")
            {
                StatusLabel.ForeColor = Color.Green;
            }
            if(Status == "Belum dibayar")
            {
                StatusLabel.ForeColor = Color.Red;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchSQL();
        }

        private void buttonPembayaran_Click(object sender, EventArgs e)
        {
            //Tidak Perlu
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            MainForm.moveToPesanan = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.moveToMainmenu = true;
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            MainForm.moveToRiwayat = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCRPembayaran formCRPembayaran = new FormCRPembayaran();
            formCRPembayaran.Show();
        }

        private void TambahkanButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PaymentBox.Text))
            {
                Payment = Convert.ToInt32(PaymentBox.Text);
            }
        }

        private void PaymentBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters (e.g., backspace), and optionally a single decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void SearchSQL()
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(IDSearchBox.Text))
            {
                MessageBox.Show("Mohon Masukkan ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                // Add parameter to the query
                query = string.Format("SELECT Nama_Pelanggan, Harga, Status FROM tbl_orderan WHERE ID_Pesanan = {0}", IDSearchBox.Text);

                using (MySqlCommand command = new MySqlCommand(query, koneksi))
                {
                    // Use parameterized query to prevent SQL injection
                    command.Parameters.AddWithValue("@ID", IDSearchBox.Text);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Nama = reader["Nama_Pelanggan"].ToString();
                            Harga = Convert.ToInt32(reader["Harga"]);
                            Status = reader["Status"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Data not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSQL()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("UPDATE tbl_orderan SET Status = '{0}' WHERE ID_Pesanan = '{1}'", "Lunas", IDSearchBox.Text);

                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Pembayaran Selesai");
                }
                else
                {
                    MessageBox.Show("Insert data gagal");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
