using SIPK_KSR.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.view
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Buat gradient brush
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(192, 0, 0),    // Merah KSR (atas)
                Color.FromArgb(0, 51, 153),   // Biru KSR (bawah)
                LinearGradientMode.Vertical)) // Gradient dari atas ke bawah
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnLogin_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;

            // Buat gradient brush (merah → biru)
            using (LinearGradientBrush brush = new LinearGradientBrush(
                btn.ClientRectangle,
                Color.FromArgb(192, 0, 0),   // Merah KSR
                Color.FromArgb(0, 51, 153),  // Biru KSR
                LinearGradientMode.Horizontal))
            {
                // Gambar background gradient
                e.Graphics.FillRectangle(brush, btn.ClientRectangle);
            }

            // Gambar text
            TextRenderer.DrawText(
                e.Graphics,
                btn.Text,
                btn.Font,
                btn.ClientRectangle,
                btn.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUser.Text) || string.IsNullOrWhiteSpace(tbPw.Text))
            {
                MessageBox.Show(
                    "Username dan Password tidak boleh kosong!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string username = tbUser.Text;
            string password = tbPw.Text;

            CekLogin cekLogin = new CekLogin();
            bool loginBerhasil = cekLogin.cek_login(username, password);

            if (loginBerhasil)
            {
                MessageBox.Show("Login berhasil!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Buka ParentForm
                this.Hide();
                ParentForm mainForm = new ParentForm();
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPw.Clear();
                tbPw.Focus();
            }
        }
    }
}
