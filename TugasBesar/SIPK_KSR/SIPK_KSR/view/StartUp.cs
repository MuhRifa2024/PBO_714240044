using SIPK_KSR.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.view
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();

            lblJudul.ForeColor = Color.FromArgb(192, 0, 0);
            progBar.Value = 0;
        }

        private async Task<bool> CekKoneksi(string host)
        {
            try
            {
                var reply = await new Ping().SendPingAsync(host, 3000);
                return reply.Status == IPStatus.Success;
            }
            catch { return false; }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void StartUp_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Mengecek koneksi...";
            await Task.Delay(500);

            if (!await CekKoneksi("8.8.8.8"))
            {
                MessageBox.Show("Tidak ada koneksi internet!", "Error");
                Application.Exit();
                return;
            }
            progBar.Value = 30;

            // Cek Server Database
            lblStatus.Text = "Menghubungkan ke server...";
            await Task.Delay(500);

            if (!await CekKoneksi("mysql-rifa.alwaysdata.net"))
            {
                MessageBox.Show("Server database tidak terjangkau!", "Error");
                Application.Exit();
                return;
            }
            progBar.Value = 60;

            // Test Database
            lblStatus.Text = "Validasi database...";
            await Task.Delay(500);

            try
            {
                Koneksi koneksi = new Koneksi();
                koneksi.OpenConnection();
                koneksi.CloseConnection();
            }
            catch
            {
                MessageBox.Show("Gagal terhubung ke database!", "Error");
                Application.Exit();
                return;
            }
            progBar.Value = 100;

            // Buka ParentForm
            lblStatus.Text = "Selesai!";
            await Task.Delay(300);
            this.Close();
            //new FormLogin().Show();
        }
    }
}
