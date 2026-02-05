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
        int npm_petugas = 0;

        public void LoadData()
        {
            koneksi.OpenConnection();
            dgvAnggota.DataSource = koneksi.ShowData(
                "SELECT * FROM petugas");

            dgvAnggota.Columns[0].HeaderText = "NPM";
            dgvAnggota.Columns[1].HeaderText = "Nama Petugas";
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
            LoadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (npm_petugas == 0)
            {
                MessageBox.Show("Pilih data yang akan diubah!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            C_Petugas petugas = new C_Petugas();
            m_petugas.Nama = tbNama.Text;
            m_petugas.Npm = tbNpm.Text;
            m_petugas.Angkatan = tbAngkatan.Text;
            m_petugas.Jabatan = cmbJabatan.Text;
            m_petugas.Nohp = tbNoHP.Text;

            petugas.Update(m_petugas, npm_petugas);
            RefreshForm();
            LoadData();
        }

        public void RefreshForm()
        {
            tbNama.Clear();
            tbNpm.Clear();
            tbAngkatan.Clear();
            tbNoHP.Clear();
            tbCari.Clear();
            cmbJabatan.SelectedIndex = -1;
            npm_petugas = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (npm_petugas == 0)
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                C_Petugas petugas = new C_Petugas();
                petugas.Delete(npm_petugas);
                RefreshForm();
                LoadData();
            }
        }

        private void dgvAnggota_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAnggota.Rows[e.RowIndex];

                npm_petugas = int.Parse(row.Cells[0].Value.ToString());  
                tbNama.Text = row.Cells[1].Value.ToString();             
                tbNpm.Text = row.Cells[0].Value.ToString();              
                tbAngkatan.Text = row.Cells[2].Value.ToString();       
                cmbJabatan.Text = row.Cells[3].Value.ToString();         
                tbNoHP.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dgvAnggota_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
