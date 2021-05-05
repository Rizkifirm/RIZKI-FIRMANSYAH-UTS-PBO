using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Tugas Program Bilangan Fibonacci  Visual C#");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nama        : Rizki Firmansyah");
            Console.WriteLine("NPM         : 1101201062");
            Console.WriteLine("Kelas       : Malam");
            Console.WriteLine("Nama Dosen  : Asep Mabrur Aid,S.T,M.Kom");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("-------------------------------------------");
            Console.Write("Input Bilangan Fibonacci  Ke - 10 : ");

            int x = 1, y = 1, z = 1;
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine("Bilangan Fibonacci = {0}", z + " ");
                z = x + y;
                x = y;
                y = z;
            }
            Console.Read();
        }
    }
}
