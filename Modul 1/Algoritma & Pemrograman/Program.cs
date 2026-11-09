using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma___Pemrograman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input usia pengunjung
            Console.Write("Masukkan usia pengunjung: ");
            int usia = Convert.ToInt32(Console.ReadLine());

            //Input status member card
            Console.Write("Apakah memiliki member card? (Ya/Tidak): ");
            string statusMember = Console.ReadLine().Trim().ToLower();

            int hargaDasar = 0;
            string kategori = "";

            //Menentukan harga tiket berdasarkan usia
            if (usia < 10)
            {
                hargaDasar = 15000;
                kategori = "Anak-Anak";
            }
            else if (usia <= 17)
            {
                hargaDasar = 25000;
                kategori = "Remaja";
            }
            else
            {
                hargaDasar = 40000;
                kategori = "Dewasa";
            }


            //Menghitung diskon jika memiliki member card (10%)
            double diskon = 0;
            string keteranganDiskon = "";

            if (statusMember == "Ya")
            {
                diskon = 0.10 * hargaDasar;
                keteranganDiskon = "Mendapat Diskon Member 10%";
            }
            else
            {
                diskon = 0;
                keteranganDiskon = "Tidak Mendapat Diskon";
            }


            //Menghitung total harga akhir
            double totalHarga = hargaDasar - diskon;

            //Menampilkan Output Ringkasan Pembayaran
            Console.WriteLine("\n==================================");
            Console.WriteLine("       RINCIAN TIKET GAME ZONE      ");
            Console.WriteLine("==================================");
            Console.WriteLine($"Kategori Usia    : {kategori} ({usia} tahun)");
            Console.WriteLine($"Harga Dasar Tiket: Rp {hargaDasar:N0}");
            Console.WriteLine($"Status Member    : {keteranganDiskon}");
            Console.WriteLine($"Potongan Diskon  : Rp {diskon:N0}");
            Console.WriteLine("___________________________________");
            Console.WriteLine($"Total Bayar      : Rp {totalHarga:N0}");
            Console.WriteLine("===================================");
        }
    }
}
 