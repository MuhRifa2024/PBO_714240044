using SIPK_KSR.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.controller
{
    internal class C_Petugas
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_Petugas petugas)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO petugas (nama, npm, angkatan, jabatan, no_telp) " +
                    "VALUES (@nama, @npm, @angkatan, @jabatan, @no_telp)"
                );

                cmd.Parameters.AddWithValue("@nama", petugas.Nama);
                cmd.Parameters.AddWithValue("@npm", petugas.Npm);
                cmd.Parameters.AddWithValue("@angkatan", petugas.Angkatan);
                cmd.Parameters.AddWithValue("@jabatan", petugas.Jabatan);
                cmd.Parameters.AddWithValue("@no_telp", petugas.Nohp);

                koneksi.ExecuteQuery(cmd);
                status = true;

                MessageBox.Show("Data berhasil ditambahkan", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public bool Update(M_Petugas petugas, int id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "UPDATE petugas SET nama=@nama, npm=@npm, angkatan=@angkatan, " +
                    "jabatan=@jabatan, no_telp=@no_telp WHERE id_petugas=@id"
                );

                cmd.Parameters.AddWithValue("@nama", petugas.Nama);
                cmd.Parameters.AddWithValue("@npm", petugas.Npm);
                cmd.Parameters.AddWithValue("@angkatan", petugas.Angkatan);
                cmd.Parameters.AddWithValue("@jabatan", petugas.Jabatan);
                cmd.Parameters.AddWithValue("@no_telp", petugas.Nohp);
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                status = true;

                MessageBox.Show("Data berhasil diubah", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public bool Delete(int id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM petugas WHERE id_petugas=@id"
                );

                cmd.Parameters.AddWithValue("@id", id);
                koneksi.ExecuteQuery(cmd);
                status = true;

                MessageBox.Show("Data berhasil dihapus", "Informasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
    }
}
