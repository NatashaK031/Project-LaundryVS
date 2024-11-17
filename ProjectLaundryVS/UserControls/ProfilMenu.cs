using CrystalDecisions.CrystalReports.Engine;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectLaundryVS.UserControls
{
    public partial class ProfilMenu : UserControl
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private string alamat, query;
        private string profilename, password;
        bool isPasswordHidden = true;

        public ProfilMenu()
        {
            InitializeComponent();
            alamat = "server=localhost; database=projectlaundry; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainForm.moveToMainmenu = true;
        }

        private void ChangePWButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Tidak boleh Kosong!");
                return;
            }
            try
            {
                koneksi.Open();

                query = string.Format("UPDATE tb_admin SET password = '{0}' WHERE username = '{1}'", PasswordBox.Text, LoginForm.username);

                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                int res = perintah.ExecuteNonQuery();
                koneksi.Close();
                if (res == 1)
                {
                    MessageBox.Show("Perubahan password berhasil");
                }
                else
                {
                    MessageBox.Show("Perubahan password gagal");

                }
                password = PasswordBox.Text;
                PasswordLabel.Text = new string('*', password.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProfilMenu_Load(object sender, EventArgs e)
        {
            profilename = LoginForm.username;
            pwSQL();

            NameLabel.Text = profilename;
            isPasswordHidden = false;
            ShowPWButton_Click(null, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                // Add parameter to the query
                query = string.Format("DELETE FROM tb_admin WHERE username = '{0}'", LoginForm.username);
                using (MySqlCommand command = new MySqlCommand(query, koneksi))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            password = reader["password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Data not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ShowPWButton_Click(object sender, EventArgs e)
        {
            if (isPasswordHidden)
            {
                PasswordLabel.Text = password; // Show the actual password
                ShowPWButton.Text = "Hide"; // Change button text
            }
            else
            {
                PasswordLabel.Text = new string('*', password.Length); // Mask the password
                ShowPWButton.Text = "Show"; // Change button text
            }

            isPasswordHidden = !isPasswordHidden; // Toggle the visibility state
        }

        private void pwSQL()
        {
            try
            {
                koneksi.Open();
                // Add parameter to the query
                query = string.Format("SELECT password FROM tb_admin WHERE username = '{0}'", LoginForm.username);

                using (MySqlCommand command = new MySqlCommand(query, koneksi))
                {

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            password = reader["password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Data not found!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
