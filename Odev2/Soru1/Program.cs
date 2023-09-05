using System;
using System.Collections;

namespace dictionary
{
    class Program
    {
        static bool AsalMi(int sayi)
        {
            if (sayi <= 1)
                return false;

            for (int i = 2; i * i <= sayi; i++)
            {
                if (sayi % i == 0)
                    return false;
            }

            return true;
        }
        
        
        static void Main(string[] args)
        {
            //SORU 1 Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            ArrayList asalSayilar = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            
            int toplam =0;

            Console.WriteLine("20 adet sayi gir ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{i + 1}. sayıyı gir: ");
                int sayi= Convert.ToInt32(Console.ReadLine());

                if (AsalMi(sayi))
                {
                    asalSayilar.Add(sayi);
                }
                else
                {
                    asalOlmayan.Add(sayi);
                }
            }

            asalSayilar.Sort();
            asalSayilar.Reverse();
            
            Console.WriteLine("Asal sayilar");
            foreach (int item in asalSayilar)
            {
                Console.WriteLine(item);
                toplam +=item;
                 
            }
            Console.WriteLine("Eleman sayisi: " + asalSayilar.Count);
            Console.WriteLine("Ortalama: " + (toplam/asalSayilar.Count));
            
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            
            Console.WriteLine("Asal olmayan sayilar");
            foreach (int item in asalOlmayan)
            {
                Console.WriteLine(item);
                toplam += item;
            }
            Console.WriteLine("Eleman sayisi: " + asalOlmayan.Count);
            Console.WriteLine("Ortalama: " + (toplam/asalOlmayan.Count));
        }
    }

}

