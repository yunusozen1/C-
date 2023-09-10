using System;
using System.Collections;

namespace Üçgen{
    class Program
    {
        
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin boyutunu gir: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i <= n;i++){
                
                for(int j = 0;j<=n-i;j++){
                    Console.Write(" ");
                }

                for(int j = 1;j <= 2 * i-1;j++){
                    Console.Write("*");
                }
                Console.WriteLine();

            }  
        }

        
    }

}