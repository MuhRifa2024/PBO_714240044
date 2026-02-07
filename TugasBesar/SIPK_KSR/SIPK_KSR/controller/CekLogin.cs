using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPK_KSR.controller
{
    internal class CekLogin
    {
        public bool cek_login(string username, string password)
        {
            Koneksi koneksi = new Koneksi();
            try
            {
                
                string query = "SELECT id_user FROM t_user WHERE username=@username AND password=@password LIMIT 1";

                MySqlParameter[] param = new MySqlParameter[]
                {
                    new MySqlParameter("@username", username),
                    new MySqlParameter("@password", password)
                };

                DataTable result = koneksi.ShowDataParam(query, param);

                return result.Rows.Count > 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
