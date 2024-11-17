using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ProjectLaundryVS
{
    public partial class Pesanan : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        int HargaKilo, HargaJenis, HargaTotal;
        string currentDate = DateTime.Now.ToString("dd/MM/yyyy");
        public Pesanan()
        {
            InitializeComponent();

            alamat = "server=localhost; database=projectlaundry; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            submitSQL();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.moveToMainmenu = true;
        }

        private void buttonPembayaran_Click(object sender, EventArgs e)
        {
            MainForm.moveToPembayaran = true;
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            //Tidak perlu
        }

        private void JenisBox_TextChanged(object sender, EventArgs e)
        {
            if (JenisBox.Text == "Cuci Setrika")
            {
                HargaJenis = 2000 * Convert.ToInt32(SatuanBox.Text);
            }
            if (JenisBox.Text == "Cuci Lipat")
            {
                HargaJenis = 0 * Convert.ToInt32(SatuanBox.Text);
            }
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            MainForm.moveToRiwayat = true;
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SatuanBox.Text))
            {
               HargaKilo = 7000 * Convert.ToInt32(SatuanBox.Text);
            }
            HargaTotal = HargaKilo + HargaJenis;
            LabelHarga.Text = "Rp." + Convert.ToString(HargaTotal);
        }

        private void submitSQL()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into `tbl_orderan` (Nama_Pelanggan, Jasa, Satuan, Tanggal_Masuk, Estimasi, Jenis_Cucian, Harga, Status) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", NamaBox.Text, JasaBox.Text, SatuanBox.Text, currentDate, EstimasiBox.Text, JenisBox.Text, HargaTotal, "Belum dibayar");

                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Pesanan Berhasil ditambah");
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
