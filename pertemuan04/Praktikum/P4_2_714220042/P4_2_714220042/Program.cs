using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714220042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Profesi Profesi1 = new Dokter("Dokter", "Jantung");
            Profesi Profesi2 = new Guru("Guru", "Bahasa Inggris");

            Console.WriteLine("\n{0} bedah spesialis Bedah {1}", Profesi1.Jenis, Profesi1.Spesialis);
            Console.WriteLine("\n{0} Sekolah Dasar mata pelajaran {1}", Profesi2.Jenis, Profesi2.Spesialis);
        }
    }
}
