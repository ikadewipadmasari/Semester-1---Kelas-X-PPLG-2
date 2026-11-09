using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktik_Perulangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. PENGULANGAN FOR
            Console.WriteLine("Pengulangan untuk menampilkan angka 1 sampai 10");

            //perulangan for dimulai di sini
            for (int i = 1; i <= 10; i++)
            {
                //blok kode yang di ulang 
                Console.WriteLine("Angka ke-" + i);
            }

            Console.WriteLine("\nPerulangan selesai.");


            // Variabel untuk menyimpan hasil penjumlahan
            int total = 0;

            Console.WriteLine("Menghitung jumlah angka dari 1 samapai 5");

            // Perulangan for dari 1 hingga 5
            for (int i = 1; i <= 5; i++)
            {
                // Tambahkan nilai i saat ini ke variabel total
                total = total + i; //Bisa juga di tulis sebagai : total += i;

                // Tampilkan proses penjumlahan di setiap langkah
                Console.WriteLine("Menambahkan " + i + ", total sementara = " + total);
            }

            // Tampilkan hasil akhir setelah perulangan selesai
            Console.WriteLine("\nHasil akhir penjumlahan adalah : " + total);


            // 2. Perulangan While
            // Inisialisasi variabel untuk menyimpan input
            string inputuser = "";

            Console.WriteLine("program akan terus berjalan hingga anda mengetik 'keluar'.");

            //Perulangan selama isi variabel inputuser TIDAK SAMA DENGAN "keluar"
            while (inputuser.ToLower() != "keluar")
            {
                Console.Write("\nKetik sesuatu (atau 'keluar' untuk brhenti): ");
                inputuser = Console.ReadLine(); //Baca input dari user

                Console.WriteLine("Anda mengetik: " + inputuser);
            }
            Console.WriteLine("\nProgram selesai. Terima Kasih!");


            //1.Inisialisasi variabel pengitung(counter)
            int hitungan = 5;

            Console.WriteLine("Memulai hitungan mundur:");
            //2.Perulangan 'while'
            //kondisi:selama nilai 'hitungan' lebih besar dari 0
            while (hitungan > 0)
            {
                // blok kode di dalam perulangan
                Console.WriteLine($"Hitungan: {hitungan}");

                //3.Update variabel penghitung (decrement/penguranan
                //Ini PENTING agar perulangan tidak menjadi loop tak terbatas (infinite loop)
                hitungan = hitungan - 1;
                //atau bisa juga ditulis: hitungan--;
            }
            //kode setelah perulangan selesai
            Console.WriteLine("Selesai Hitungan mundur telah berakhir.");


            //1. inisialisasi variabel penghitung (counter)
            int angka = 1;

            Console.WriteLine("Menampilkan angka 1 sampai 20:");

            //2. blok 'do-while'
            do
            {
                //tampilkan nilai variabel 'angka' saat ini 
                Console.WriteLine(angka);

                //tambahkan nilai 'angka' sebanyak 1 (increment)
                angka++;

                //uji kondisi: Loop berlanjut selama 'angka' kurang dari atau sama dengan
            } while (angka <= 20);

            Console.WriteLine("selesai.");



            int angkaa;
            //blok 'do' akan dieksekusi minimal satu kali
            do
            {
                Console.WriteLine("Masukkan angka genap: ");
                //mencoba membaca input dari pengguna
                if (!int.TryParse(Console.ReadLine(), out angka))
                {
                    Console.WriteLine("Input tidak valid. Silahkan masukkan angka.");
                    //jika input tidak valid, set angka = 1 (ganjil) agar loop berlanjut
                    angka = 1;
                    continue;// Lanjutkan ke literasi berikutnya
                }
                //memeriksa apakah angka tersebut ganjil
                if (angka % 2 != 0)
                {
                    Console.WriteLine($"Angka {angka} adalah ganjil. coba lagi.");
                }
                // kondisi diperiksa di akhir. Loop berlanjut selama angka ganjil.
            } while (angka % 2 != 0);
            Console.WriteLine($"selamat! Anda memasukkan angka genap: {angka}");



            int pilihan;

            do
            {
                //tampilkan menu 
                Console.WriteLine("\n=== Menu Aplikasi ===");
                Console.WriteLine("1. Lihat Data");
                Console.WriteLine("2. Tambah Data");
                Console.WriteLine("3. Keluar");
                Console.Write(" Masukan pilihan Anda (1-3)");

                //Baca input pengguna 
                if (int.TryParse(Console.ReadLine(), out pilihan))
                {
                    Console.WriteLine("Pilihan tidak valid. Harap masukan angka 1,2, atau 3.");
                    // Terapkan nilai selain 3 agar loop berlanjut
                    pilihan = 0;
                    continue;
                }

                //Proses pilihan 
                switch (pilihan)
                {
                    case 1:
                        Console.WriteLine("Anda memilih: Lihat Data");
                        break;
                    case 2:
                        Console.WriteLine("Anda memilih: Tambah Data");
                        break;
                    case 3:
                        Console.WriteLine("Program akan berhenti...");
                        break;
                    default:
                        Console.WriteLine("Pilihan di luar jangkauan. Harap masukan 1,2,atau 3");
                        break;
                }

                //Kondisi loop: Lanjutkan selama pilihan bukan 3.
            } while (pilihan != 3);
            Console.WriteLine(" Terima kasih telah mengunakan aplikasi.");



            string ulangiPilihan;

            do
            {
                // --- Blok Proses yang Akan Diulang ---
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Masukan nama Anda: ");
                string nama = Console.ReadLine();
                Console.WriteLine($"Halo, {nama}! Proses telah selesai.");
                //--------------------------------------
                // Pernyataan untuk Mengulang 
                Console.Write("Apakah Anda ingin mengulang lagi? (ya/tidak): ");
                ulangiPilihan = Console.ReadLine().ToLower(); // Mengambil input dan mengubah ke huruf kcil

                Console.WriteLine(); // Baris kosong untuk kerapian 

                // Kondisi di periksa di akhir: Ulagi selama pengguna mengetik "ya" 
            } while (ulangiPilihan == "ya");
            Console.WriteLine("Terima kasih. Program selesai.");
        }
    }
}
