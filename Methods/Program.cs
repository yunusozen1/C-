using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        int a=2;
        int b=3;
        Console.WriteLine(a+b);
        int result = Topla(a,b);
        Console.WriteLine(result);

        Methotlar ornek= new Methotlar();

        ornek.ekranaYazdir(Convert.ToString(result));

        ornek.ekranaYazdir(Convert.ToString(a+b));

        int result2 = ornek.ArttirVeTopla(ref a,ref b);

        ornek.ekranaYazdir(Convert.ToString(result2));

        ornek.ekranaYazdir(Convert.ToString(a+b));
    }
    static  int Topla(int deger1, int deger2){
        return(deger1+deger2);
    }
}

class Methotlar{
    public void ekranaYazdir(string veri){
        Console.WriteLine(veri);
    }
    public int ArttirVeTopla(int deger1,int deger2){
        deger1 +=1;
        deger2 +=1;
        return(deger1+deger2);
    }
}
