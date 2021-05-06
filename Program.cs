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
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Tugas Program Konversi Dari Bilangan Desimal Ke Biner  Visual C#");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Nama        : Rizki Firmansyah");
            Console.WriteLine("NPM         : 1101201062");
            Console.WriteLine("Kelas       : Malam");
            Console.WriteLine("Dosen       : Asep Mabrur Aid,S.T,M.Kom");
            Console.WriteLine("Prodi       : Teknik Informatika (Malam)");
            Console.WriteLine("Semester    : 2 (Genap)");
            Console.WriteLine("Mata Kuliah : Pemrograman Berorientasi Objek");
            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Input Angka Desimal Yang akan di Konversi Yaitu 4 :  ");


            int bilangan, sisa;
            string hasil = "";
            bilangan = Convert.ToInt32(Console.ReadLine());
            while (bilangan > 0)
            {
                sisa = bilangan % 4;
                bilangan /= 4;
                hasil = sisa.ToString() + hasil;
            }
            Console.WriteLine("Hasil Konversi Ke Biner = 10 : {0}", hasil);
        }
    }
}
