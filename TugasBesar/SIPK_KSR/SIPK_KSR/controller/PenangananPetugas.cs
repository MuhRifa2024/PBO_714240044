using MySql.Data.MySqlClient;
using SIPK_KSR.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPK_KSR.controller
{
    internal class PenangananPetugas
    {
        Koneksi koneksi = new Koneksi();

        public void Insert(M_PenangananPetugas pp)
        {
            koneksi.OpenConnection();

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO penanganan_petugas (id_penanganan, npm_petugas) VALUES (@id_penanganan, @npm_petugas)");

            cmd.Parameters.AddWithValue("@id_penanganan", pp.idPenanganan);
            cmd.Parameters.AddWithValue("@npm_petigas", pp.npm);

            koneksi.ExecuteScalar(cmd);
            koneksi.CloseConnection();
        }
    }
}
