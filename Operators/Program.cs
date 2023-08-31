using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // Atama Ve işlemli Atama

        int x=3;
        int y=3;
        y = y+2;
        Console.WriteLine(y);
        y += 2;
        Console.WriteLine(y);
        y/=1;
        Console.WriteLine(y);
        x*=2;
        Console.WriteLine(x);

        // Mantıksal Operatörler

        bool isSucces = true;
        bool isCompleted = false;

        if(isSucces && isCompleted){
            Console.WriteLine("Perfect");
        }
        if(isSucces || isCompleted){
            Console.WriteLine("Great");
        } 
        if(isSucces && !isCompleted){
            Console.WriteLine("Fine");
        }

        // İlişkisel Opertörler

        int a = 3;
        int b = 4;
        bool sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);
        

        // Aritmetik Opertörler

        int sayi1= 10;
        int sayi2= 5;
        int sayi3= sayi1 / sayi2;
        Console.WriteLine(sayi3);
        sayi3= sayi1*sayi2;
        Console.WriteLine(sayi3);
        sayi3 = sayi1+sayi2;
        Console.WriteLine(sayi3);
        sayi3 = ++sayi1;
        Console.WriteLine(sayi3);

        // % mod 
        int sayi4 = 20%3;
        Console.WriteLine(sayi4);

    }
}

