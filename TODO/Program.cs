using System;
using System.Collections.Generic;

enum Buyukluk
{
    XS = 1,
    S,
    M,
    L,
    XL
}

class Kart
{
    public string Baslik { get; set; }
    public string Icerik { get; set; }
    public int AtananKisiID { get; set; }
    public Buyukluk Buyukluk { get; set; }
    public string Line { get; set; }

    public Kart(string baslik, string icerik, int atananKisiID, Buyukluk buyukluk)
    {
        Baslik = baslik;
        Icerik = icerik;
        AtananKisiID = atananKisiID;
        Buyukluk = buyukluk;
        Line = "TODO"; // Yeni kartlar varsayılan olarak TODO line'ında oluşturulur.
    }
}

class TakimUye
{
    public int ID { get; set; }
    public string AdSoyad { get; set; }

    public TakimUye(int id, string adSoyad)
    {
        ID = id;
        AdSoyad = adSoyad;
    }
}

class Program
{
    static List<Kart> kartlar = new List<Kart>();
    static List<TakimUye> takimUyeleri = new List<TakimUye>();

    static void Main()
    {
        // Varsayılan olarak bir takım ve kartlar ekleyin.
        takimUyeleri.Add(new TakimUye(1, "Takim Uye 1"));
        takimUyeleri.Add(new TakimUye(2, "Takim Uye 2"));
        takimUyeleri.Add(new TakimUye(3, "Takim Uye 3"));

        kartlar.Add(new Kart("Kart 1", "Kart 1 Icerik", 1, Buyukluk.XS));
        kartlar.Add(new Kart("Kart 2", "Kart 2 Icerik", 2, Buyukluk.S));
        kartlar.Add(new Kart("Kart 3", "Kart 3 Icerik", 3, Buyukluk.M));

        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    BoardListele();
                    break;
                case "2":
                    KartEkle();
                    break;
                case "3":
                    KartSil();
                    break;
                case "4":
                    KartTasi();
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void BoardListele()
    {
        Console.WriteLine("TODO Line");
        Console.WriteLine("************************");
        foreach (var kart in kartlar)
        {
            if (kart.Line == "TODO")
            {
                Console.WriteLine($"Başlık: {kart.Baslik}\nİçerik: {kart.Icerik}\nAtanan Kişi: {GetTakimUyeAdi(kart.AtananKisiID)}\nBüyüklük: {kart.Buyukluk}\n-");
            }
        }

        Console.WriteLine("IN PROGRESS Line");
        Console.WriteLine("************************");
        foreach (var kart in kartlar)
        {
            if (kart.Line == "IN PROGRESS")
            {
                Console.WriteLine($"Başlık: {kart.Baslik}\nİçerik: {kart.Icerik}\nAtanan Kişi: {GetTakimUyeAdi(kart.AtananKisiID)}\nBüyüklük: {kart.Buyukluk}\n-");
            }
        }

        Console.WriteLine("DONE Line");
        Console.WriteLine("************************");
        bool doneLineBos = true;
        foreach (var kart in kartlar)
        {
            if (kart.Line == "DONE")
            {
                Console.WriteLine($"Başlık: {kart.Baslik}\nİçerik: {kart.Icerik}\nAtanan Kişi: {GetTakimUyeAdi(kart.AtananKisiID)}\nBüyüklük: {kart.Buyukluk}\n-");
                doneLineBos = false;
            }
        }

        if (doneLineBos)
        {
            Console.WriteLine("~ BOŞ ~");
        }
    }

    static void KartEkle()
    {
        Console.Write("Başlık Giriniz: ");
        string baslik = Console.ReadLine();
        Console.Write("İçerik Giriniz: ");
        string icerik = Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz: (1) XS, (2) S, (3) M, (4) L, (5) XL");
        if (Enum.TryParse(Console.ReadLine(), out Buyukluk buyukluk))
        {
            Console.Write("Kişi Seçiniz (ID): ");
            if (int.TryParse(Console.ReadLine(), out int atananKisiID))
            {
                if (takimUyeleri.Exists(uye => uye.ID == atananKisiID))
                {
                    kartlar.Add(new Kart(baslik, icerik, atananKisiID, buyukluk));
                    Console.WriteLine("Kart başarıyla eklendi.");
                }
                else
                {
                    Console.WriteLine("Hatalı bir Kisi ID girdiniz!");
                }
            }
            else
            {
                Console.WriteLine("Hatalı bir Kisi ID girdiniz!");
            }
        }
        else
        {
            Console.WriteLine("Hatalı bir Büyüklük seçtiniz!");
        }
    }

    static void KartSil()
    {
        Console.Write("Silmek istediğiniz kartın başlığını yazınız: ");
        string baslik = Console.ReadLine();

        var silinecekKartlar = kartlar.FindAll(kart => kart.Baslik == baslik);
        if (silinecekKartlar.Count == 0)
        {
            Console.WriteLine("Aranan kart board'da bulunamadı.");
            return;
        }

        Console.WriteLine("Aşağıdaki kartları buldum. Hangisini silmek istersiniz?");
        for (int i = 0; i < silinecekKartlar.Count; i++)
        {
            Console.WriteLine($"{i + 1}. Başlık: {silinecekKartlar[i].Baslik}");
        }

        Console.WriteLine($"{silinecekKartlar.Count + 1}. Silmeyi sonlandır");

        if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= silinecekKartlar.Count)
        {
            kartlar.Remove(silinecekKartlar[secim - 1]);
            Console.WriteLine("Kart başarıyla silindi.");
        }
        else if (secim == silinecekKartlar.Count + 1)
        {
            Console.WriteLine("Silmeyi sonlandırdınız.");
        }
        else
        {
            Console.WriteLine("Geçersiz bir seçim yaptınız.");
        }
    }

    static void KartTasi()
    {
        Console.Write("Taşımak istediğiniz kartın başlığını yazınız: ");
        string baslik = Console.ReadLine();

        var kart = kartlar.Find(kart => kart.Baslik == baslik);
        if (kart == null)
        {
            Console.WriteLine("Aranan kart board'da bulunamadı.");
            return;
        }

        Console.WriteLine("Bulunan Kart Bilgileri:");
        Console.WriteLine($"Başlık: {kart.Baslik}\nİçerik: {kart.Icerik}\nAtanan Kişi: {GetTakimUyeAdi(kart.AtananKisiID)}\nBüyüklük: {kart.Buyukluk}\nLine: {kart.Line}");

        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO, (2) IN PROGRESS, (3) DONE");
        if (int.TryParse(Console.ReadLine(), out int secim) && secim >= 1 && secim <= 3)
        {
            switch (secim)
            {
                case 1:
                    kart.Line = "TODO";
                    break;
                case 2:
                    kart.Line = "IN PROGRESS";
                    break;
                case 3:
                    kart.Line = "DONE";
                    break;
            }
            Console.WriteLine("Kart başarıyla taşındı.");
        }
        else
        {
            Console.WriteLine("Geçersiz bir seçim yaptınız.");
        }
    }

    static string GetTakimUyeAdi(int id)
    {
        var uye = takimUyeleri.Find(uye => uye.ID == id);
        return uye != null ? uye.AdSoyad : "Bilinmeyen Kişi";
    }
}
