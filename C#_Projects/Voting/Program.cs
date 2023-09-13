using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> categories = new List<string>
        {
            "Film Kategorileri",
            "Tech Stack Kategorileri",
            "Spor Kategorileri"
        };

        Dictionary<string, int> categoryVotes = InitializeCategoryVotes(categories);

        Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "user1", "password1" },
            { "user2", "password2" },
            // Diğer kullanıcılar
        };

        string currentUser = null;

        while (true)
        {
            Console.WriteLine("Hoş geldiniz!");
            Console.Write("Kullanıcı adınızı girin: ");
            string username = Console.ReadLine();

            if (!users.ContainsKey(username))
            {
                Console.WriteLine("Bu kullanıcı adı sistemde kayıtlı değil. Yeni bir hesap oluşturmak ister misiniz? (E/H)");
                string cevap = Console.ReadLine();
                if (cevap.Equals("E", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Yeni şifre oluşturun: ");
                    string password = Console.ReadLine();
                    users.Add(username, password);
                    Console.WriteLine("Yeni kullanıcı kaydınız oluşturuldu.");
                }
                else
                {
                    Console.WriteLine("Oylamaya devam edebilmeniz için kayıt olmanız gerekmektedir.");
                    continue;
                }
            }

            // Kullanıcı girişi başarılı
            currentUser = username;

            while (true)
            {
                Console.WriteLine("Aşağıdaki kategorilerde oy kullanabilirsiniz:");
                for (int i = 0; i < categories.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {categories[i]}");
                }

                Console.WriteLine("Çıkış yapmak için 'Q' tuşuna basın.");
                Console.Write("Oy vermek istediğiniz kategorinin numarasını girin: ");
                string input = Console.ReadLine();

                if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (int.TryParse(input, out int categoryIndex) && categoryIndex >= 1 && categoryIndex <= categories.Count)
                {
                    string selectedCategory = categories[categoryIndex - 1];
                    Console.Write($"'{selectedCategory}' kategorisine oy verin (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out int vote) && vote >= 1 && vote <= 5)
                    {
                        categoryVotes[selectedCategory] += vote;
                        Console.WriteLine("Oyunuz başarıyla kaydedildi!");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz oy. Lütfen 1 ile 5 arasında bir sayı girin.");
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz kategori numarası. Lütfen listeden bir numara seçin.");
                }
            }

            Console.WriteLine("Oylama sonuçları:");
            foreach (var category in categoryVotes)
            {
                Console.WriteLine($"{category.Key}: Toplam Oy - {category.Value}, Yüzde - {((double)category.Value / 5):P}");
            }

            Console.WriteLine("Başka bir işlem yapmak ister misiniz? (E/H)");
            string devamCevabi = Console.ReadLine();
            if (!devamCevabi.Equals("E", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }

        Console.WriteLine("Oylama uygulaması sonlandı. İyi günler!");
    }

    static Dictionary<string, int> InitializeCategoryVotes(List<string> categories)
    {
        Dictionary<string, int> categoryVotes = new Dictionary<string, int>();
        foreach (var category in categories)
        {
            categoryVotes.Add(category, 0);
        }
        return categoryVotes;
    }
}
