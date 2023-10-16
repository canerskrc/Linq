using System;
using System.Linq;
using System.Collections.Generic;

class ABC
{
    //static void Main()
    //{
    //    //
    //    IEnumerable<int> result = ((ParallelQuery<int>)ParallelEnumerable.Range(3, 20))
    //        .Where(n => n % 5 == 0).Select(res => res);
    //    Console.WriteLine("Sayılar : ");
    //    foreach(int sayilar in result)
    //    {
    //        Console.WriteLine(sayilar);
    //    }
    //}

    //static void Main()
    //{
    //    IEnumerable<int> veri = ((ParallelQuery<int>)ParallelEnumerable.Range(
    //        10, 30)).Where(i => i % 2 == 0).Select(deger => deger);

    //    foreach (int cift in veri)
    //    {
    //        Console.WriteLine(cift);
    //    }
    //}


    //static void Main()
    //{
    //    int[] Yas = { 27, 24, 22, 24, 25, 27, 20, 23, 24, 22, 23, 26, 31 };
    //    int toplam = Yas.Sum();
    //    int ort = toplam / Yas.Length;

    //    var oay = from yaslar in Yas where yaslar < ort select yaslar;

    //    Console.WriteLine("Ortalama yaslar : " + ort);
    //    Console.WriteLine("ORtalamanın altında kalan yaslar:");
    //    foreach(int i in oay)
    //    {
    //        Console.WriteLine(i + " ");
    //    }

    //    Console.WriteLine();
    //}

    static void Main()
    {
        List<string> veriler = new List<string>();

        veriler.Add("Caner");
        veriler.Add("abcdsdsdf");
        veriler.Add("abcf");
        veriler.Add("abf");
        veriler.Add("abcd");
        veriler.Add("absds");
        veriler.Add("abcdsfsa");

        IEnumerable<string> sonuc = veriler.Where(ogrenciler => ogrenciler.Length > 4);
        Console.WriteLine("İsmi 4 harften fazla olan öğrenciler:");

        foreach ( string ogradi in sonuc)
        {
            Console.WriteLine(ogradi);
        }
    }
}
