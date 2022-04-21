using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4484
{
    public class Karyawan
    {
        public Karyawan()
        {
        }
        public Karyawan(int nik,string nama, int gajibulanan)
        {
            Nik = nik;
            Nama = nama;
            Gajibulanan = gajibulanan;
        }
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int Gajibulanan { get; set; }
    }
}
