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

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Tugas Program Bilangan Prima Visual C#");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Nama        : Rizki Firmansyah");
            Console.WriteLine("NPM         : 1101201062");
            Console.WriteLine("Kelas       : Malam");
            Console.WriteLine("Dosen       : Asep Mabrur Aid,S.T,M.Kom");
            Console.WriteLine("Prodi       : Teknik Informatika");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int i, j, counter;
            for (i = 2; i <= 20; i++)
            {
                counter = 0;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    Console.WriteLine("{0} adalah bilangan prima", i);
                }
            }
            Console.ReadLine();
        }
    }
}
