using System;

namespace SifreMatik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ŞİFREMATİK";
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("=== ŞİFREMATİK ===");
            

            string karakterler = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@#$%^&*";

            Random rnd = new Random();

            int uzunluk = 8;
            string yeniSifre = "";

            for (int i = 0; i < uzunluk; i++)
            {
                int rastgeleIndex = rnd.Next(karakterler.Length);
                yeniSifre += karakterler[rastgeleIndex];
            }

            // 5. SONUÇ
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("GÜVENLİ ŞİFRE: " + yeniSifre);
            Console.WriteLine("------------------------------------------");

            Console.ResetColor();
            Console.WriteLine("\nYenisini üretmek için programı tekrar açabilirsin.");
            Console.WriteLine("Kapatmak için bir tuşa bas...");
            Console.ReadKey();
        }
    }
}