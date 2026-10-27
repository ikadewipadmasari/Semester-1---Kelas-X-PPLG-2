using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_contoh_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contoh 2 : Program Penjumlahan Dua Angka
            Console.WriteLine(" === KALKULATOR PENJUMLAHAN === ");

            Console.Write("7 : ");
            int angka1 = int.Parse(Console.ReadLine());

            Console.WriteLine("6 : ");
            int angka2 = int.Parse(Console.ReadLine());

            int hasil = angka1 + angka2;

            Console.WriteLine($"Hasil: {angka1} + {angka2} = {hasil}");
        }
    }
}
