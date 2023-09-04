using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Siyah");
            renkListesi.Add("Beyaz");

            // Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            // Listeden eleman çıkarma

            sayiListesi.Remove(4);
            renkListesi.Remove("Siyah");

            sayiListesi.RemoveAt(0);
            sayiListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //  Liste içerisinde arama

            if (sayiListesi.Contains(10))
            {
                Console.WriteLine("10 liste içerisinde var");
            }

            // eleman ile indexe erişme

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));


            // Diziyi liste çevirme

            string[] hayvanlar = { "Kedi", "Köpek", "At", "Kus" };

            List<string> hayvanListesi = new List<string>(hayvanlar);

            // Liste temizleme

            hayvanListesi.Clear();

            // List içerisinde nesne tutma

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim = "Ayşe";
            kullanıcı1.Soyisim = "Yılaz";
            kullanıcı1.Yas = 26;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı1.Isim = "Emre";
            kullanıcı1.Soyisim = "Ozen";
            kullanıcı1.Yas = 24;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();

            yeniListe.Add(new Kullanıcılar()
            {
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 25
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı adı: " + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı soyadı: " + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı yaşı: " + kullanıcı.Yas);
            }


        }
    }
    public class Kullanıcılar
    {
        private string isim;

        private string soyisim;

        private int yas;

        public string Isim { get => isim; set => isim = value; }

        public string Soyisim { get => soyisim; set => soyisim = value; }

        public int Yas { get => yas; set => yas = value; }
    }

}

