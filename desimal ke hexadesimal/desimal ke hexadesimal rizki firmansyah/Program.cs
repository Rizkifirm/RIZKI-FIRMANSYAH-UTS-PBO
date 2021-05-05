using System;
using System.Collections.Generic;
public class Exercise30
{
    public static void Main()
    {


        Console.WriteLine("Tugas Program Bilangan Desimal Ke Hexadesimal Visual C#"); 
        Console.WriteLine("Nama      : Rizki Firmansyah");
        Console.WriteLine("Npm       : 1101201062");
        Console.WriteLine("Kelas     : Malam");
        Console.WriteLine("Dosen     : Asep Mabrur Aid,S.T,M.Kom");
        Console.WriteLine("Prodi     : Teknik Informatika");
        Console.WriteLine("MK        : Pemgraman Berorientasi Objek");
        string hexval = "4B0";
        Console.WriteLine("Hexadecimal number: " + hexval);
        int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
        Console.WriteLine("Convert to-");
        Console.WriteLine("Decimal number: " + decValue);
    }
}

