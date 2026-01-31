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
    public partial class Petugas : Form
    {
        public Petugas()
        {
            InitializeComponent();
        }

        Koneksi koneksi = new Koneksi();
        M_Petugas m_petugas = new M_Petugas();
        int id_petugas;

        public void LoadData()
        {
            koneksi.OpenConnection();
            dgvAnggota.DataSource = koneksi.ShowData(
                "SELECT * FROM petugas");

            dgvAnggota.Columns[0].HeaderText = "Nama Petugas";
            dgvAnggota.Columns[1].HeaderText = "NPM";
            dgvAnggota.Columns[2].HeaderText = "Angkatan";
            dgvAnggota.Columns[3].HeaderText = "Jabatan";
            dgvAnggota.Columns[4].HeaderText = "No. Telepon";
            koneksi.CloseConnection();
        }

        public void refreshForm()
        {
            tbNama.Clear();
            tbNpm.Clear();
            tbAngkatan.Clear();
            tbNoHP.Clear();
            tbCari.Clear();
            cmbJabatan.SelectedIndex = -1;
        }

        private void Petugas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbNpm.Text == "" || tbAngkatan.Text == "" || tbNoHP.Text == "" || cmbJabatan.SelectedIndex == -1)
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                C_Petugas petugas = new C_Petugas();
                m_petugas.Nama = tbNama.Text;
                m_petugas.Npm = tbNpm.Text;
                m_petugas.Angkatan = tbAngkatan.Text;
                m_petugas.Jabatan = cmbJabatan.Text;
                m_petugas.Nohp = tbNoHP.Text;

                petugas.Insert(m_petugas);
                refreshForm();
                LoadData();
            }
        }

    }
}
