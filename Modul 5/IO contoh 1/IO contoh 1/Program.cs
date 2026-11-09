using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_contoh_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contoh 1: Program Biodata Sederhana
            Console.WriteLine("=== PROGRAM BIODATA SISWA ===");

            Console.Write("Nama : Ika Dewi Padmasari");
            string nama = Console.ReadLine();

            Console.Write("kelas : X PPLG 2 ");
            string kelas = Console.ReadLine();

            Console.Write("Umur : 15");
            int umur = int.Parse(Console.ReadLine());

            Console.Write("Nilai Rata-rata: 88,45 ");
            double nilai = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("=== DATA YANG ANDA MASUKKAN ===");
            Console.WriteLine($"Nama : {nama}");
            Console.WriteLine($"Kelas : {kelas}");
            Console.WriteLine($"Umur : {umur} tahun");
            Console.WriteLine($"Nilai : {nilai}");
        }
    }
}
