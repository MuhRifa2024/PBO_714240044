using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240042.model
{
    internal class M_Transaksi
    {
        string id_transaksi, id_barang, qty, total;
        public M_Transaksi()
        {
        }

        public M_Transaksi(string id_transaksi, string id_barang, string qty, string total)
        {
            this.Transaksi = id_barang;
            this.Qty = qty;
            this.Total = total;
            this.Id = id_transaksi;
        }

        public string Transaksi { get => id_barang; set => id_barang = value; }
        public string Qty { get => qty; set => qty = value; }
        public string Total { get => total; set => total = value; }
        public string Id { get => id_transaksi; set => id_transaksi = value; }
        }
}
