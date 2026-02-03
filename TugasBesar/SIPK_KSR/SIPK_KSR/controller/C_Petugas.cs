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
                     "INSERT INTO petugas (npm, nama_petugas, angkatan, jabatan, no_hp) " +
                     "VALUES (@npm, @nama, @angkatan, @jabatan, @no_hp)"
                 );

                cmd.Parameters.AddWithValue("@nama", petugas.Nama);
                cmd.Parameters.AddWithValue("@npm", petugas.Npm);
                cmd.Parameters.AddWithValue("@angkatan", petugas.Angkatan);
                cmd.Parameters.AddWithValue("@jabatan", petugas.Jabatan);
                cmd.Parameters.AddWithValue("@no_hp", petugas.Nohp);

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
                     "UPDATE petugas SET nama_petugas=@nama, angkatan=@angkatan, " +
                     "jabatan=@jabatan, no_hp=@no_hp WHERE npm=@npm"
                 );

                cmd.Parameters.AddWithValue("@nama", petugas.Nama);
                cmd.Parameters.AddWithValue("@angkatan", petugas.Angkatan);
                cmd.Parameters.AddWithValue("@jabatan", petugas.Jabatan);
                cmd.Parameters.AddWithValue("@no_hp", petugas.Nohp);
                cmd.Parameters.AddWithValue("@npm", petugas.Npm);

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
                    "DELETE FROM petugas WHERE npm=@npm"
                );

                cmd.Parameters.AddWithValue("@npm", npm);
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

        public List<M_Petugas> GetAll()
        {
            List<M_Petugas> listPetugas = new List<M_Petugas>();

            try
            {
                koneksi.OpenConnection();

                var dt = koneksi.ShowData(
                    "SELECT npm, nama_petugas, angkatan, jabatan, no_hp " +
                    "FROM petugas ORDER BY nama_petugas");

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    M_Petugas petugas = new M_Petugas
                    {
                        Npm = row["npm"].ToString(),
                        Nama = row["nama_petugas"].ToString(),  // ← nama_petugas
                        Angkatan = row["angkatan"].ToString(),
                        Jabatan = row["jabatan"].ToString(),
                        Nohp = row["no_hp"].ToString()  // ← no_hp
                    };

                    listPetugas.Add(petugas);
                }

                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }

            return listPetugas;
        }
    }
}
