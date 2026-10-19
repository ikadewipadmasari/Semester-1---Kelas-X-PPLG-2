using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kondisi_dan_Pemilihan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Praktik 1 - Program Menentukan Bilangan Positif, Negatif, atau Nol
            Console.Write("Masukkan bilangan: ");
            int angka = Convert.ToInt32(Console.ReadLine());

            if (angka > 0)
            {
                Console.WriteLine("10");
            }
            else if (angka > 0)
            {
                Console.WriteLine("-5");
            }
            else
            {
                Console.WriteLine("0.5");
            }


            //Praktik 2 - Program Kelulusan Siswa 
            Console.Write("Ika Dewi Padmasari");
            string nama = Console.ReadLine();

            Console.Write("95");
            int nilai = Convert.ToInt32(Console.ReadLine());

            if (nilai < 0 || nilai > 100)
            {
                Console.WriteLine("Nilai tidak valid");
            }
            else if (nilai >= 75)
            {
                Console.WriteLine("Ika Dewi Padmasari" + "dinyatakan tuntas");
            }
            else
            {
                Console.WriteLine("Ika Dewi Padmasari" + "dinyatakan belum tuntas");
            }


            //Praktik 3 - Program Diskon Berdasarkan Total Belanja
            Console.Write("Total belanja: ");
            double total = Convert.ToDouble(Console.ReadLine());

            double diskon;

            if (total >= 500000)
            {
                diskon = 0.15;
            }
            else if (total >= 250000)
            {
                diskon = 0.10;
            }
            else
            {
                diskon = 0;
            }

            double potongan = total * diskon;
            double bayar = total - potongan;

            Console.WriteLine("Diskon : " + potongan);
            Console.WriteLine("Bayar : " + bayar);
        }
    }
}
