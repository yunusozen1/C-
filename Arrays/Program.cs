﻿using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // sort

        int [] sayiDizisi = { 23, 12, 4,86,72,3,11,17};
        foreach (var sayi in sayiDizisi){
            Console.WriteLine(sayi);
        }
        Console.WriteLine("Sirali Dizi");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi){
            Console.WriteLine(sayi);
        }
        // Clear
        Console.WriteLine("Array Clear");
        Array.Clear(sayiDizisi,2,2);
        foreach (var sayi in sayiDizisi){
            Console.WriteLine(sayi);
        }
        // Reverse
        Console.WriteLine("Reverse");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi){
            Console.WriteLine(sayi);
        }

        //IndexOf
        Console.WriteLine("IndexOf");
        
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //Resize
        Console.WriteLine("Resize");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8]=99;
        foreach (var sayi in sayiDizisi){
            Console.WriteLine(sayi);
        }
    }
}
