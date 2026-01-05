using MySql.Data.MySqlClient;
using P9_714240042.controller;
using P9_714240042.model;
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
using System.Text.RegularExpressions;

namespace P9_714240042.view
{
    public partial class FormDataMasterBarang : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Barang m_barang = new M_Barang();
        string id_barang;

        public void Tampil()
        {
            koneksi.OpenConnection();
            DataBarang.DataSource = koneksi.ShowData(
            "SELECT * FROM t_barang"
            );
            
            // Memgubah Nama Kolom Tabel
            DataBarang.Columns[0].HeaderText = "ID";
            DataBarang.Columns[1].HeaderText = "Nama Barang";
            DataBarang.Columns[2].HeaderText = "Harga";
            koneksi.CloseConnection();

        }
        public FormDataMasterBarang()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            textboxNamaBarang.Text = "";
            textboxHarga.Text = "";
            textboxSearch.Text = "";
        }

        private void FormDataMasterBarang_Load_1(object sender, EventArgs e)
        {
            Tampil();
            DataBarang.Columns["harga"].DefaultCellStyle.Format = "C0";
            DataBarang.Columns["harga"].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("id-ID");
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textboxNamaBarang.Text == "" || textboxHarga.Text == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Barang brg = new Barang();
                m_barang.NamaBarang = textboxNamaBarang.Text;
                m_barang.Harga = textboxHarga.Text;
                brg.Insert(m_barang);
                ResetForm();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (textboxNamaBarang.Text == "" || textboxHarga.Text == "")
            {
                MessageBox.Show("Lengkapi data terlebih dahulu!", "Peringatan",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                Barang brg = new Barang();
                m_barang.NamaBarang = textboxNamaBarang.Text;
                m_barang.Harga = textboxHarga.Text;
                brg.Update(m_barang, id_barang);
                ResetForm();
                Tampil();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Tampil();
            ResetForm();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show(
                "Apakah yakin akan menghapus data ini?",
                "Perhatian",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (pesan == DialogResult.Yes)
            {
                Barang barang = new Barang();
                barang.Delete(id_barang);
                Tampil();
                ResetForm();
            }
        }

        private void textboxSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM t_barang WHERE nama_barang LIKE @param";
            DataBarang.DataSource = koneksi.ShowDataParam(sql,
                new MySqlParameter("@param", "%" + textboxSearch.Text + "%")
            );
        }

        private void DataBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textboxNamaBarang.Text = DataBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textboxHarga.Text = DataBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
            id_barang = DataBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

    }
}
