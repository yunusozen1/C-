using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // Ekrandan girilen sayıya kadar olan tek sayıları yazdır
        Console.Write("Bir sayi gir: ");
        int sayi=int.Parse(Console.ReadLine());

        for (int i = 0; i < sayi; i++)
        {
            if(i %2 !=0){
                Console.WriteLine(i);
            }
        }

        // 1 ile 1000 arasındaki tek ve çift sayıların kendi içinde toplamlarını yazdır

        int tekToplam=0;
        int ciftToplam=0;
        for(int i=0;i<1000;i++){
            if(i%2 !=0){
                tekToplam +=i;
            }
            else{
                ciftToplam +=i;
            }
        }
        Console.WriteLine(tekToplam);
        Console.WriteLine(ciftToplam);

        //break, continue
        for(int i=1;i<10;i++){
            if(i==4)
                break;
            Console.WriteLine(i);
        }
        for(int i=0;i<10;i++){
            if(i==4)
                continue;
            Console.WriteLine(i);
        } 
       
    }
}
