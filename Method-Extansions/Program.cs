using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        // Rekürsif - Özyinelemeli

        int result =1;
        for(int i = 1; i < 5;i++)
        {
            result *=3;
        }  
        Console.WriteLine(result);
        Islemler instance = new();
        Console.WriteLine(instance.Expo(3,4));

        string ifade="Emre Ozen";
        bool sonuc = ifade.CheckSpace();
        Console.WriteLine(sonuc);

        if(sonuc){
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.MakeUpper());
        Console.WriteLine(ifade.MakeLower());
        int [] dizi ={9,3,6,2,1,5,0};
        dizi.SortArray();
        dizi.WriteArray();

        int sayi=12;
        Console.WriteLine(sayi.IfEven());
        Console.WriteLine(ifade.GetFirstChar());
    }

    
    
}
public class Islemler{
    public int Expo(int sayi, int üs){
        if(üs<2)
            return sayi;
        return Expo(sayi,üs-1) * sayi; // Expo(3,4)  Expo(3,3) * 3 * 3 Expo(3,2) * 3 * 3 * 3 Expo(3,1) * 3 * 3 * 3 * 3
    }
}
public static class Extansions{
    public static bool CheckSpace(this string param){
        return param.Contains(" ");
    }
    public static string RemoveWhiteSpaces(this string param){
        string [] dizi = param.Split(" ");
        return string.Join("",dizi);

    }
    public static string MakeUpper(this string param){
        
        return param.ToUpper();
    }

    public static string MakeLower(this string param){
        
        return param.ToLower();
    }
    public static int [] SortArray(this int [] param){
        Array.Sort(param);
        return param;

    }
    public static void WriteArray(this int [] param){
        foreach(int item in param){
            Console.WriteLine(item);
        }

    }

    public static bool IfEven(this int param){
        return param%2==0;

    }
    public static string GetFirstChar(this string param){
        return param.Substring(0,1);
    }
    

}


