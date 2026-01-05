using P9_714240042.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace P9_714240042.controller
{
    internal class Barang
    {
        Koneksi koneksi = new Koneksi();

        // Method insert
        public bool Insert(M_Barang barang)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO t_barang (nama_barang, harga) VALUES (@nama_barang, @harga)");
                cmd.Parameters.AddWithValue("@nama_barang", barang.NamaBarang);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data Barang berhasil ditambahkan", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        // Method update
        public bool Update(M_Barang barang, string id) 
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand("UPDATE t_barang SET nama_barang=@nama_barang, harga=@harga WHERE id_barang = @id");
                cmd.Parameters.AddWithValue("@nama_barang", barang.NamaBarang);
                cmd.Parameters.AddWithValue("@harga", barang.Harga);
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;
        }

        // Method delete
        public bool Delete(string id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_barang WHERE id_baran=@id"
                );
                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            return status;

        }
    }
}
