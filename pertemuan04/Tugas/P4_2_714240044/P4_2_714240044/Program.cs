using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240044
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Membuat beberapa objek pasien
            Pasien p1 = new Pasien("Rifaidi", "Informatika", 2022, "Demam");
            Pasien p2 = new Pasien("Galuh", "Keperawatan", 2023, "Pusing");
            Pasien p3 = new Pasien("Bagas", "Informatika", 2023, "Maag");

            // Menampilkan data pasien
            p1.DisplayInfo();
            p2.DisplayInfo();
            p3.DisplayInfo();
        }
    }
}
