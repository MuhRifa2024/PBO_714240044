using SIPK_KSR.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SIPK_KSR.controller
{
    internal class C_Penanganan
    {
        Koneksi koneksi = new Koneksi();

        //Insert Penanganan
        public bool Insert(M_Penanganan p)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(
                    @"INSERT INTO penanganan (id_pasien, tanggal, keluhan, tindakan, tindak_lanjut, keterangan, foto_url)
                    VALUES
                      (@id_pasien, @tanggal, @keluhan, @tindakan, @tindak_lanjut, @keterangan_rujukan, @foto_penanganan)");

                cmd.Parameters.AddWithValue("@id_pasien", p.IdPasien);
                cmd.Parameters.AddWithValue("@tanggal", p.Tanggal);
                cmd.Parameters.AddWithValue("@keluhan", p.Keluhan);
                cmd.Parameters.AddWithValue("@keluhan", p.Keluhan);
                cmd.Parameters.AddWithValue("@tindakan", p.Tindakan);
                cmd.Parameters.AddWithValue("@tindak_loanjut", p.TindakLanjut);
                cmd.Parameters.AddWithValue("@keteranga_rujuk", p.Rujukan);
                cmd.Parameters.AddWithValue("@foto_penanganan", p.Foto);

                koneksi.ExecuteQuery(cmd);
                status = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Gagal simpan penanganan\n" + e.Message);
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
                MySqlCommand cmd = new MySqlCommand("SELECT IFNULL(MAX(id_penanganan), 0) FROM penanganan");

                object result = koneksi.ExecuteScalar(cmd);
                return Convert.ToInt32(result);
            }
            catch
            {
                return 0;
            }
            finally
            {
                koneksi.CloseConnection();
            }
        }
    }
}
