using System;
using System.Collections;

namespace dictionary
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
            //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            int [] sayilar = new int[20];
            int length1 = sayilar.Length;            
            
            Console.WriteLine("20 adet sayi gir ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı gir: ");
                int sayi= Convert.ToInt32(Console.ReadLine());
                sayilar[i]=sayi;

            }

            Array.Sort(sayilar);

            int [] enBüyükler = new int[3];
            int length3 = enBüyükler.Length;
            int [] enKüçükler = new int[3];
            int length2=enKüçükler.Length;

            for(int i = 0;i<length2;i++){
                enKüçükler[i]=sayilar[i];
            }
            for(int i = 0;i<length3;i++){
                enBüyükler[i]=sayilar[sayilar.Length-i-1];
            }
            
            Console.WriteLine("En büyük 3 sayi");
            foreach (int item in enBüyükler){
                Console.WriteLine(item);
            }
            Console.WriteLine("En küçük 3 sayi");
            foreach(int item in enKüçükler){
                Console.WriteLine(item);

            }

            double bOrtalama= enBüyükler.Sum() / 3.0;
            double kOrtalama= enKüçükler.Sum() / 3.0;
            double toplamOrt = bOrtalama + kOrtalama;
            Console.WriteLine("En büyük sayilarin ortalaması: " + bOrtalama);
            Console.WriteLine("En küçük sayilarin ortalaması: " + kOrtalama);
            Console.WriteLine("Ortalama toplam: " + toplamOrt);



            
        }
    }

}

