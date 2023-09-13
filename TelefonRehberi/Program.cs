using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> rehber = new Dictionary<string, string>
    {
        {"Kişi 1", "111-111-1111"},
        {"Kişi 2", "222-222-2222"},
        {"Kişi 3", "333-333-3333"},
        {"Kişi 4", "444-444-4444"},
        {"Kişi 5", "555-555-5555"},
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    YeniNumaraKaydet();
                    break;
                case "2":
                    NumaraSil();
                    break;
                case "3":
                    NumaraGuncelle();
                    break;
                case "4":
                    RehberiListele();
                    break;
                case "5":
                    RehberdeAramaYap();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void YeniNumaraKaydet()
    {
        Console.Write("Lütfen isim giriniz: ");
        string isim = Console.ReadLine();
        Console.Write("Lütfen soyisim giriniz: ");
        string soyisim = Console.ReadLine();
        Console.Write("Lütfen telefon numarası giriniz: ");
        string telefon = Console.ReadLine();
        rehber[$"{isim} {soyisim}"] = telefon;
        Console.WriteLine($"{isim} {soyisim} rehbere eklendi.");
    }

    static void NumaraSil()
    {
        Console.Write("Lütfen isim veya soyisim giriniz: ");
        string isimSoyisim = Console.ReadLine();
        if (rehber.ContainsKey(isimSoyisim))
        {
            rehber.Remove(isimSoyisim);
            Console.WriteLine($"{isimSoyisim} rehberden silindi.");
        }
        else
        {
            Console.WriteLine("Aranan kişi rehberde bulunamadı.");
        }
    }

    static void NumaraGuncelle()
    {
        Console.Write("Lütfen isim veya soyisim giriniz: ");
        string isimSoyisim = Console.ReadLine();
        if (rehber.ContainsKey(isimSoyisim))
        {
            Console.Write("Lütfen yeni telefon numarasını giriniz: ");
            string yeniTelefon = Console.ReadLine();
            rehber[isimSoyisim] = yeniTelefon;
            Console.WriteLine($"{isimSoyisim} kişisinin telefon numarası güncellendi.");
        }
        else
        {
            Console.WriteLine("Aranan kişi rehberde bulunamadı.");
        }
    }

    static void RehberiListele()
    {
        Console.WriteLine("Telefon Rehberi");
        Console.WriteLine("**********************************************");
        foreach (var kvp in rehber)
        {
            string[] isimSoyisim = kvp.Key.Split();
            string isim = isimSoyisim[0];
            string soyisim = isimSoyisim[1];
            string telefon = kvp.Value;
            Console.WriteLine($"isim: {isim} Soyisim: {soyisim} Telefon Numarası: {telefon}");
        }
    }

    static void RehberdeAramaYap()
    {
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
        Console.WriteLine("**********************************************");
        Console.WriteLine("(1) İsim veya soyisime göre arama yapmak için");
        Console.WriteLine("(2) Telefon numarasına göre arama yapmak için");
        string aramaTipi = Console.ReadLine();

        Console.Write("Aranacak anahtar kelimeyi giriniz: ");
        string anahtarKelime = Console.ReadLine();

        Console.WriteLine("Arama Sonuçlarınız:");
        Console.WriteLine("**********************************************");
        foreach (var kvp in rehber)
        {
            string[] isimSoyisim = kvp.Key.Split();
            string isim = isimSoyisim[0];
            string soyisim = isimSoyisim[1];
            string telefon = kvp.Value;

            if ((aramaTipi == "1" && (isim.ToLower().Contains(anahtarKelime.ToLower()) || soyisim.ToLower().Contains(anahtarKelime.ToLower()))) ||
                (aramaTipi == "2" && telefon.Contains(anahtarKelime)))
            {
                Console.WriteLine($"isim: {isim} Soyisim: {soyisim} Telefon Numarası: {telefon}");
            }
        }
    }
}
