using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_714220042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Masukan Angka Pertama---");
            Console.Write("Silahkan masukan angka Pertama :");
            Double angka1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Angka Pertama," + angka1);

            Console.WriteLine("---Masukan Angka Kedua---");
            Console.Write("Silahkan masukan angka Kedua :");
            Double angka2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angka kedua," + angka2);

            Double Penjumlahan = angka1 + angka2;
            Console.WriteLine("{0} + {1} = {2}", angka1, angka2, Penjumlahan);

            Double Pengurangan = angka1 - angka2;
            Console.WriteLine("{0} - {1} = {2}", angka1, angka2, Pengurangan);

            Double Perkalian = angka1 * angka2;
            Console.WriteLine("{0} * {1} = {2}", angka1, angka2, Perkalian);

            Double Pembagian = angka1 / angka2;
            Console.WriteLine("{0} / {1} = {2}", angka1, angka2, Pembagian);



        }
    }
}
