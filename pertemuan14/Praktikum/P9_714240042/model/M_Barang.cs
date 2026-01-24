using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240042.model
{
    internal class M_Barang
    {
        string nama_barang, harga;

        public M_Barang()
        {
        }

        public M_Barang(string nama_barang, string harga)
        {
            this.NamaBarang = nama_barang;
            this.Harga = harga;
        }

        public string NamaBarang { get => nama_barang; set => nama_barang = value; }
        public string Harga { get => harga; set => harga = value; }
    }
}
