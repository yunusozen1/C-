using System;
using System.Collections;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, string> kullanıcılar = new Dictionary<int,string>();

            kullanıcılar.Add(10, "Emre");
            kullanıcılar.Add(12, "Ozen");
            kullanıcılar.Add(18, "Deniz Arda");
            kullanıcılar.Add(20, "Özcan Coşar");

            //dizinin elemanlarına erişim
            Console.WriteLine(kullanıcılar[12]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);                
            }
            //Count

            Console.WriteLine(kullanıcılar.Count);

            //Contains 
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar){
                Console.WriteLine(item);
            }

            //Keys
            foreach (var item in kullanıcılar.Keys){
                Console.WriteLine(item);

            }
            //Values
            foreach (var item in kullanıcılar.Values){
                Console.WriteLine(item);

            }

        }
    }
    
}

