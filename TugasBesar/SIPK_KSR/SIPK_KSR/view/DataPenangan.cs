using MySql.Data.MySqlClient;
using SIPK_KSR.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.view
{
    public partial class DataPenangan : Form
    {
        Koneksi koneksi = new Koneksi();
        public DataPenangan()
        {
            InitializeComponent();

            CultureInfo culture = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            dtpDari.Format = DateTimePickerFormat.Short;
            dtpSampai.Format = DateTimePickerFormat.Short;
        }

        private void DataPenangan_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetDetailPanel();
        }

        private void LoadData()
        {
            try
            {
                koneksi.OpenConnection();

                string query = @"
                    SELECT 
                        p.id_penanganan,
                        p.tanggal,
                        ps.nama_pasien,
                        ps.status,
                        ps.prodi_unit,
                        ps.angkatan,
                        p.keluhan,
                        p.tindakan,
                        p.tindak_lanjut,
                        p.keterangan_rujukan,
                        p.foto_penanganan,
                        GROUP_CONCAT(pt.nama_petugas SEPARATOR ', ') AS petugas
                    FROM penanganan p
                    INNER JOIN pasien ps ON p.id_pasien = ps.id_pasien
                    LEFT JOIN penanganan_petugas pp ON p.id_penanganan = pp.id_penanganan
                    LEFT JOIN petugas pt ON pp.npm_petugas = pt.npm
                    GROUP BY p.id_penanganan
                    ORDER BY p.tanggal DESC";

                dataGridDaftar.DataSource = koneksi.ShowData(query);

                SetupDataGridView();

                koneksi.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridDaftar.Columns["id_penanganan"].Visible = false;
            dataGridDaftar.Columns["prodi_unit"].Visible = false;
            dataGridDaftar.Columns["angkatan"].Visible = false;
            dataGridDaftar.Columns["tindakan"].Visible = false;
            dataGridDaftar.Columns["keterangan_rujukan"].Visible = false;
            dataGridDaftar.Columns["foto_penanganan"].Visible = false;

            dataGridDaftar.Columns["tanggal"].HeaderText = "Tanggal";
            dataGridDaftar.Columns["nama_pasien"].HeaderText = "Nama Pasien";
            dataGridDaftar.Columns["status"].HeaderText = "Status";
            dataGridDaftar.Columns["keluhan"].HeaderText = "Keluhan";
            dataGridDaftar.Columns["tindak_lanjut"].HeaderText = "Tindak Lanjut";
            dataGridDaftar.Columns["petugas"].HeaderText = "Petugas";

            dataGridDaftar.DefaultCellStyle.ForeColor = Color.Black;
            dataGridDaftar.DefaultCellStyle.BackColor = Color.White;
            dataGridDaftar.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dataGridDaftar.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridDaftar.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;

        }

        private void ResetDetailPanel()
        {
            lblNamaPasien.Text = "Nama: -";
            lblStatus.Text = "Status: -";
            lblProdi.Text = "Prodi: -";
            lblAngkatan.Text = "Angkatan: -";
            lblTanggal.Text = "Tanggal: -";
            tbKeluhanDetail.Clear();
            tbTindakanDetail.Clear();
            lblTindakLanjut.Text = "Tindak Lanjut: -";
            lblKeteranganRujuk.Text = "Keterangan: -";
            lbPetugas.Items.Clear();
            pbFoto.Image = null;
        }

        private void textBoxCari_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxCari.Text.Trim();

            if (keyword == "")
            {
                LoadData();
                return;
            }

            try
            {
                string query = @"
                    SELECT 
                        p.id_penanganan,
                        p.tanggal,
                        ps.nama_pasien,
                        ps.status,
                        ps.prodi_unit,
                        ps.angkatan,
                        p.keluhan,
                        p.tindakan,
                        p.tindak_lanjut,
                        p.keterangan_rujukan,
                        p.foto_penanganan,
                        GROUP_CONCAT(pt.nama_petugas SEPARATOR ', ') AS petugas
                    FROM penanganan p
                    INNER JOIN pasien ps ON p.id_pasien = ps.id_pasien
                    LEFT JOIN penanganan_petugas pp ON p.id_penanganan = pp.id_penanganan
                    LEFT JOIN petugas pt ON pp.npm_petugas = pt.npm
                    WHERE ps.nama_pasien LIKE @param
                       OR ps.status LIKE @param
                       OR p.keluhan LIKE @param
                       OR p.tindakan LIKE @param
                       OR pt.nama_petugas LIKE @param
                    GROUP BY p.id_penanganan
                    ORDER BY p.tanggal DESC";

                dataGridDaftar.DataSource = koneksi.ShowDataParam(
                    query,
                    new MySqlParameter("@param", "%" + keyword + "%")
                );

                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error search: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dari = dtpDari.Value.Date;
                DateTime sampai = dtpSampai.Value.Date.AddDays(1).AddSeconds(-1);

                string query = @"
                    SELECT 
                        p.id_penanganan,
                        p.tanggal,
                        ps.nama_pasien,
                        ps.status,
                        ps.prodi_unit,
                        ps.angkatan,
                        p.keluhan,
                        p.tindakan,
                        p.tindak_lanjut,
                        p.keterangan_rujukan,
                        p.foto_penanganan,
                        GROUP_CONCAT(pt.nama_petugas SEPARATOR ', ') AS petugas
                    FROM penanganan p
                    INNER JOIN pasien ps ON p.id_pasien = ps.id_pasien
                    LEFT JOIN penanganan_petugas pp ON p.id_penanganan = pp.id_penanganan
                    LEFT JOIN petugas pt ON pp.npm_petugas = pt.npm
                    WHERE p.tanggal BETWEEN @dari AND @sampai
                    GROUP BY p.id_penanganan
                    ORDER BY p.tanggal DESC";

                dataGridDaftar.DataSource = koneksi.ShowDataParam(
                    query,
                    new MySqlParameter("@dari", dari),
                    new MySqlParameter("@sampai", sampai)
                );

                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filter: " + ex.Message);
            }
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            textBoxCari.Clear();
            dtpDari.Value = DateTime.Now.AddMonths(-1);
            dtpSampai.Value = DateTime.Now;
            LoadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetDetailPanel();
        }

        private void dataGridDaftar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridDaftar.Rows[e.RowIndex];

                // Ambil data dari row
                int idPenanganan = Convert.ToInt32(row.Cells["id_penanganan"].Value);

                // Tampilkan detail
                TampilkanDetail(row);
            }
        }

        private void TampilkanDetail(DataGridViewRow row)
        {
            try
            {
                // Data Pasien
                lblNamaPasien.Text = "Nama: " + row.Cells["nama_pasien"].Value.ToString();
                lblStatus.Text = "Status: " + row.Cells["status"].Value.ToString();
                lblProdi.Text = "Prodi: " + (row.Cells["prodi_unit"].Value?.ToString() ?? "-");

                if (row.Cells["angkatan"].Value != DBNull.Value)
                    lblAngkatan.Text = "Angkatan: " + row.Cells["angkatan"].Value.ToString();
                else
                    lblAngkatan.Text = "Angkatan: -";

                // Data Penanganan
                DateTime tanggal = Convert.ToDateTime(row.Cells["tanggal"].Value);
                lblTanggal.Text = "Tanggal: " + tanggal.ToString("dddd, dd MMMM yyyy");

                tbKeluhanDetail.Text = row.Cells["keluhan"].Value.ToString();
                tbTindakanDetail.Text = row.Cells["tindakan"].Value.ToString();
                lblTindakLanjut.Text = "Tindak Lanjut: " + row.Cells["tindak_lanjut"].Value.ToString();
                lblKeteranganRujuk.Text = "Keterangan: " + (row.Cells["keterangan_rujukan"].Value?.ToString() ?? "-");

                // Petugas (split by comma)
                lbPetugas.Items.Clear();
                string petugasStr = row.Cells["petugas"].Value?.ToString();
                if (!string.IsNullOrEmpty(petugasStr))
                {
                    string[] petugasList = petugasStr.Split(new[] { ", " }, StringSplitOptions.None);
                    foreach (string petugas in petugasList)
                    {
                        lbPetugas.Items.Add("• " + petugas);
                    }
                }

                // Foto
                string fotoUrl = row.Cells["foto_penanganan"].Value?.ToString();
                if (!string.IsNullOrEmpty(fotoUrl))
                {
                    try
                    {
                        pbFoto.Load(fotoUrl);
                    }
                    catch
                    {
                        pbFoto.Image = null;
                    }
                }
                else
                {
                    pbFoto.Image = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error tampilkan detail: " + ex.Message);
            }
        }


    }
}
