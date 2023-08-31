using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // While ile 1den başlayarak console dan girilen sayıya kadar ortalama hesaplama
        Console.WriteLine("Bir sayi gir: ");
        int sayi=int.Parse(Console.ReadLine());
        double ortalama= 0;
        int toplam=0;
        int i = 0;  
        while (i<=sayi)
        {
            toplam +=i;
            i++;
            ortalama = toplam/i;
        }
        Console.WriteLine(ortalama);

        // a dan z ye kadar tüm harfleri console a yazdır
        char character ='a';
        while (character < 'z'){
            Console.WriteLine(character);
            character ++;
        }
        // For each
        string[] arabalar= {"BMW","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar){
            Console.WriteLine(araba);
        }
       
    }
}
