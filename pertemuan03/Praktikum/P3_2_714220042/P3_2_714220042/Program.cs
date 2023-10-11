using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_714220042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan Nilai AnakAyam :");
            int AnakAyam = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ANAK AYAM TURUNLAH " + AnakAyam);
            Console.WriteLine(" ");

            if (AnakAyam <= 0 || AnakAyam > 10)
            {
                Console.WriteLine("Nilai tidak boleh kurang dari 0, dan maksimal bernilai 10");
            }
            else
            {
                for (int x = AnakAyam; x >= 1; x--)
                {
                    if (x == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah 1, mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine($"Anak ayam turunlah {x}, mati satu tinggal lah {x - 1}");
                    }
                }
            }
        }

    }
}

