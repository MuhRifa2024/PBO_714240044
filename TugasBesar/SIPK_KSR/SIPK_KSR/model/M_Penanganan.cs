using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPK_KSR.model
{
    internal class M_Penanganan
    {
        string keluhan, tindakan, tindakLanjut, rujukan, foto;
        int idPasien;
        DateTime tanggal;

        public M_Penanganan() { }

        public int IdPasien { get => idPasien; set => idPasien = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Keluhan { get => keluhan; set => keluhan = value; }
        public string Tindakan { get => tindakan; set => tindakan = value; }
        public string TindakLanjut { get => tindakLanjut; set => tindakLanjut = value; }
        public string Rujukan { get => rujukan; set => rujukan = value; }
        public string Foto { get => foto; set => foto = value; }
    }
}
