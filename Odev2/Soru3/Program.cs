using System;
using System.Collections;

namespace dictionary
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Bir cümle giriniz: ");

            string cümle =Convert.ToString(Console.ReadLine().ToLower());
            int n= cümle.Length;
            ArrayList sesliHarfler = new ArrayList();
            
            for(int i = 0; i < n;i++){
                char harf=Convert.ToChar(cümle.Substring(i, 1));
                if(harf=='a'|| harf=='e' || harf=='ı' || harf=='i' || harf=='o' || harf=='ö' || harf=='u' || harf=='ü'){
                    sesliHarfler.Add(harf);
                }
            }
            sesliHarfler.Sort();
            foreach(var item in sesliHarfler){
                Console.Write(item + ", ");
            }
            
            
        }
    }

}

