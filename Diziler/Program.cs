using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // Dizi Tanımlama
       string[] renkler = new string[5];
       string[] hayvanlar= {"Kedi","Köpek","Kuş","Maymun"};
        int[] dizi;
        dizi = new int[5];
        //Dizilere Değer atama ve erişim
        renkler[0]  = "Mavi";
        
        dizi[3]=10;
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(renkler[0]);
        Console.WriteLine(dizi[3]);

        // Döngülerde Dizi

        Console.WriteLine("Dizinin eleman sayisini gir: ");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int [] sayiDizisi = new int[diziUzunlugu];

        for(int i = 0; i < diziUzunlugu;i++){
            Console.WriteLine("{0}. sayiyi gir: ",i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
            
        }
        int toplam=0;
        for(int i = 0; i<diziUzunlugu;i++){
            toplam += sayiDizisi[i];
        }
        Console.WriteLine("Ortalama: "+(toplam/diziUzunlugu));
    }
}
