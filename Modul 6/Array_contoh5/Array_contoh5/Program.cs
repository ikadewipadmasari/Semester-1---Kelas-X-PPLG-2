using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_contoh5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < a.Length / 2; i++)
            {
                int temp = a[i];                  //simpan sementara
                a[i] = a[a.Length - 1 - i];       //isi dari belakang 
                a[a.Length - 1 - i] = temp;       //isi belakang dengan temp
            }
            foreach (int x in a) Console.Write(x + " ");
        }
    }
}
