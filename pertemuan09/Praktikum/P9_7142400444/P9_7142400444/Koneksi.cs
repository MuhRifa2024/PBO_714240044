using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_7142400444
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public object ShowData(string query)
        {
            OpenConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, kon);
            DataTable table = new DataTable();
            adapter.Fill(table);

            CloseConnection();
            return table;
        }
    }
}
