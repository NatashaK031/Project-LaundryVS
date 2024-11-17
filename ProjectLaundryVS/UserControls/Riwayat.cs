using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjectLaundryVS.UserControls
{
    public partial class Riwayat : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        private string search;
        public Riwayat()
        {
            alamat = "server=localhost; database=projectlaundry; username=root; password=;";
            koneksi = new MySqlConnection(alamat);

            InitializeComponent();
        }
        private void Riwayat_Load(object sender, EventArgs e)
        {
            timer1.Start();
            searchAllSQL();
            setDatagrid(adapter);
        }

        private void buttonRiwayat_Click(object sender, EventArgs e)
        {
            //Tidak perlu
        }

        private void buttonPembayaran_Click(object sender, EventArgs e)
        {
            MainForm.moveToPembayaran = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainForm.moveToMainmenu = true;
        }

        private void buttonPesanan_Click(object sender, EventArgs e)
        {
            MainForm.moveToPesanan = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (search.All(char.IsDigit))
            {
                deleteByID();
                setDatagrid(adapter);
                return;
            }
            else if (search.All(char.IsLetter))
            {
                deleteByName();
                setDatagrid(adapter);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                searchAllSQL();
                setDatagrid(adapter);
                return;
            }
            else if (search.All(char.IsDigit))
            {
                searchByID();
                setDatagrid(adapter);
                return;
            }
            else if (search.All(char.IsLetter))
            {
                searchByName();
                setDatagrid(adapter);
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SearchBox.Text = "";
            searchAllSQL();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            search = SearchBox.Text;
        }

        private void setDatagrid(MySqlDataAdapter data)
        {
            try
            {
                ds.Clear(); // Clear the DataSet
                dataGridView1.DataSource = null; // Clear the DataGridView's DataSource
                data.Fill(ds); // Fill the DataSet
                
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[0].HeaderText = "ID Pesanan";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[1].HeaderText = "Nama Pelanggan";
                dataGridView1.Columns[2].Width = 120;
                dataGridView1.Columns[2].HeaderText = "Jasa";
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[3].HeaderText = "Satuan";
                dataGridView1.Columns[4].Width = 120;
                dataGridView1.Columns[4].HeaderText = "Tanggal Masuk";
                dataGridView1.Columns[5].Width = 120;
                dataGridView1.Columns[5].HeaderText = "Estimasi Tersedia";
                dataGridView1.Columns[6].Width = 120;
                dataGridView1.Columns[6].HeaderText = "Jenis";
                dataGridView1.Columns[7].Width = 120;
                dataGridView1.Columns[7].HeaderText = "Harga";
                dataGridView1.Columns[8].Width = 120;
                dataGridView1.Columns[8].HeaderText = "Status";
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchAllSQL()
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_orderan");
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void searchByID()
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_orderan where ID_Pesanan = '{0}'", search);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void searchByName()
        {
            try
            {
                koneksi.Open();
                query = string.Format("select * from tbl_orderan where Nama_Pelanggan like '%{0}%'", search);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteByID()
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from tbl_orderan where ID_Pesanan = '%{0}%'", search);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void deleteByName()
        {
            try
            {
                koneksi.Open();
                query = string.Format("delete from tbl_orderan where Nama_Pelanggan = '%{0}%'", search);
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                ds.Clear();
                adapter.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
