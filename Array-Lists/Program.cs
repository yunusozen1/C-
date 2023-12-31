﻿using System;
using System.Collections;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList liste =new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            // verilere erişme
            Console.WriteLine(liste[1]);
            foreach (var item in liste){
                Console.WriteLine(item);
            }

            // AddRange
            string [] renkler = {"kırmızı","sarı","yesil"};
            
            List<int> sayılar = new List<int>(){1,8,3,7,9,92,5};

            liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste){
                Console.WriteLine(item);
            }

            // Sort

            liste.Sort();

            foreach(var item in liste){
                Console.WriteLine(item);
            }

            //Binary Search
            Console.WriteLine(liste.BinarySearch(9));s

            // Reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            
            //Clear
            liste.Clear();
            foreach (var item in liste){
                Console.WriteLine(item);
            }


        }
    }
    
}

