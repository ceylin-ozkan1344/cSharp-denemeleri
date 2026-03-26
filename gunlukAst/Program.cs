using System;
using System.IO;

namespace GunlukAsistan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kişisel Günlük";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("==========================================");
            Console.WriteLine("Not Giriniz.");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("Notunuz: ");
            Console.Write("> ");
            string mesaj = Console.ReadLine();

            string zaman = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
            string kaydedilecekNot = $"[{zaman}] - {mesaj}";

            File.AppendAllText("gunluk.txt", kaydedilecekNot + Environment.NewLine);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Notun hafızaya alındı.");
            Console.WriteLine("------------------------------------------");

            Console.ResetColor();
            Console.WriteLine("Kapatmak için herhangi bir tuşa bas...");
            Console.ReadKey();
        }
    }
}