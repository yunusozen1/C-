using System;
using System.Collections;

namespace Person
{
    class Program
    {
       
          
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıları boşluk bırakarak yazın: ");
            string sayilar=(Console.ReadLine());
            
            string [] gruplar=sayilar.Split(' ');
            for(int i=0;i<gruplar.Length-2;i+=2){
                if(gruplar[i]!=gruplar[i+1]){
                    int sayi1=int.Parse(gruplar[i]);
                    int sayi2=int.Parse(gruplar[i+1]);
                    Console.WriteLine(sayi1+sayi2);
                }
                else{
                    int sayi1 =int.Parse(gruplar[i]);
                    int sayi2 =int.Parse(gruplar[i+1]);

                    Console.WriteLine(Math.Pow((sayi1+sayi2),2));
                }
            }  
            

        }
        
    
    }

    



}