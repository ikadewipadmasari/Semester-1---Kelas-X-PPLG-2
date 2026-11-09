using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_contoh3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PENCARIAN DATA (LINEAR SEARCH)
            int[] data = { 12, 7, 25, 3, 18 };
            int dicari = 25;
            int posisi = -1;                // -1 artinya belum ditemukan

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == dicari)
                {
                    posisi = i;
                    break;                  // berhenti jika sudah ketemu
                }

            }
            if (posisi != -1)
                Console.WriteLine(dicari + " ditemukan pada indeks " + posisi);
            else
                Console.WriteLine(dicari + " tidak ditemukan");
        }
    }
}
