using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240042.controller
{
    internal class CekLogin
    {
        Koneksi koneksi = new Koneksi();

        public bool cek_login(string username, string password)
        {
            MySqlDataReader dr = null;
            try
            {
                koneksi.OpenConnection();
                string query = "SELECT 1 FROM t_user WHERE username=@username AND password=@password LIMIT 1";
                MySqlParameter[] param = new MySqlParameter[]
                {
                    new MySqlParameter("@username", username),
                    new MySqlParameter("@password", password)
                };
                dr = koneksi.reader(query, param);
                return dr.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                if (dr != null && !dr.IsClosed) dr.Close();
                koneksi.CloseConnection();
            }
        }
    }
}
