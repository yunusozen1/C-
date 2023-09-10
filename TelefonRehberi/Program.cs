using System;
using System.Collections;


namespace Struct{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            kullanıcıBilgi kullanıcı1 = new kullanıcıBilgi("Emre","Yunus",1234);
            kullanıcıBilgi kullanıcı2 = new kullanıcıBilgi("Yusuf","Selman",2345);
            kullanıcıBilgi kullanıcı3 = new kullanıcıBilgi("Zehra","Ozkan",3456);
            kullanıcıBilgi kullanıcı4 = new kullanıcıBilgi("Zeynep","Taskın",4567);
            kullanıcıBilgi kullanıcı5 = new kullanıcıBilgi("Nail","Ozen",5678);

            kullanıcı1.KullanıcıBilgileri();
            kullanıcı2.KullanıcıBilgileri();
            kullanıcı3.KullanıcıBilgileri();
            kullanıcı4.KullanıcıBilgileri();
            kullanıcı5.KullanıcıBilgileri();

        }
    }

    class kullanıcıBilgi
    {
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public int Numara { get; set; }

        
        public kullanıcıBilgi(){}

        public kullanıcıBilgi(string isim,string soyisim,int numara){
            this.Isim = isim;
            this.Soyisim=soyisim;
            this.Numara = numara;

        }
        public void KullanıcıBilgileri(string isim,string soyisim,int numara){
            Console.WriteLine("Kullanıcı ismi: " + this.Isim);
            Console.WriteLine("Kullanıcı soyismi: " + this.Isim);
            Console.WriteLine("Kullanıcı telefon numarası: " + this.Numara);
        }
       
    }

    
    
    

}

