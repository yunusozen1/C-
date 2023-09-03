using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Soru 1: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanları console'a yazdırın.

            Console.WriteLine("Bir sayi gir: ");
            int n = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Sayi {i + 1} gir: ");
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (sayiDizisi[i] % 2 == 0)
                    Console.WriteLine(sayiDizisi[i]);
            }

            // Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan m'e eşit veya tam bölünenleri console'a yazdırın.

            Console.WriteLine("Birinci sayiyi gir: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi gir: ");
            int m = int.Parse(Console.ReadLine());
            int[] sayiDizisi2 = new int[n2]; 
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Sayi {i + 1} gir: ");
                int sayi = int.Parse(Console.ReadLine());

                if (sayi % m == 0) 
                {
                    sayiDizisi2[i] = sayi; 
                }
            }
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine(sayiDizisi2[i]); 
            }

            // Soru 3 Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            //Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            //Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            Console.WriteLine("Bir sayi gir: ");
            int n3 = int.Parse(Console.ReadLine());
            string [] kelimeler=new string[n3];
            for (int i = 0;i<n3;i++){
                Console.Write($"Kelime {i+1} gir: ",i+1);
                kelimeler[i]=(Console.ReadLine());

            }
            Array.Reverse(kelimeler);
            for (int i = 0; i < n3; i++)
            {
                Console.WriteLine(kelimeler[i]); 
            }

            // Soru 4 Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
            //Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
            Console.Write("Bir cümle yaz: ");

            string cümle =(Console.ReadLine());
            string []kelime= cümle.Split(' ');
            int harf= cümle.Length;
            int harfSayisi= harf - (kelime.Length-1);
            Console.WriteLine(harfSayisi);
            Console.WriteLine(kelime.Length);


        }
    }
}
