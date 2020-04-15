using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman2909
{
    class karyawan
    {
        public string Nama { get; set; }
        public int gajibulanan { get; set; }
        public int nik { get; set; }
        public int nomor { get; set; }

        public karyawan(int nomor, int nik, int gajibulanan, string nama)
        {
            this.nomor = nomor;
            this.nik = nik;
            this.Nama = nama;

            if (gajibulanan < 0)
            {
                this.gajibulanan = 0;
            }
            else
            {
                this.gajibulanan = gajibulanan;

            }


        }

        public void data()
        {
            Console.WriteLine("{1}\a{11}\a {2}\a{3}", nomor, nik, Nama, gajibulanan);

        }

        public void naikgaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajibulanan;
            gajibulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{1}\a{11}\a {2}\a{3}", nomor, nik, Nama, gajibulanan);
        }

    }

}


