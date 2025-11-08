using P4_2_714240044;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P4_2_714240044
{
    public class Pasien : Person
    {
        private string keluhan;

        public string Keluhan
        {
            get { return keluhan; }
            set { keluhan = value; }
        }

        // Constructor untuk Pasien
        public Pasien(string name, string prodi, int angkatan, string keluhan)
            : base(name, prodi, angkatan)
        {
            this.keluhan = keluhan;
        }

        // 3️⃣ Polymorphism: override method abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("=== Data Pasien KSR ===");
            Console.WriteLine($"Nama      : {Name}");
            Console.WriteLine($"Prodi     : {Prodi}");
            Console.WriteLine($"Angkatan  : {Angkatan}");
            Console.WriteLine($"Keluhan   : {Keluhan}");
            Console.WriteLine("========================\n");
        }
    }
}
