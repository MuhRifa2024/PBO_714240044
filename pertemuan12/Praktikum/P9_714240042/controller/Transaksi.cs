using MySql.Data.MySqlClient;
using P9_714240042.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240042.controller
{
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        // Method insert
        public bool Insert(M_Transaksi transaksi)
        { 
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id_barang, @qty, @total)");

                cmd.Parameters.AddWithValue("@id_barang", transaksi.Transaksi);
                cmd.Parameters.AddWithValue("@qty", transaksi.Qty);
                cmd.Parameters.AddWithValue("@total", transaksi.Total);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Transaksi berhasil ditambahkan", "Informasi",
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

        // Method update
        public bool Update(M_Transaksi transaksi, string id_barang)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE t_transaksi SET id_barang=@id_barang, qty=@qty, total=@total WHERE id_transaksi=@id");
                cmd.Parameters.AddWithValue("@id_barang", transaksi.Transaksi);
                cmd.Parameters.AddWithValue("@qty", transaksi.Qty);
                cmd.Parameters.AddWithValue("@total", transaksi.Total);
                cmd.Parameters.AddWithValue("@id", transaksi.Id);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Transaksi berhasil diubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        //Method delete
        public bool Delete(string Id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM t_transaksi WHERE id_transaksi=@id");
                cmd.Parameters.AddWithValue("@id", Id);
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
