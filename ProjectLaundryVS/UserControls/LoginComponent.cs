using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProjectLaundryVS.UserControls
{
    public partial class LoginComponent : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public static MainForm mainForm = new MainForm();
        public LoginComponent()
        {
            InitializeComponent();

            alamat = "server=localhost; database=projectlaundry; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            LoginForm.moveToRegister = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm.username = txtUsername.Text;

                query = string.Format("select * from tb_admin where username = '{0}'", txtUsername.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["password"].ToString();
                        if (sandi == txtPassword.Text)
                        {
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
