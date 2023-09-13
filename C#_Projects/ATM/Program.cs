using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> accounts = new Dictionary<string, decimal>
        {
            { "123456", 1000.00M },
            { "789012", 5000.00M },
            // Diğer hesaplar
        };

        string logFilePath = "transaction_log.txt";

        Console.WriteLine("ATM'ye hoş geldiniz!");
        Console.Write("Kullanıcı adınızı girin: ");
        string username = Console.ReadLine();

        if (!accounts.ContainsKey(username))
        {
            Console.WriteLine("Geçersiz kullanıcı adı. Çıkıyor...");
            return;
        }

        while (true)
        {
            Console.WriteLine("\nLütfen yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1. Para Çekme");
            Console.WriteLine("2. Para Yatırma");
            Console.WriteLine("3. Bakiye Sorgulama");
            Console.WriteLine("4. Gün Sonu");
            Console.WriteLine("5. Çıkış");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ParaCekme(username, accounts, logFilePath);
                    break;
                case "2":
                    ParaYatirma(username, accounts, logFilePath);
                    break;
                case "3":
                    BakiyeSorgulama(username, accounts);
                    break;
                case "4":
                    GunSonu(username, accounts, logFilePath);
                    break;
                case "5":
                    Console.WriteLine("Çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void ParaCekme(string username, Dictionary<string, decimal> accounts, string logFilePath)
    {
        Console.Write("Çekmek istediğiniz miktarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (amount <= 0)
            {
                Console.WriteLine("Geçersiz miktar. Lütfen pozitif bir miktar girin.");
                return;
            }

            if (accounts[username] >= amount)
            {
                accounts[username] -= amount;
                Console.WriteLine($"Başarıyla {amount:C2} çektiniz.");
                LogTransaction(logFilePath, $"{username} - Para Çekme: {amount:C2}");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye. İşlem gerçekleştirilemedi.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz miktar. Lütfen geçerli bir miktar girin.");
        }
    }

    static void ParaYatirma(string username, Dictionary<string, decimal> accounts, string logFilePath)
    {
        Console.Write("Yatırmak istediğiniz miktarı girin: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            if (amount <= 0)
            {
                Console.WriteLine("Geçersiz miktar. Lütfen pozitif bir miktar girin.");
                return;
            }

            accounts[username] += amount;
            Console.WriteLine($"Başarıyla {amount:C2} yatırdınız.");
            LogTransaction(logFilePath, $"{username} - Para Yatırma: {amount:C2}");
        }
        else
        {
            Console.WriteLine("Geçersiz miktar. Lütfen geçerli bir miktar girin.");
        }
    }

    static void BakiyeSorgulama(string username, Dictionary<string, decimal> accounts)
    {
        decimal balance = accounts[username];
        Console.WriteLine($"Hesap Bakiyeniz: {balance:C2}");
    }

    static void GunSonu(string username, Dictionary<string, decimal> accounts, string logFilePath)
    {
        string eodFileName = $"EOD_{DateTime.Now:ddMMyyyy}.txt";
        using (StreamWriter writer = new StreamWriter(eodFileName))
        {
            writer.WriteLine("Gün Sonu Raporu:");
            writer.WriteLine($"Kullanıcı Adı: {username}");
            writer.WriteLine($"Hesap Bakiyesi: {accounts[username]:C2}");
        }

        Console.WriteLine($"Gün sonu işlemi tamamlandı. Rapor dosyası '{eodFileName}' olarak kaydedildi.");
    }

    static void LogTransaction(string logFilePath, string transaction)
    {
        using (StreamWriter writer = File.AppendText(logFilePath))
        {
            writer.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {transaction}");
        }
    }
}
