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
using MySql.Data.MySqlClient;

namespace ProjectLaundryVS.UserControls
{
    public partial class Register : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Masukkan username anda!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Masukkan password anda!");
                return;
            }
            if (txtPassword != txtPassword2)
            {
                MessageBox.Show("Password yang di-isi harus sama!");
                return;
            }
            registerSQL();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoginForm.moveToLogin = true;
        }

        private void registerSQL()
        {
            if (koneksi.State != ConnectionState.Open)
            {
                koneksi.Open();
            }
            try
            {
                query = string.Format("insert into `tb_admin` (username, password) values ('{0}', '{1}')", txtUsername.Text, txtPassword2.Text);

                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Register Berhasil!");
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
