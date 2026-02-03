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
    internal class C_Pasien
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_Pasien p)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                     "INSERT INTO pasien (nama_pasien, status, prodi_unit, angkatan) " +
                     "VALUES(@nama_pasien, @status, @prodi_unit, @angkatan)");

                cmd.Parameters.AddWithValue("@nama_pasien", p.Nama);
                cmd.Parameters.AddWithValue("@status", p.Status);
                cmd.Parameters.AddWithValue("@prodi_unit", p.Prodi);
                cmd.Parameters.AddWithValue("@angkatan",
                    p.Angkatan.HasValue ? (object)p.Angkatan.Value : DBNull.Value);

                koneksi.ExecuteQuery(cmd);
                status = true;
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Error");
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public int GetLastId()
        {
            try
            {
                koneksi.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(
                    "SELECT IFNULL(MAX(id_pasien), 0) FROM pasien"
                );

                object result = koneksi.ExecuteScalar(cmd);
                return Convert.ToInt32(result);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error DB: " + e.Message);
                return 0;
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }

        public bool Update(M_Pasien p, int id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(
                   "UPDATE pasien SET nama_pasien=@nama_pasien, status=@status, " +
                   "prodi_unit=@prodi_unit, angkatan=@angkatan WHERE id_pasien=@id"
               );

                cmd.Parameters.AddWithValue("@nama_pasien", p.Nama);
                cmd.Parameters.AddWithValue("@status", p.Status);
                cmd.Parameters.AddWithValue("@prodi_unit", p.Prodi);
                cmd.Parameters.AddWithValue("@angkatan",
                    p.Angkatan.HasValue ? (object)p.Angkatan.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@id", id);

                koneksi.ExecuteQuery(cmd);
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
        
    }
}
