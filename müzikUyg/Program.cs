using System;
using System.Collections.Generic;

class Sarki
{
    public string Ad { get; set; }
    public string Sanatci { get; set; }
    public int Sure { get; set; }

    public Sarki(string ad, string sanatci, int sure)
    {
        Ad = ad;
        Sanatci = sanatci;
        Sure = sure;
    }

    public override string ToString()
    {
        return $"{Ad} - {Sanatci} ({Sure} dk)";
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList<Sarki> calmaListesi = new LinkedList<Sarki>();

        calmaListesi.AddLast(new Sarki("Dönence", "Barış Manço", 4));
        calmaListesi.AddLast(new Sarki("Gül Pembe", "Barış Manço", 5));
        calmaListesi.AddLast(new Sarki("Sarışın", "MFÖ", 3));

        LinkedListNode<Sarki> suankiSarki = calmaListesi.First;

        while (true)
        {
            Console.WriteLine("\nŞu an çalan: " + suankiSarki.Value);
            Console.WriteLine("\n1- Sonraki Şarkı");
            Console.WriteLine("2- Önceki Şarkı");
            Console.WriteLine("3- Araya Şarkı Ekle");
            Console.WriteLine("4- Çıkış");

            Console.Write("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    if (suankiSarki.Next != null)
                    {
                        suankiSarki = suankiSarki.Next;
                    }
                    else
                    {
                        Console.WriteLine("Son şarkıdasınız.");
                    }
                    break;

                case 2:
                    if (suankiSarki.Previous != null)
                    {
                        suankiSarki = suankiSarki.Previous;
                    }
                    else
                    {
                        Console.WriteLine("İlk şarkıdasınız.");
                    }
                    break;

                case 3:
                    Console.Write("Şarkı adı: ");
                    string ad = Console.ReadLine();

                    Console.Write("Sanatçı: ");
                    string sanatci = Console.ReadLine();

                    Console.Write("Süre (dk): ");
                    int sure = Convert.ToInt32(Console.ReadLine());

                    Sarki yeniSarki = new Sarki(ad, sanatci, sure);

                    calmaListesi.AddAfter(suankiSarki, yeniSarki);

                    Console.WriteLine("Şarkı eklendi.");
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }
}