using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman (21.11.4491)";

            while (true)
            {
                TampilMenu();

                Console.WriteLine("Pilih Menu Aplikasi");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Mahasiswa");
                Console.WriteLine("2. Tampilkan Mahasiswa");
                Console.WriteLine("3. Keluar");

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        System.Environment.Exit(0);
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahMahasiswa()
        {
            Console.Clear();
            Mahasiswa Mahasiswa = new Mahasiswa();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.Write("NIM: ");
            Mahasiswa.nim = Console.ReadLine();

            Console.Write("Nama: ");
            Mahasiswa.nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P]: ");
            Mahasiswa.Kelamin = Console.ReadLine();
            if (Mahasiswa.Kelamin == "L"){
                Mahasiswa.Kelamin = "Laki-laki";
            }else if (Mahasiswa.Kelamin == "P"){
                Mahasiswa.Kelamin = "Perempuan";
            }

            Console.Write("IPK : ");
            Mahasiswa.total = Console.ReadLine();

            daftarMahasiiswa.Add(Mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Data Mahasiswa");
            int no = 1;

            Console.WriteLine("No| \tNIM| \t|Nama| \tJenis Kelamin| \tIPk");
            foreach(Mahasiswa mahasiswa in daftarMahasiswa){
                Console.WriteLine("{0}.|\t{1}\t{2} |\t{3}  |\t{4}");
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
