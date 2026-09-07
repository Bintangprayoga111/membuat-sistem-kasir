using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirDiskon
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("=== Input Data Barang ===");
            Console.Write("Inputkan Nama Barang\t: ");
            string nama = Console.ReadLine();
            
            Console.Write("Inputkan Harga Barang\t: ");
            double harga = double.Parse(Console.ReadLine()); // Menggunakan double untuk harga
            
            Console.Write("Inputkan jumlah barang\t: ");
            int jumlah = int.Parse(Console.ReadLine());
            
            Console.Write("Inputkan Diskon (%)\t: ");
            double diskon = double.Parse(Console.ReadLine());

            // LOGIKA PERHITUNGAN YANG DIPERBAIKI
            double subtotal = harga * jumlah;
            double besarDiskon = (diskon / 100) * subtotal;
            double totalBelanja = subtotal - besarDiskon;

            // OUTPUT STRUK KASIR
            Console.WriteLine("\n=== Struk Kasir Sederhana ===");
            Console.WriteLine($"Nama Barang\t: {nama}");
            Console.WriteLine($"Harga Satuan\t: Rp {harga}");
            Console.WriteLine($"Jumlah\t\t: {jumlah}");
            Console.WriteLine($"Subtotal\t: Rp {subtotal}");
            Console.WriteLine($"Diskon ({diskon}%)\t: Rp {besarDiskon}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total Belanja\t: Rp {totalBelanja}");
            Console.WriteLine("================================");

            Console.ReadKey();
        }
    }
}

