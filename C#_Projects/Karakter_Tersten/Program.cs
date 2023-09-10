using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("İşlem yapmak istediğin şekli gir : ");
        string sekil = Console.ReadLine();
        if (sekil == "Kare")
        {
            Console.WriteLine("Kenar uzunluğunu gir: ");
            int uzunluk = int.Parse(Console.ReadLine());
            Console.WriteLine("Hesaplamak istediğin değeri gir: ");
            string deger = Console.ReadLine();
            if (deger == "Alan")
            {
                int alan = uzunluk * uzunluk;
                Console.WriteLine(alan);
            }
        }


    }

    static string YerDegistir(string cumle)
    {
        // Cümlenin kelimelerini ayırıyoruz.
        string[] kelimeler = cumle.Split(' ');

        // Her kelimenin ilk ve son harfini yer değiştiriyoruz.
        for (int i = 0; i < kelimeler.Length; i++)
        {
            string kelime = kelimeler[i];
            if (kelime.Length > 1)
            {
                char ilkHarf = kelime[0];
                char sonHarf = kelime[kelime.Length - 1];
                kelime = sonHarf + kelime.Substring(1, kelime.Length - 2) + ilkHarf;
                kelimeler[i] = kelime;
            }
        }

        // Yeniden birleştirilmiş cümleyi oluşturuyoruz.
        string yeniCumle = string.Join(" ", kelimeler);

        return yeniCumle;
    }
}
