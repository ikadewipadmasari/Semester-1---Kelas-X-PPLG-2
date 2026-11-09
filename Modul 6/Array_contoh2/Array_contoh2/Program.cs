using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_contoh2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 90, 98, 60, 85, 70 };

            int max = data[0];          // anggap elemen pertama sebagai yang terbesar
            int min = data[0];          // dan juga yang terkecil

            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] > max) max = data[i];
                if (data[i] < min) min = data[i];
            }

            Console.WriteLine("Nilai tertinggi : " + max);
            Console.WriteLine("Nilai terendah  : " + min);
        }
    }
}
