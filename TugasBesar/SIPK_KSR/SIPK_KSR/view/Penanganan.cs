using Org.BouncyCastle.Asn1.Cmp;
using SIPK_KSR.controller;
using SIPK_KSR.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.view
{
    public partial class Penanganan : Form
    {
        string fotoPath = "";

        public Penanganan()
        {
            InitializeComponent();
        }

        //pilih foto
        private void btnPilihFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fotoPath = ofd.FileName;
                pictureBoxFoto.ImageLocation = fotoPath;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!ValidasiInput())
                return;

            int idPasien = SimpanDataPasien();
            if (idPasien == 0)
            {
                MessageBox.Show("Gagal menyimpan data pasien.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fotoUrl = UploadFoto();

            bool berhasil = SimpanDataPenanganan(idPasien, fotoUrl);

            if (berhasil)
            {
                MessageBox.Show("Data penanganan berhasil disimpan!", "Sukses",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        //Validasi Input
        private bool ValidasiInput()
        {
            if (string.IsNullOrEmpty(tbNamaPasien.Text) ||
                string.IsNullOrEmpty(tbKeluhan.Text) ||
                string.IsNullOrEmpty(tbTindakan.Text))
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int SimpanDataPasien()
        {
            M_Pasien pasien = new M_Pasien
            {
                Nama = tbNamaPasien.Text,
                Status = cmbxStatus.Text,
                Prodi = tbProdi.Text,
                Angkatan = int.TryParse(tbAngkatan.Text, out int angkatanValue) ? (int?)angkatanValue : null
            };

            C_Pasien cPasien = new C_Pasien();

            if (cPasien.Insert(pasien))
            {
                return cPasien.GetLastId();
            }

            return 0;

        }

        private void cmbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxStatus.SelectedItem.ToString() == "Mahasiswa")
            {
                tbAngkatan.Enabled = true;
                tbAngkatan.BackColor = Color.White;
            }
            else
            {
                tbAngkatan.Enabled = false;
                tbAngkatan.BackColor = Color.LightGray;
                tbAngkatan.Clear();
            }
        }

        // ================= UPLOAD FOTO =================
        private string UploadFoto()
        {
            if (string.IsNullOrEmpty(fotoPath))
                return "";

            try
            {
                CloudinaryService cloudinary = new CloudinaryService();
                return cloudinary.UploadImage(fotoPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal upload foto: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }
        }

        // ================= SIMPAN DATA PENANGANAN =================
        private bool SimpanDataPenanganan(int idPasien, string fotoUrl)
        {
            M_Penanganan penanganan = new M_Penanganan
            {
                IdPasien = idPasien,
                Tanggal = dtTanggal.Value,
                Keluhan = tbKeluhan.Text,
                Tindakan = tbTindakan.Text,
                TindakLanjut = cmbTindakLanjut.Text,
                Rujukan = tbRujuk.Text,
                Foto = fotoUrl
            };

            C_Penanganan controller = new C_Penanganan();
            return controller.Insert(penanganan);
        }

        // ================= RESET FORM =================
        private void ResetForm()
        {
            // Data Pasien
            tbNamaPasien.Clear();
            tbProdi.Clear();
            tbAngkatan.Clear();
            cmbxStatus.SelectedIndex = -1;

            // Data Penanganan
            dtTanggal.Value = DateTime.Now;
            tbKeluhan.Clear();
            tbTindakan.Clear();
            cmbTindakLanjut.SelectedIndex = -1;
            tbRujuk.Clear();

            // Foto
            pictureBoxFoto.Image = null;
            fotoPath = "";

            // Reset state angkatan (disabled)
            tbAngkatan.Enabled = false;
            tbAngkatan.BackColor = Color.LightGray;

            tbNamaPasien.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
