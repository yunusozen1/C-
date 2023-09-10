using System;
using System.Collections;

namespace Ortalama_Hesaplama{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Bir değer giriniz: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ortalama: "+(Fibonacci(n)/n));
        }

        public static double Fibonacci(int n){

            int a=0;
            int b=1;
            int c;
            double toplam=1;

            for(int i = 2; i <= n;i++){
                
                c=a+b;
                toplam+=c;
                a=b;
                b=c;
                
            }
            return toplam;
            
            
        }
    }

}