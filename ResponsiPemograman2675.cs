using System;
using System.Runtime.CompilerServices;

namespace ResponsiPemrograman2675
{
    class Karyawan
    {
        public string Nik { set; get; }
        public string Nama { set; get; }
        public int GajiBulanan { set; get; }
        public int newGaji { set; get; }

        public Karyawan(string newNik, string newNama, int newGajiBulanan)
        {
            Nik = newNik;
            Nama = newNama;
            GajiBulanan = newGajiBulanan;
            if (newGajiBulanan < 0)
            {
                GajiBulanan = 0;
            }
        }

        public void getGajiBaru()
        {
            int bonusGaji = GajiBulanan / newGaji;
            GajiBulanan = GajiBulanan + bonusGaji;
            Console.WriteLine("{0} {1}\t\t\t{2}", Nik, Nama, GajiBulanan);
        }

        public void getKaryawan()
        {
            Console.WriteLine("{0} {1}\t\t\t{2}", Nik, Nama, GajiBulanan);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NIK/Nama\t\t\tGaji bulanan\n------------------------------------------------");
            Karyawan karyawan = new Karyawan("19112675", "lakey", 1000000);
            karyawan.getKaryawan();
            
            Karyawan karyawan2 = new Karyawan("19112657", "firman", 3000000);
            karyawan2.getKaryawan();

            Console.WriteLine("\n\nNIK/Nama\t\t\tGaji bulanan\n------------------------------------------------");
            karyawan.newGaji = 10;
            karyawan.getGajiBaru();

            karyawan2.newGaji = 10;
            karyawan2.getGajiBaru();
        }
    }
}