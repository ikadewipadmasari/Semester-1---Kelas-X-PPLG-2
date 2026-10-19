using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan_Soal_Perulangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buat program menggunakan WHILE untuk menampilkan JUMLAH TOTAL DARI BILANGAN 1 SAMPAI
            // OUTPUT YANG DIHARAPKAN:
            // Total = 15

            int i = 1;
            int total = 0;

            // Perulangan while selama i kurang dari atau sama dengan 5
            while (i <= 5)
            {
                total += i; // Menambahkannilai i ke total
                i++;        // Menambah nilai i sebesar 1
            }

            // Menampilkan hasil akhir
            Console.WriteLine($"Total = {total}");
        }
    }
}
