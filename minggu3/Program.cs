using System;

namespace minggu3
{
    class Program
    {
        static void Maint(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


public class Program
{
    
    public static void test()
    {
        Console.WriteLine("Halo");
    } 
    private static int Test(int a, int b)
    {
        return a + b;
    }

    enum Gender { Pria, Wanita, lainnya};

    enum bulan
    {
        Januari,
        Februari,
        Maret,
        April,
        Mei,
        Juni,
        Juli,
        Agustus,
        Septemebr,
        Oktober,
        November,
        Desember
    }
    private static void printGender(Gender input)
    {
        if (input == Gender.Pria)
        {
            Console.WriteLine("Gendernya adalah Laki-Laki");
        }
        else if (input == Gender.Wanita)
        {
            Console.WriteLine("Gendernya adalah Perempuan");
        }
        else
        {
            Console.WriteLine("Gendernya tidak diketahui");
        }
    }

    private static int GetJumlahHariDariBulan(bulan namabulan)
    {
        int[] outputHari = { 31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30 };
        int inputINT = (int)namabulan;
        return outputHari[inputINT];
    }

    public static void Main(string[] args)
    {
        test();

        int hasil = Test(12, 13);
        Console.WriteLine(hasil);

        Gender jenis = Gender.Pria;
        printGender(jenis);

        int jenisdalamINT = (int)jenis;
        Console.WriteLine(jenisdalamINT);

        bulan moon = bulan.Agustus;
        int jumlahHari = GetJumlahHariDariBulan(moon);
        Console.WriteLine("Bulan " + moon + " mempunyai " + jumlahHari + " Hari");

        string[] arrString = { "Satu", "Dua", "Tiga" };
        Console.WriteLine(arrString[0]);
        Console.WriteLine(arrString.Length);


    } 
}

