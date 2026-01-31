using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPK_KSR.model
{
    internal class M_PenangananPetugas
    {
        int _idPenanganan;
        string npmPetugas;


        public M_PenangananPetugas()
        {
        }

        public M_PenangananPetugas(int idPenanganan, string npm)
        {
            this._idPenanganan = idPenanganan;
            this.npmPetugas = npm;
        }

        public int idPenanganan { get => _idPenanganan; set => _idPenanganan = value; }
        public string npm { get => npmPetugas; set => npmPetugas = value; }
    }
}
