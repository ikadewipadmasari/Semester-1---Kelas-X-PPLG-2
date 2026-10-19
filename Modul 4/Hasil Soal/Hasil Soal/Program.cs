using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hasil_Soal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uangBudi = 100000;
            int uangMakan = 25000;
            int uangMinum = 10000;
            int sisaUang = uangBudi - (uangMakan + uangMinum);
            Console.WriteLine("sisaUang = " + sisaUang);
        }


    }
}
