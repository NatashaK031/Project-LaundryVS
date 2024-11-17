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
using ProjectLaundryVS.UserControls;

namespace ProjectLaundryVS
{
    public partial class LoginForm : Form
    {

        public static string username;
        public static bool moveToLogin = false, moveToRegister = false;

        private UserControl LoginControl = new LoginComponent();
        private UserControl RegisterControl = new Register();
        public LoginForm()
        {
            InitializeComponent();
            this.ContentPanel.Controls.Clear();
            timer1.Start();
            ContentPanel.Controls.Add(LoginControl);
            ContentPanel.Controls.Add(RegisterControl);

            LoginControl.Visible = true;
            RegisterControl.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveToLogin == true) {
                this.Show();
                LoginControl.Visible = true;
                RegisterControl.Visible = false;
                moveToLogin = false;
                return;
            }
            if (moveToRegister == true)
            {
                this.Show();
                RegisterControl.Visible = true;
                LoginControl.Visible = false;  
                moveToRegister = false;
                return;
            }
        }
    }
}
