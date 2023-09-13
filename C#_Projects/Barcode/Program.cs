using System;
using System.IO;
using ZXing;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1. Barkod Üret");
            Console.WriteLine("2. Barkod Oku");
            Console.WriteLine("3. Çıkış");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BarkodUret();
                    break;
                case "2":
                    BarkodOku();
                    break;
                case "3":
                    Console.WriteLine("Çıkılıyor...");
                    return;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void BarkodUret()
    {
        Console.Write("Bir metin veya URL girin: ");
        string input = Console.ReadLine();

        BarcodeWriter barcodeWriter = new BarcodeWriter();
        barcodeWriter.Format = BarcodeFormat.QR_CODE; // QR kodu olarak ayarlanabilir, isteğe bağlı olarak diğer formatlar da kullanılabilir.

        // Barkodu üret
        var barcodeBitmap = barcodeWriter.Write(input);

        // Barkodu dosyaya kaydet
        string fileName = $"{Guid.NewGuid()}.png";
        barcodeBitmap.Save(fileName);

        Console.WriteLine($"Barkod üretildi ve '{fileName}' adında kaydedildi.");
    }

    static void BarkodOku()
    {
        Console.Write("Okunacak barkod dosyasının yolunu girin: ");
        string filePath = Console.ReadLine();

        if (File.Exists(filePath))
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            var barcodeBitmap = (Bitmap)Image.FromFile(filePath);

            // Barkodu oku
            var barcodeResult = barcodeReader.Decode(barcodeBitmap);

            if (barcodeResult != null)
            {
                Console.WriteLine("Barkod başarıyla okundu:");
                Console.WriteLine(barcodeResult.Text);
            }
            else
            {
                Console.WriteLine("Barkod okuma hatası.");
            }
        }
        else
        {
            Console.WriteLine("Belirtilen dosya mevcut değil.");
        }
    }
}
