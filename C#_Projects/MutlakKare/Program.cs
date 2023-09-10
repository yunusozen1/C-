using System;

class Program
{
    static void Main()
    {
        Console.Write("Kaç tane sayı gireceksiniz: ");
        int n = int.Parse(Console.ReadLine());

        int totalDifference = 0;
        int totalSquaredDifference = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"#{i + 1} Sayıyı girin: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 67)
            {
                totalDifference += 67 - number;
            }
            else
            {
                int difference = number - 67;
                totalSquaredDifference += difference * difference;
            }
        }

        Console.WriteLine($"Küçük olanların farklarının toplamı: {totalDifference}");
        Console.WriteLine($"Büyük olanların farkların mutlak kareleri toplamı: {totalSquaredDifference}");

        Console.ReadLine(); 
    }
}
