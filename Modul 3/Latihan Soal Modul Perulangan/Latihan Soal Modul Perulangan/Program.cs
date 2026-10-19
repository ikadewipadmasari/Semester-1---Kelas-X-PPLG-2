using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Soal_Modul_Perulangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Buat program menggunakan FOR untuk menampilkan PERKALIAN 5 (TABEL 5).
            // Output yang diharapkan:
            // 5 * 1 = 5
            // 5 * 2 = 10
            // ...
            // 5 * 10 = 50

            // JAWABAN
            // Perulangan for dari 1 sampai 10
            for (int i = 1; i <= 10; i++)
            {
                int hasil = 5 * i;
                Console.WriteLine($"5 x {i} = {hasil}");
            }
        }
    }
}
