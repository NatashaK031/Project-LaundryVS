using ProjectLaundryVS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLaundryVS
{
    public partial class MainForm : Form
    {
        private UserControl MainMenuControl = new MainMenu();
        private UserControl PesananControl = new Pesanan();
        private UserControl PembayaranControl = new Pembayaran();
        private UserControl RiwayatControl = new Riwayat();
        private UserControl ProfilMenuControl = new ProfilMenu();

        public static bool moveToPesanan = false, moveToMainmenu = false, moveToPembayaran = false, moveToRiwayat, moveToProfil = false;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ControlPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            moveToProfil = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.ControlPanel.Controls.Clear();
            ControlPanel.Controls.Add(MainMenuControl);
            ControlPanel.Controls.Add(PesananControl);
            ControlPanel.Controls.Add(PembayaranControl);
            ControlPanel.Controls.Add(RiwayatControl);
            ControlPanel.Controls.Add(ProfilMenuControl);

            HideAllControls();
            MainMenuControl.Visible = true;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moveToMainmenu == true)
            {
                HideAllControls();
                MainMenuControl.Visible = true;

                moveToMainmenu = false;
                return;
            }

            if (moveToPembayaran == true)
            {
                HideAllControls();
                PembayaranControl.Visible = true;

                moveToPembayaran = false;
                return;
            }

            if (moveToPesanan == true)
            {
                HideAllControls();
                PesananControl.Visible = true;

                moveToPesanan = false;
                return;
            }

            if(moveToRiwayat == true)
            {
                HideAllControls();
                RiwayatControl.Visible = true;

                moveToRiwayat = false;
                return;
            }

            if(moveToProfil == true)
            {
                HideAllControls();
                ProfilMenuControl.Visible = true;

                moveToProfil = false;
                return;
            }
        }

        private void HideAllControls()
        {
            MainMenuControl.Visible = false;
            PembayaranControl.Visible = false;
            PesananControl.Visible = false;
            ProfilMenuControl.Visible = false;
            RiwayatControl.Visible = false;
        }
    }
}
