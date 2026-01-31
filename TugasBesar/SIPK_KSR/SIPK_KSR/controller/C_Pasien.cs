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
                    "INSERT INTO pasien (nama, status, prodi, angkatan)" +
                    "VALUES(@nama, @status, @prodi, @angkatan)");

                cmd.Parameters.AddWithValue("@nama", p.Nama);
                cmd.Parameters.AddWithValue("@status", p.Status);
                cmd.Parameters.AddWithValue("@prodi", p.Prodi);
                cmd.Parameters.AddWithValue("@angkatan", p.Angkatan);

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


    }
}
