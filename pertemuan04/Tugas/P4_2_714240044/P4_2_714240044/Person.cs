using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240044
{

    public abstract class Person
    {
        // 4️⃣ Encapsulation: field dan property
        private string name;
        private string prodi;
        private int angkatan;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Prodi
        {
            get { return prodi; }
            set { prodi = value; }
        }

        public int Angkatan
        {
            get { return angkatan; }
            set
            {
                if (value >= 2000 && value <= DateTime.Now.Year)
                    angkatan = value;
            }
        }

        // 5️⃣ Constructor
        public Person(string name, string prodi, int angkatan)
        {
            this.name = name;
            this.prodi = prodi;
            this.angkatan = angkatan;
        }

        // 1️⃣ Abstraction: method abstrak
        public abstract void DisplayInfo();
    }
}
