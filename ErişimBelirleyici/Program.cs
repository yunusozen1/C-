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
            Calisan calisan1= new Calisan("Ayşe","Kara",232131,"İnsan Kaynakları");
            calisan1.CalisanBilgi();
            
            Console.WriteLine("********");

            Calisan calisan2= new Calisan();
            calisan2.Ad="Emre";
            calisan2.Soyad="Ozen";
            calisan2.No=152120;
            calisan2.Departman="Bilgi İşlem";
            calisan2.CalisanBilgi();

            Console.WriteLine("********");

            Calisan calisan3=new Calisan("Zikriye","Ürkmez");
            calisan3.CalisanBilgi();

            
        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no,string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;
            
        }
        public Calisan(string ad, string soyad){
            this.Ad=ad;
            this.Soyad=soyad;
            
            
        }
        public Calisan(){}

        public void CalisanBilgi(){
            Console.WriteLine("Çalışan adı:{0}",Ad);
            Console.WriteLine("Çalışan soyadı:{0}",Soyad);
            Console.WriteLine("Çalışan numarası:{0}",No);
            Console.WriteLine("Çalışan departmanı:{0}",Departman);
        }
    }

}

