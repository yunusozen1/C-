using System;
namespace oparetor;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Bir sayı gir: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girdiğin sayi: "+ sayi);
        }
        catch (Exception ex)
        {   
            Console.WriteLine("Hata: " + ex.Message);
        }
        /*finally
        {
            Console.WriteLine("Tamamlandı");
        }*/
        try
        {
            //int a=int.Parse(null);
            //int a=int.Parse("test");
            int a=int.Parse("-200000000000");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Boş değer gir: ");
            Console.WriteLine(ex);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Veri tipi uygun değil. ");
            Console.WriteLine(ex);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Çok küçük ya da çok büyük değer girdiniz. ");
            Console.WriteLine(ex);
        }
    }
}
