using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman3405
{
    class Program
    {
        static void Main(string[] args)
        {
            datakaryawan karyawan = new datakaryawan();
            karyawan.nik = "190302123";
            karyawan.nama = "Paijo";
            karyawan.gajibulanan = "3,000,000";
            karyawan.nik = "190302124";
            karyawan.nama = "Jono";
            karyawan.gajibulanan = "2,000,000";

            Console.WriteLine("NIK = 190302123 ");
            Console.WriteLine("Nama = Paijo ");
            Console.WriteLine("Gaji Bulanan = 3,000,000");
            Console.WriteLine("NIK = 190302124 ");
            Console.WriteLine("Nama = Jono ");
            Console.WriteLine("Gaji Bulanan = 2,000,000");
        }
    }
}
