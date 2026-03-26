using System;

namespace projeCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sayı Tahmin";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("  1 ile 10 ARASINDA BİR SAYI TUTTUM");
            Console.WriteLine("------------------------------------------");

            Random rastgele = new Random();
            int tutulanSayi = rastgele.Next(1, 11); 


            Console.Write("Tahminin nedir? ");
            string girdi = Console.ReadLine();


            if (int.TryParse(girdi, out int tahmin))
            {

                if (tahmin == tutulanSayi)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nBİLDİN! {tutulanSayi} doğru cevaptı.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"OLMADI... Tuttuğum sayı {tutulanSayi} idi.");
                }
            }
            else
            {
                Console.WriteLine("\nLütfen sadece SAYI girer misin? :)");
            }


            Console.ResetColor();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Çıkmak için herhangi bir tuşa bas");
            Console.ReadKey();
        }
    }
}
