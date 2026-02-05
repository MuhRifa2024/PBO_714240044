using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPK_KSR.model
{
    internal class M_Petugas
    {
        string nama, npm, jabatan, nohp, angkatan;

        public M_Petugas()
        {
        }

        public M_Petugas(string nama, string npm, string jabatan, string nohp, string angkatan)
        {
            this.Nama = nama;
            this.Jabatan = jabatan;
            this.Angkatan = angkatan;
            this.npm = npm;
            this.nohp = nohp;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Jabatan { get => jabatan; set => jabatan = value; }
        public string Angkatan { get => angkatan; set => angkatan = value; }
        public string Npm { get => npm; set => npm = value; }
        public string Nohp { get => nohp; set => nohp = value; }

        public override string ToString()
        {
            return $"{Nama} - {Npm}";
        }
    }
}
