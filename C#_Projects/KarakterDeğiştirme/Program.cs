using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir string ifade girin: ");
        string ifade = Console.ReadLine();

        if (string.IsNullOrEmpty(ifade))
        {
            Console.WriteLine("Geçersiz ifade girdiniz.");
            return;
        }

        string sonuc = SwapFirstAndLast(ifade);
        Console.WriteLine("Sonuç: " + sonuc);
    }

    static string SwapFirstAndLast(string ifade)
    {
        if (ifade.Length < 2)
        {
            return ifade; // İfade uzunluğu 1 veya daha az ise değişiklik yapma
        }

        char[] karakterDizisi = ifade.ToCharArray();

        // İlk karakter ile son karakterin yerini değiştir
        char temp = karakterDizisi[0];
        karakterDizisi[0] = karakterDizisi[ifade.Length - 1];
        karakterDizisi[ifade.Length - 1] = temp;

        return new string(karakterDizisi);
    }
}
