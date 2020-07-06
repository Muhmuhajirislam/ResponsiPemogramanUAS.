
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            Console.WriteLine("Nama : Muhammad Muhajir Islam");
            Console.WriteLine("NIM : 19.11.2604");
            Console.WriteLine("Kelas : 19 IF 01");

            bool loop = true;
            while (loop)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Maaf Menu Tidak Tersedia ");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi : ");
            Console.WriteLine("1. Tambah Data\n2. Hapus Data \n3. Tampilkan Data \n4. Keluar");


            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProduk()
        {
            // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection


            Console.Clear();

            Produk produk = new Produk();
            Console.WriteLine("Tambah Produk : ");
            Console.Write("\nKode produk : ");
            produk.KodeProduk = Console.ReadLine();
            Console.Write("Nama produk : ");
            produk.NamaProduk = Console.ReadLine();
            Console.Write("Harga beli : ");
            produk.HargaB = double.Parse(Console.ReadLine());
            Console.Write("Harga jual : ");
            produk.HargaJ = double.Parse(Console.ReadLine());

            daftarProduk.Add(produk);


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

            int nomor = -1,hapus = -1;
            Console.WriteLine("Hapus Data Produk ");
            Console.WriteLine("Masukan kode produk yang akan dihapus : ");
            string kode = Console.ReadLine();
            foreach(Produk produk in daftarProduk)
            {
                nomor++;
                if(produk.KodeProduk == kode);
                {
                    hapus= nomor;

                }

            }
            if(hapus!= -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("Data telah dihapus");
            }
            else
            {
                Console.WriteLine("Kodem produk tidak ada");

            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar produk yang ada di dalam collection

            int nomorUrut = 0;
            Console.WriteLine("Data Produk ");

            foreach (Produk produk in daftarProduk)
            {
                nomorUrut++;
                Console.WriteLine("{0}> Kode produk : {1} \n \t\tNama produk :  {2}  \n\t\tHarga beli :  {3}  \n\t\tHarga jual :  {4}",nomorUrut, produk.KodeProduk,produk.NamaProduk, produk.HargaB, produk.HargaJ);

            }
            if(nomorUrut < 1)
            {
                Console.WriteLine("Data Produk Masih Kosong :(");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }

    
    public class Produk
    {
        // PERINTAH: lengkapi property class produk, sesuai petunjuk soal
        public string KodeProduk {get; set;}
        public string NamaProduk {get; set;}
        public double HargaB {get; set;}
        public double HargaJ {get; set;}
    }

    
}