using System;
using System.Collections;

namespace Algoritma{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bir ifade gir virgül koy bir sayı gir: ");
            string ifade=(Console.ReadLine());
            string [] cümle=ifade.Split(",");
            string kelime= cümle[0];
            int sayi=int.Parse(cümle[1]);
            Console.WriteLine(kelime.Remove(sayi,1));
            
        }

        
    }

}