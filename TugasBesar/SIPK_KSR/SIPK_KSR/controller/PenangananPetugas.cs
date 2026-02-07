using MySql.Data.MySqlClient;
using SIPK_KSR.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.controller
{
    internal class PenangananPetugas
    {
        Koneksi koneksi = new Koneksi();

        public bool Insert(M_PenangananPetugas pp)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();

                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO penanganan_petugas (id_penanganan, npm_petugas) " +
                    "VALUES (@id_penanganan, @npm_petugas)");

                cmd.Parameters.AddWithValue("@id_penanganan", pp.idPenanganan);
                cmd.Parameters.AddWithValue("@npm_petugas", pp.npm); 
            

                koneksi.ExecuteQuery(cmd);
                status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error insert penanganan_petugas: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
            finally
            {
                koneksi.CloseConnection();
            }

            return status;
        }
    }
}
