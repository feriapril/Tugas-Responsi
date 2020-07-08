using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();
        private static string nota;
        private static string tanggal;
        private static string customer;
        private static string jenis;
        private static string total;

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            int nota;
            string tanggal, jenis, customer;
            int total;
            Console.Write("Nota: ");
            nota = int.Parse(Console.ReadLine());
            Console.Write("Tanggal: ");
            tanggal = Console.ReadLine();
            Console.Write("Customer: ");
            customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            jenis = Console.ReadLine();
            Console.Write("Total Piutang: ");
            total = int.Parse(Console.ReadLine());
            daftarPenjualan.Add(new Penjualan() { Nota = nota, Tanggal = tanggal, Costumer=customer, Jenis=jenis, Total = total });
            Console.ReadKey();
            Console.Write("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.WriteLine("Hapus Data Customer");
            int hapus;
            bool ga = false;
            Console.WriteLine("Nota : ");
            hapus = int.Parse(Console.ReadLine());
            int x = 0;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (hapus == penjualan.Nota)
                {
                    ga = true;
                    break;
                }
                x++;
            }
            if (ga)
            {
                daftarPenjualan.RemoveAt(x);
                Console.WriteLine("Data Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("Data Tidak Ditemukan");
            }
            x = 0;
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            int no = 1;
            foreach (Penjualan penjualan in daftarPenjualan)
            {
                if (penjualan.Jenis == "T" || penjualan.Jenis == "t")
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Tunai, {4}",
                    no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Total);
                }
                else if (penjualan.Jenis == "K" || penjualan.Jenis == "k")
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}, Tunai, {4}",
                    no, penjualan.Nota, penjualan.Tanggal, penjualan.Costumer, penjualan.Total);
                }
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
