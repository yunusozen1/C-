using System;
using System.Collections;

namespace Person
{
    class Program
    {
        static void AlanHesapla(int sekilSecim)
        {
            if(sekilSecim==1){
                Console.WriteLine("Dairenin yarıçapını gir: ");
                int yarıcap=int.Parse(Console.ReadLine());
                double alan = yarıcap * yarıcap * 3.14;
                Console.WriteLine("Dairenin alanı: " + alan);
            }
            else if(sekilSecim==2){
                Console.WriteLine("Dikdörtgenin uzun kenarını gir: ");
                int uzunKenar=int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin kısa kenarını gir: ");
                int kısaKenar = int.Parse(Console.ReadLine());
                int alan = kısaKenar * uzunKenar;
                Console.WriteLine("Dikdörtgenin alanı: " + alan);

            }
            
            else if(sekilSecim==3){
                Console.WriteLine("Karenin kenar uzunluğunu gir: ");
                int kenarUzunluk= int.Parse(Console.ReadLine());
                int alan = kenarUzunluk * kenarUzunluk;
                Console.WriteLine("Karenin alanı: " + alan);
            }
            else if(sekilSecim==4){
                Console.WriteLine("Üçgenin taban uzunluğunu gir: ");
                int taban=int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin yüksekliğini gir: ");
                int yükseklik=int.Parse(Console.ReadLine());
                int alan = (taban * yükseklik) / 2;
                Console.WriteLine("Üçgenin alanı: " + alan);
        
            }
        }

        static void CevreHesapla(int sekilSecim){
            if(sekilSecim==1){
                Console.WriteLine("Dairenin yarıçapını gir: ");
                int yarıcap=int.Parse(Console.ReadLine());
                double cevre = 2 * 3.14 * yarıcap;
                Console.WriteLine("Dairenin çevresi: " + cevre);
            }
            else if(sekilSecim==2){
                Console.WriteLine("Dikdörtgenin uzun kenarını gir: ");
                int uzunKenar=int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin kısa kenarını gir: ");
                int kısaKenar = int.Parse(Console.ReadLine());
                int cevre = 2 * (kısaKenar + uzunKenar);
                Console.WriteLine("Dikdörtgenin çevresi: " + cevre);

            }
            
            else if(sekilSecim==3){
                Console.WriteLine("Karenin kenar uzunluğunu gir: ");
                int kenarUzunluk= int.Parse(Console.ReadLine());
                int cevre = 4 * kenarUzunluk;
                Console.WriteLine("Karenin çevresi: " + cevre);
            }
            else if(sekilSecim==4){
                Console.WriteLine("Üçgenin ilk kenar uzunluğunu gir: ");
                int ilkKenar=int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin ikinci kenar uzunluğunu gir: ");
                int ikinciKenar=int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin üçüncü kenar uzunluğunu gir:");
                int ücüncüKenar=int.Parse(Console.ReadLine());
                int cevre = ilkKenar + ikinciKenar + ücüncüKenar;
                Console.WriteLine("Üçgenin çevresi: " + cevre);
        
            }
        }   
        static void Main(string[] args)
        {
            Console.WriteLine("1-Daire 2-Dikdörtgen 3-Kare 4-Üçgen\n "+"Seçim yap: ");
            int sekilSecim = int.Parse(Console.ReadLine());
            Console.WriteLine("1-Alan 2-Çevre");
            int islemSecim = int.Parse(Console.ReadLine());

            if(islemSecim== 1){
                AlanHesapla(sekilSecim);
            }
            else if(islemSecim== 2){
                CevreHesapla(sekilSecim);
            }

        }
        
    }



}