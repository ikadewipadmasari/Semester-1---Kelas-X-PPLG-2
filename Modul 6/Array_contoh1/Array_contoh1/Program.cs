using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_contoh1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nilai = { 75, 80, 85, 90, 95 };
            int total = 0;

            for (int i = 0; i < nilai.Length; i++)
            {
                total += nilai[i];          // total = total + nilai[i]
            }

            double rata = (double)total / nilai.Length;

            Console.WriteLine("Total     : " + total);
            Console.WriteLine("Rata-rata : " + rata);
        }
    }
}
