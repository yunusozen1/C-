using System;
using System.Collections;


namespace static_sinif
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
           
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);
            
            Calisan calisan = new Calisan("Emre","Ozen","Bilgi İşlem");

            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan1= new Calisan("Ayşe","Kara","İK");
            Calisan calisan2= new Calisan("Deniz","Arda","İK");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama sonucu: {0}",Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma sonucu: {0}",Islemler.Cikar(100,200));
        }
    }
    
    class Calisan{
        private static int calisanSayisi;

        public static int CalisanSayisi {get => calisanSayisi;}

        private string Isim;
        private string Soyisim;
        private string Departman;
        
        static Calisan(){
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim,string departman){
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;

        }
    }

    static class Islemler{
        public static long Topla(int sayi1,int sayi2) {
            return sayi1+sayi2;
        }

        public static long Cikar(int sayi1,int sayi2){
            return sayi1-sayi2;
        }
    }
       
    

}

