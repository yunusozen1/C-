using System;
using System.Collections;
using sınıflar;

namespace sınıflar
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
           Ogrenci ogrenci= new Ogrenci("Ayşe","Yılmaz",12345,3);
           ogrenci.OgrenciBilgiGetir();
           Console.WriteLine("********");
           ogrenci.SinifAtlat();
           ogrenci.OgrenciBilgiGetir();
           Console.WriteLine("********");
           Ogrenci ogrenci1= new Ogrenci("Emre","Ozen",15211,1);
           ogrenci1.SınıfDusur();
           ogrenci1.OgrenciBilgiGetir();


            
        }
    }
    class Ogrenci{

        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sınıf;

        public string Isim{
            get { return isim; }
            set { isim = value; }   
        }
        public string Soyisim{
            get {return soyisim;}
            set { soyisim = value;}
        }
        public int OgrenciNo{
            get {return ogrenciNo;}
            set { ogrenciNo = value;}
        }
        public int Sınıf{
            get {return sınıf;}
            set{
                if(value<1){
                    Console.WriteLine("Geçerli bir değer değil");
                    sınıf =1;
                }
                else{
                    sınıf = value;
                }
            }
        }

        public Ogrenci(string isim,string soyisim,int ogrenciNo,int sınıf){
            Isim=isim;
            Soyisim=soyisim;
            OgrenciNo = ogrenciNo;
            Sınıf = sınıf;
        }

        public Ogrenci(){}

        public void OgrenciBilgiGetir(){
            Console.WriteLine("Öğrenci adı:{0}",this.Isim);
            Console.WriteLine("Öğrenci soyadı:{0}",this.Soyisim);
            Console.WriteLine("Öğrenci no:{0}",this.OgrenciNo);
            Console.WriteLine("Öğrenci sınıfı:{0}",this.Sınıf);
        }

        public void SinifAtlat(){
            this.Sınıf = this.Sınıf+1;
        }
        public void SınıfDusur(){
            this.Sınıf=this.Sınıf-1;
        }

       
    }

}

