using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4484
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan();
            Console.Write("Nik : ");
            karyawan1.Nik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nama : ");
            karyawan1.Nama = Console.ReadLine();
            Console.Write("Gaji Bulanan : ");
            karyawan1.Gajibulanan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Karyawan karyawan2 = new Karyawan();
            Console.Write("Nik : ");
            karyawan2.Nik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nama : ");
            karyawan2.Nama = Console.ReadLine();
            Console.Write("Gaji Bulanan : ");
            karyawan2.Gajibulanan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("No Nik/Nama          Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.Write("1. {0} ", karyawan1.Nik);
            Console.Write("{0}", karyawan1.Nama);
            Console.WriteLine("         {0}", karyawan1.Gajibulanan);
            Console.Write("2. {0} ", karyawan2.Nik);
            Console.Write("{0}", karyawan2.Nama);
            Console.Write("         {0}", karyawan2.Gajibulanan);
            Console.WriteLine();
            Console.WriteLine("Asyik Gaji naik 10 %");
            Console.WriteLine("No Nik/Nama          Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.Write("1. {0} ", karyawan1.Nik);
            Console.Write("{0}", karyawan1.Nama);
            Console.WriteLine("         {0}", ((karyawan1.Gajibulanan*0.10)+karyawan1.Gajibulanan));
            Console.Write("2. {0} ", karyawan2.Nik);
            Console.Write("{0}", karyawan2.Nama);
            Console.Write("         {0}", ((karyawan2.Gajibulanan * 0.10) + karyawan2.Gajibulanan));
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
