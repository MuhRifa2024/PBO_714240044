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
    internal class Koneksi
    {
        string connectionString = "Server=mysql-rifa.alwaysdata.net;Database=rifa_sipk;Uid=rifa;Pwd=muhamad172024;Port=3306;";
        MySqlConnection kon;

        public MySqlConnection GetConnection()
        {
            if (kon == null)
                kon = new MySqlConnection(connectionString);

            return kon;
        }

        public void OpenConnection()
        {
            if (kon == null)
                kon = new MySqlConnection(connectionString);

            if (kon.State == ConnectionState.Closed)
                kon.Open();
        }

        public void CloseConnection()
        {
            if (kon != null && kon.State == ConnectionState.Open)
                kon.Close();
        }

        public DataTable ShowData(string query)
        {
            DataTable table = new DataTable();
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand(query, kon);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(table);

            CloseConnection();
            return table;
        }

        public void ExecuteQuery(MySqlCommand cmd)
        {
            cmd.Connection = kon;
            cmd.ExecuteNonQuery();
        }

        public object ExecuteScalar(MySqlCommand cmd)
        {
            cmd.Connection = kon;
            return cmd.ExecuteScalar();
        }

        public DataTable ShowDataParam(string query, params MySqlParameter[] parameters)
        {
            DataTable table = new DataTable();

            try
            {
                OpenConnection();

                MySqlCommand cmd = new MySqlCommand(query, kon);

                // Tambahkan parameter ke command
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return table;
        }

        public MySqlDataReader reader(string query, params MySqlParameter[] parameters)
        {
            OpenConnection();

            MySqlCommand cmd = new MySqlCommand(query, kon);

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            // PENTING: CommandBehavior.CloseConnection agar koneksi otomatis tutup saat reader di-close
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
