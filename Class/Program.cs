using System;
using System.Collections;

namespace sınıflar
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //  class SinifAdi 
            // {
            //     [Erişim Belirleyici] [Veri Tipi] OzellikAdi;
            //     [Erişim Belirleyici] [Geri Dönüş Tipi] Metot Adi([Parametre Listesi])
            //     {
            //         Metot komutları
            //     }
            // }

            // Erişim Belirleyiciler 
            // * Public
            // * Private
            // * Internal
            // * Protected
            Calisan calisan1= new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=232131;
            calisan1.Departman="İnsan Kaynakları";

            calisan1.CalisanBilgi();
            
            Console.WriteLine("********");

            Calisan calisan2= new Calisan();
            calisan2.Ad="Emre";
            calisan2.Soyad="Ozen";
            calisan2.No=152120;
            calisan2.Departman="Bilgi İşlem";

            calisan2.CalisanBilgi();

        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgi(){
            Console.WriteLine("Çalışan adı:{0}",Ad);
            Console.WriteLine("Çalışan soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan numarası:{0}",No);
            Console.WriteLine("Çalışan departmanı:{0}",Departman);
        }
    }

}

