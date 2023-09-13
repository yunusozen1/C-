using System;

class DaireCizici
{
    public static void Main(string[] args)
    {
        Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = Convert.ToDouble(Console.ReadLine());

        Daire daire = new Daire(yaricap);
        daire.Ciz();
    }
}

class Daire
{
    private double Yaricap;

    public Daire(double yaricap)
    {
        Yaricap = yaricap;
    }

    public double AlanHesapla()
    {
        return Math.PI * Math.Pow(Yaricap, 2);
    }

    public double CevreHesapla()
    {
        return 2 * Math.PI * Yaricap;
    }

    public void Ciz()
    {
        int daireCizimBoyut = (int)Math.Ceiling(Yaricap);
        for (int i = -daireCizimBoyut; i <= daireCizimBoyut; i++)
        {
            for (int j = -daireCizimBoyut; j <= daireCizimBoyut; j++)
            {
                double uzaklik = Math.Sqrt(i * i + j * j);
                if (uzaklik <= Yaricap)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Dairenin Alanı: {AlanHesapla()}");
        Console.WriteLine($"Dairenin Çevresi: {CevreHesapla()}");
    }
}
