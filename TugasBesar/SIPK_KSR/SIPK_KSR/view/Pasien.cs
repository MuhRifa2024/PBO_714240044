using MySql.Data.MySqlClient;
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
    public partial class Pasien : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Pasien m_pasien = new M_Pasien();
        int id_pasien = 0;
        public Pasien()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                koneksi.OpenConnection();

                dgvPasien.DataSource = koneksi.ShowData(
                    "SELECT id_pasien, nama_pasien, status, prodi_unit, angkatan " +
                    "FROM pasien ORDER BY nama_pasien");

                SetupDataGridView();

                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message);
            }
        }

        private void SetupDataGridView()
        {
            dgvPasien.Columns[0].HeaderText = "ID";
            dgvPasien.Columns[1].HeaderText = "Nama Pasien";
            dgvPasien.Columns[2].HeaderText = "Status";
            dgvPasien.Columns[3].HeaderText = "Prodi/Unit";
            dgvPasien.Columns[4].HeaderText = "Angkatan";

            // Sembunyikan kolom ID (opsional)
            dgvPasien.Columns[0].Visible = false;

            dgvPasien.DefaultCellStyle.ForeColor = Color.Black;
            dgvPasien.DefaultCellStyle.BackColor = Color.White;
            dgvPasien.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dgvPasien.DefaultCellStyle.SelectionForeColor = Color.White;
        }



        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtCari.Text.Trim();

            if (keyword == "")
            {
                LoadData();
                return;
            }

            string sql =
                "SELECT id_pasien, nama_pasien, status, prodi_unit, angkatan " +
                "FROM pasien " +
                "WHERE CAST(id_pasien AS CHAR) LIKE @param " +
                "OR nama_pasien LIKE @param " +
                "OR status LIKE @param " +
                "OR prodi_unit LIKE @param " +
                "OR CAST(angkatan AS CHAR) LIKE @param " +
                "ORDER BY nama_pasien";

            dgvPasien.DataSource = koneksi.ShowDataParam(
                sql,
                new MySqlParameter("@param", "%" + keyword + "%")
            );

            SetupDataGridView();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNama.Text))
            {
                MessageBox.Show("Nama pasien wajib diisi!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNama.Focus();
                return;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Status wajib dipilih!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStatus.Text == "Mahasiswa" && string.IsNullOrEmpty(txtAngakatan.Text))
            {
                MessageBox.Show("Angkatan wajib diisi untuk mahasiswa!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAngakatan.Focus();
                return;
            }

            // Cek apakah INSERT atau UPDATE
            if (id_pasien == 0)
            {
                // INSERT data baru
                InsertData();
            }
            else
            {
                // UPDATE data yang ada
                UpdateData();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void Pasien_Load(object sender, EventArgs e)
        {
            LoadData();

            // Setup ComboBox Status
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Mahasiswa");
            cmbStatus.Items.Add("Dosen");
            cmbStatus.Items.Add("Staf");
            cmbStatus.SelectedIndex = -1;

            // Disable angkatan by default
            txtAngakatan.Enabled = false;
            txtAngakatan.BackColor = Color.LightGray;
        }

        private void dgvPasien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPasien.Rows[e.RowIndex];

                // Simpan ID pasien yang dipilih
                id_pasien = Convert.ToInt32(row.Cells[0].Value);

                // Isi form dengan data dari row
                txtNama.Text = row.Cells[1].Value.ToString();
                cmbStatus.Text = row.Cells[2].Value.ToString();
                txtProdi.Text = row.Cells[3].Value.ToString();

                if (row.Cells[4].Value != DBNull.Value)
                {
                    txtAngakatan.Text = row.Cells[4].Value.ToString();
                }
                else
                {
                    txtAngakatan.Clear();
                }
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "Mahasiswa")
            {
                txtAngakatan.Enabled = true;
                txtAngakatan.BackColor = Color.White;
            }
            else
            {
                txtAngakatan.Enabled = false;
                txtAngakatan.BackColor = Color.LightGray;
                txtAngakatan.Clear();
            }
        }

        private void InsertData()
        {
            try
            {
                M_Pasien pasien = new M_Pasien
                {
                    Nama = txtNama.Text,
                    Status = cmbStatus.Text,
                    Prodi = txtProdi.Text,
                    Angkatan = int.TryParse(txtAngakatan.Text, out int angkatanValue)
                        ? (int?)angkatanValue
                        : null
                };

                C_Pasien controller = new C_Pasien();

                if (controller.Insert(pasien))
                {
                    MessageBox.Show("Data berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insert: " + ex.Message);
            }
        }

        private void UpdateData()
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin mengubah data ini?",
                    "Konfirmasi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    M_Pasien pasien = new M_Pasien
                    {
                        Nama = txtNama.Text,
                        Status = cmbStatus.Text,
                        Prodi = txtProdi.Text,
                        Angkatan = int.TryParse(txtAngakatan.Text, out int angkatanValue)
                            ? (int?)angkatanValue
                            : null
                    };

                    C_Pasien controller = new C_Pasien();

                    if (controller.Update(pasien, id_pasien))
                    {
                        ClearForm();
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error update: " + ex.Message);
            }
        }

        private void ClearForm()
        {
            txtNama.Clear();
            cmbStatus.SelectedIndex = -1;
            txtProdi.Clear();
            txtAngakatan.Clear();
            txtCari.Clear();

            id_pasien = 0;  // Reset ID

            txtAngakatan.Enabled = false;
            txtAngakatan.BackColor = Color.LightGray;

            txtNama.Focus();
        }
    }
}
