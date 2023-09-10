using System;

namespace SessizHarf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir ifade giriniz: ");
            string ifade = Console.ReadLine();
            string sessizharfler = "zyvtşsrpnrmlkhjğgdçcb";
            string[] cümle = ifade.Split(' ');

            foreach (string word in cümle)
            {
                bool check = false;
                for (int i = 0; i < word.Length-1; i++)
                {


                    if (sessizharfler.Contains(word[i]) && sessizharfler.Contains(word[i + 1]))
                    {
                        check = true;
                        break;
                    }


                }
                Console.Write(check + " ");
            }





        }
    }

}