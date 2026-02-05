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

            tbAngkatan.Enabled = false;
            tbAngkatan.BackColor = Color.LightGray;

            LoadPetugas();

        }

        private void LoadPetugas()
        {
            try
            {
                C_Petugas controller = new C_Petugas();
                List<M_Petugas> listPetugas = controller.GetAll();

                clbPetugas.Items.Clear();

                foreach (M_Petugas petugas in listPetugas)
                {
                    clbPetugas.Items.Add(petugas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load petugas: " + ex.Message);
            }
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

            // 1. Simpan pasien, dapat ID
            int idPasien = SimpanDataPasien();
            if (idPasien == 0)
            {
                MessageBox.Show("Gagal menyimpan data pasien.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Upload foto, dapat URL
            string fotoUrl = UploadFoto();

            // 3. Simpan penanganan dengan ID dan URL dari atas
            int idPenanganan = SimpanDataPenanganan(idPasien, fotoUrl);
            if (idPenanganan == 0)
            {
                MessageBox.Show("Gagal menyimpan data penanganan!", "Error");
                return;
            }

            // 4. Simpan petugas
            bool berhasilPetugas = SimpanPetugasPenanganan(idPenanganan);

            if (berhasilPetugas)
            {
                MessageBox.Show("Data penanganan berhasil disimpan!", "Sukses",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
        }

        //Validasi Input
        private bool ValidasiInput()
        {
            if (string.IsNullOrEmpty(tbNamaPasien.Text))
            {
                MessageBox.Show("Nama pasien wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNamaPasien.Focus();
                return false;
            }

            if (cmbxStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status wajib dipilih!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cmbxStatus.Text == "Mahasiswa" && string.IsNullOrEmpty(tbAngkatan.Text))
            {
                MessageBox.Show("Angkatan wajib diisi untuk mahasiswa!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(tbKeluhan.Text))
            {
                MessageBox.Show("Keluhan wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrEmpty(tbTindakan.Text))
            {
                MessageBox.Show("Tindakan wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // ← TAMBAHKAN: Validasi petugas
            if (clbPetugas.CheckedItems.Count == 0)
            {
                MessageBox.Show("Pilih minimal 1 petugas yang menangani!", "Peringatan",
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

        private int SimpanDataPenanganan(int idPasien, string fotoUrl)
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
            if (controller.Insert(penanganan))
            {
                return controller.GetLastId();
            }

            return 0;
        }

        private bool SimpanPetugasPenanganan(int idPenanganan)
        {
            try
            {
                PenangananPetugas controller = new PenangananPetugas();

                foreach (var item in clbPetugas.CheckedItems)
                {
                    M_Petugas petugas = (M_Petugas)item;

                    M_PenangananPetugas pp = new M_PenangananPetugas
                    {
                        idPenanganan = idPenanganan,
                        npm = petugas.Npm
                    };

                    controller.Insert(pp);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error simpan petugas: " + ex.Message);
                return false;
            }
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

        // ================= RESET FORM =================
        private void ResetForm()
        { 
            tbNamaPasien.Clear();
            tbProdi.Clear();
            tbAngkatan.Clear();
            cmbxStatus.SelectedIndex = -1;

            
            dtTanggal.Value = DateTime.Now;
            tbKeluhan.Clear();
            tbTindakan.Clear();
            cmbTindakLanjut.SelectedIndex = -1;
            tbRujuk.Clear();

            
            pictureBoxFoto.Image = null;
            fotoPath = "";
            for (int i = 0; i < clbPetugas.Items.Count; i++)
            {
                clbPetugas.SetItemChecked(i, false);
            }
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

        private void cmbTindakLanjut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTindakLanjut.SelectedItem.ToString() == "Selesai")
            {
                tbRujuk.Enabled = false;
                tbRujuk.BackColor = Color.LightGreen;
            }
            else
            {
                tbRujuk.Enabled = true;
                tbRujuk.BackColor = Color.White;
                tbRujuk.Clear();
            }
        }

        private void tbAngkatan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
