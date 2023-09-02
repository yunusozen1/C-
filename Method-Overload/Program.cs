using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // Out Parametreler
        string sayi="999";
        int outsayi;

        bool sonuc=int.TryParse(sayi, out outsayi);

        if(sonuc){
            Console.WriteLine("Başarili");
            Console.WriteLine(outsayi);
        }
        else{
            Console.WriteLine("Başarısız");
        }
        Methodlar instance = new Methodlar();
        instance.Topla(4,5,out int ToplamSonuc);
        Console.WriteLine(ToplamSonuc);

        // Methot aşırı yükleme

        int ifade=999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("Emre","Ozen");


    }
    
}

class Methodlar{
    public void Topla(int a,int b, out int toplam){
        toplam=a+b;
        
    }
    public void EkranaYazdir(int veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(string veri1,string veri2){
        Console.WriteLine(veri1+veri2);
    }
}

