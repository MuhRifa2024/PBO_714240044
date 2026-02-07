using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using SIPK_KSR.controller;

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
            dataGridDaftar.Columns["keterangan_rujuk"].Visible = false;
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

        }
    }
}
