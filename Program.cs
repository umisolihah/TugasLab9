using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasLab9

{
    class Program
    {
        static void Main(string[] args)
        {
            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            void TampilanKaryawan()
            {
                int noUrut = 1;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}, {4}", noUrut, karyawan.Nik, karyawan.Nama, karyawan.Gaji(), karyawan.JK);

                    noUrut++;
                }
            }

            void TambahKaryawanTetap(string nama, string nik, string jk, double gajibulanan)
            {
                listKaryawan.Add(new KaryawanTetap { Nama = nama, Nik = nik, GajiBulanan = gajibulanan, JK = jk });
            }

            void TambahKaryawanHarian(string nama, string nik, string jk, int jumlahjamkerja, int upah)
            {
                listKaryawan.Add(new KaryawanHarian { Nama = nama, Nik = nik, JK = jk, JumlahJamKerja = jumlahjamkerja, UpahPerJam = upah });
            }

            void TambahSales(string nama, string nik, string jk, int jumlahpenjualan, int komisi)
            {
                listKaryawan.Add(new Sales { Nama = nama, Nik = nik, JK = jk, JumlahPenjualan = jumlahpenjualan, Komisi = komisi });
            }

            void HapusKaryawan()
            {
                int no = 1;
                int jumlahkaryawan = 0;

                foreach (Karyawan karyawan in listKaryawan)
                {
                    Console.WriteLine("{0}. NIK : {1}", no, karyawan.Nik);

                    no++;
                    jumlahkaryawan += 1;
                }
                Console.WriteLine();
                Console.Write("Pilih Data Yang Ingin Dihapus [1-");
                Console.Write(jumlahkaryawan);
                Console.Write("] : ");
                int index_nik = int.Parse(Console.ReadLine());
                index_nik = index_nik - 1;

                listKaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data Karyawan Berhasil Dihapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
            }

            bool exit = false;
            while (exit == false)
            {
                Console.Title = "Tugas Lab 9 - Polymorphsim, Inheritance, Abstraction & Collection Part #2";
                Console.WriteLine("Pilih Menu Aplikasi :");
                Console.WriteLine();
                Console.WriteLine("1. Tambah Data Karyawan");
                Console.WriteLine("2. Hapus Data Karyawan");
                Console.WriteLine("3. Tampilkan Data Karyawan");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Nomer Menu [1..4] = ");
                int pilihan = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();

                if (pilihan < 1)
                {
                    Console.WriteLine("Menu Yang Anda Pilih Tidak Tersedia");
                }

                else if (pilihan > 4)
                {
                    Console.WriteLine("Menu Yang Anda Pilih Tidak Tersedia");
                }

                else if (pilihan == 1)
                {
                    Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("Jenis Karyawan [1. Karyawan Tetap, 2. Karyawan Harian, 3. Sales] : ");
                    int jenis_karyawan = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (jenis_karyawan == 1)
                    {
                        Console.Write("Nik = ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write("Gaji Bulanan : ");
                        int gaji_bulanan = int.Parse(Console.ReadLine());
                        string jeniskaryawan = "Karyawan Tetap";

                        TambahKaryawanTetap(nama, nik, jeniskaryawan, gaji_bulanan);
                    }

                    else if (jenis_karyawan == 2)
                    {
                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Jam Kerja : ");
                        int jjk = int.Parse(Console.ReadLine());
                        Console.Write("Upah Per Jam : ");
                        int upah = int.Parse(Console.ReadLine());
                        string jeniskaryawan = "Karyawan Harian";

                        TambahKaryawanHarian(nama, nik, jeniskaryawan, jjk, upah);
                    }

                    else if (jenis_karyawan == 3)
                    {

                        Console.Write("NIK : ");
                        string nik = Console.ReadLine();
                        Console.Write("Nama : ");
                        string nama = Console.ReadLine();
                        Console.Write("Jumlah Penjualan : ");
                        int jumlah_penjualan = int.Parse(Console.ReadLine());
                        Console.Write("Komisi : ");
                        int komisi = int.Parse(Console.ReadLine());
                        string jeniskaryawan = "Sales";

                        TambahSales(nama, nik, jeniskaryawan, jumlah_penjualan, komisi);
                    }
                    else
                    {
                        Console.WriteLine("Menu salah");
                    }
                    Console.WriteLine();
                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");


                }

                else if (pilihan == 2)
                {
                    HapusKaryawan();
                }

                else if (pilihan == 3)
                {
                    Console.WriteLine("Data Karyawan");
                    Console.WriteLine();
                    TampilanKaryawan();

                    Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");
                }

                else if (pilihan == 4)
                {
                    exit = true;
                }

                Console.ReadLine();
            }
        }
    }
}