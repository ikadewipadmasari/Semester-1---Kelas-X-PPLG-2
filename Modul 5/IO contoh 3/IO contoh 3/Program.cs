using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_contoh_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Contoh 3 : Program Konversi Suhu (Input -> Proses -> Output)

            Console.Write("Masukkan suhu dalam celcius:   ");
            double celcius = double.Parse(Console.ReadLine());

            double fahrenheit = (celcius * 9 / 5) + 32;
            double reamur = celcius * 4 / 5;

            Console.WriteLine("\n=== HASIL KONVERSI ===");
            Console.WriteLine($"Celcius    : {celcius} °C");
            Console.WriteLine($"Fahrenheit : {fahrenheit} °F");
            Console.WriteLine($"Reamur     : {reamur} °R");
        }
    }
}
