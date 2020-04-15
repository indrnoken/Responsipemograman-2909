using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemograman2909
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan im = new karyawan(1, 082238, "acer", 20000);
            karyawan him = new karyawan(2, 39898474, "sam", 2800000);

            Console.WriteLine("no \anik \a \a nama \a gaji bulanan");
            im.data();
            him.data();



            Console.WriteLine("no \anik \a \a nama \a gaji bulanan");
            im.naikgaji();
            him.naikgaji();


            Console.ReadKey();





        }
    }
}
