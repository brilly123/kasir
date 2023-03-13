using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace kasir
{
    /// <summary>
    ///Membuat Public Class
    /// </summary>
    /// <remarks> public class dapat membuat operasi menu makanan,minuman,jumlah menu,nama pelanggan,harga menu,total,harga dsbg</remarks>

    public class Array_Cafe
    {
        /// <summary>
        /// operasi menu makanan dan minuman.
        /// </summary>
        public void KasirCafe()
        {
            {
                ///<list>type="daftar"</list> 
                Console.WriteLine("======================================");
                Console.WriteLine("  Selamat Datang Di Silent Cafe   ");
                Console.WriteLine("      Jl.Parangtritis KM 58         ");
                Console.WriteLine("======================================");
                Console.Write("\n");
                Console.WriteLine("   Silahkan Pilih Menu Makanan   ");
                Console.Write("\n");

                //Menampilkan Contoh Menu Makanan Dari yang berat sampai ringan pelanggan dapat melihat menu tersebut

                ///<list>type="daftar"</list> 
                Console.WriteLine("==========MENU MAKANAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Spageti          : Rp. 20000");
                Console.WriteLine("  2. Pudding Roti     : Rp. 15000");
                Console.WriteLine("  3. Nasi Goreng      : Rp. 15000");
                Console.WriteLine("  4. Rice Bowl        : Rp. 20000");
                Console.Write("\n");

                //Menampilkan Contoh Menu Minuman berupa kopi-kopian 


                Console.WriteLine("==========MENU MINUMAN==========");
                Console.Write("\n");
                Console.WriteLine("  1. Americano        : Rp. 15000");
                Console.WriteLine("  2. Mocha Latte      : Rp. 15000");
                Console.WriteLine("  3. Cappuchino       : Rp. 15000");
                Console.WriteLine("  4. Caramel Latte    : Rp. 15000");
                Console.WriteLine("  5. Vanilla Latte    : Rp. 17000");

                Console.Write("\n");

                int jumlah;

                //Looping dengan menginput jumlah menu menggunakan kondisi do while melalui pilihan menu yang tertera


                do
                {
                    Console.Write("\nMasukkan Jumlah menu:  ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);

                //Mendeklarasikan atau mendefiniskan variabel data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;

                //Menampilkan nama pelanggan yang akan memesan 
                Console.WriteLine("===========================");
                Console.Write("Masukkan Nama Pelanggan : ");
                //Mendeklarasikan variabel data string
                string program1 = Console.ReadLine();

                //Looping menggunakan kombinasi array
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //Menampilkan input nama menu yang telah diinput oleh kasir
                        Console.WriteLine("=================================");
                        Console.Write("Masukkan Nama menu Ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //User harus menginput nama menu diatas 0 karakter sampai dengan 50 karakter 
                    ///<remarks>
                    ///(kasir hanya bisa menginput menu 1-50 karakter)
                    ///</remarks>
                    while (nama[i].Length <= 0 || nama[i].Length > 50);

                    do
                    {
                        //Menampilkan input harga data 
                        Console.Write("Masukkan Harga menu Ke-" + (i + 1) + ": ");
                        harga[i] = int.Parse(Console.ReadLine());
                    } //User harus menginput harga menu min 5000 sampai 1000000
                    while (harga[i] <= 4000 || harga[i] >= 1000000);

                }
                ///<list>type="daftar"</list> 
                //Menampilkan menu yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine("Daftar menu Yang Dipilih");
                Console.WriteLine("==========================");
                for (int i = 0; i < jumlah; i++)
                {
                    Console.WriteLine((i + 1) + "." + nama[i] + " " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }

                //Menampilkan total harga pembelian pelanggan
                Console.WriteLine("=========================");
                Console.WriteLine("Total Harga  : Rp" + total);

                do
                {
                    Console.Write("Masukkan Tunai: Rp");
                    bayar = int.Parse(Console.ReadLine());
                    ///<remarks>
                    ///(menampilkan uang kembalian pembelian pelanggan)
                    ///</remarks>
                    //Menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total 
                    kembalian = bayar - total;
                    ///<remarks>
                    ///(menampilkan kekurangan uang yang harus dibayarkan)
                    ///</remarks>

                    ///<remarks>Jika uang yang dibayarkan kurang maka otomatis tertulis ",maaf uang tidak cukup"</remarks>
                    //Kondisi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Maaf Uang Tidak Cukup !");
                    }


                    //Kondisi dimana input uang yang diberikan lebih dan menambahkan uang kembalian
                    else
                    {
                        Console.WriteLine("Uang kembalian anda : Rp." + kembalian);
                    }

                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan: {0}", program1.ToString());
                Console.Write("\n");
                //Meanmpilkan tanggal dan waktu transaksi pembelian.
                Console.WriteLine("Tanggal Transaksi:" + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("========================================");
                Console.WriteLine("Nama Kasir  : Moh Firdaus MNI");
                Console.WriteLine("Terima Kasih");
                Console.WriteLine("========================================");

                //Mencetak nota pelanggan pemesan dengan menggunakan streamwritter
                using (StreamWriter sw = new StreamWriter(@"C:\Nota\sample2.txt"))//merupakan lokasi file nota dicetak
                {
                    sw.WriteLine("==========================================");
                    sw.WriteLine("============= NOTA PEMBAYARAN ============");
                    sw.WriteLine("==========================================");
                    sw.WriteLine("         Nama Barang Yang Dibeli          ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + " " + harga[i]);
                    }
                    sw.WriteLine("+==========================================+");
                    sw.WriteLine("Total Harga       : Rp" + total);
                    sw.WriteLine("Tunai             : Rp" + bayar);
                    sw.WriteLine("Kembalian         : Rp" + kembalian);
                    sw.WriteLine("\n");
                    //Menampilkan nama pelanggan pemesan
                    sw.WriteLine("Nama Pelanggan: {0}", program1.ToString());
                    //Menampilkan tanggal dan waktu transaksi pemesanan
                    sw.WriteLine("Tanggal Transaksi" + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam Transaksi: " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("========================================");
                    sw.WriteLine("Nama Kasir  : Moh Firdaus MNI");
                    sw.WriteLine("Terima Kasih");
                    sw.WriteLine("========================================");
                    Console.WriteLine("\n");
                    Console.WriteLine("Nota Telah Dicetak");
                }
                Console.WriteLine();
                Console.Write("Tekan ENTER untuk Keluar...");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            ///<remarks>
            ///code ini untuk menampilkan hasilnya
            ///</remarks>
            //Memanggil kelas KasirCafe
            Array_Cafe KasirB = new Array_Cafe();
            KasirB.KasirCafe();
        }
    }
}