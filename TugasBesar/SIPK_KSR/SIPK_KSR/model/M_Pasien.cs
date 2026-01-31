using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPK_KSR.model
{
    internal class M_Pasien
    {
        string nama, status, prodi;
        int? angkatan;

        public M_Pasien()
        {
        }

        public M_Pasien(string nama, string status, string prodi, int? angkatan)
        {
            this.Nama = nama;
            this.Status = status;
            this.Prodi = prodi;
            this.Angkatan = angkatan;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Status { get => status; set => status = value; }
        public string Prodi { get => prodi; set => prodi = value; }
        public int? Angkatan { get => angkatan; set => angkatan = value; }
    }
}
