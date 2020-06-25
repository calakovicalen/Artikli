using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;

namespace Artikli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Ime = new List<string>();
            List<string> Sifra = new List<string>();
            decimal cena = 0;
            string izbor = " ";
            while(izbor != "5")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1. UNOS ARTIKLA ");
                Console.WriteLine("2. PREGLED TRENUTNIH ARTIKLA");
                Console.WriteLine("3. PRETRAGA ARTIKLA");
                Console.WriteLine("4. BRISANJE ARTIKLA");
                Console.WriteLine("5. IZLAZ");
                Console.WriteLine("********************************");
                Console.ResetColor();
                Console.Write("Unesite opciju: ");
                izbor = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine("");
                switch (izbor)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("********************************");
                        Console.Write("Unesite ime artikla: ");
                        Ime.Add(Console.ReadLine());
                        Console.Write("Unesite sifru artikla: ");
                        Sifra.Add(Console.ReadLine());
                        Console.Write("Unesite cenu artikla: ");
                        cena = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("********************************");
                        Console.ResetColor();
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        for (int indeks = 0; indeks < Ime.Count; indeks++)
                        {

                            Console.WriteLine($"{indeks + 1}. {Ime[indeks]} | {Sifra[indeks]} | {cena} dinara");
                            Console.WriteLine("********************************");
                        }
                        Console.ResetColor();
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("********************************");
                        Console.Write("Unesite ime artikla: ");
                        string search = Console.ReadLine();
                        for (int indeks = 0; indeks < Ime.Count; indeks++)
                        {
                            if (Ime[indeks].ToLower().Contains(search.ToLower()))
                            {
                                Console.WriteLine($"{indeks + 1}. {Ime[indeks]} | {Sifra[indeks]} | {cena} dinara"); 
                            }
                        }
                        Console.WriteLine("********************************");
                        Console.ResetColor();
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("********************************");
                        Console.Write("Unesite ime artikla: ");
                        string pretraga = Console.ReadLine();
                        for (int indeks = 0; indeks < Ime.Count; indeks++)
                        {
                            if (Ime[indeks].ToLower().Contains(pretraga.ToLower()))
                            {
                                Ime.RemoveAt(indeks);
                                Sifra.RemoveAt(indeks);
                                Console.WriteLine($"Artikal {pretraga} je uspesno uklonjen.");
                            }
                        }
                        Console.WriteLine("********************************");
                        break;
                    case "5":
                        Console.WriteLine("********************************");
                        Console.WriteLine("PRIJATNO! :)");
                        Console.WriteLine("********************************");
                        break;
                    default:
                        Console.WriteLine("********************************");
                        Console.WriteLine("Izabrali ste nepostojacu opciju.");
                        Console.WriteLine("********************************"); 
                        break;
                }
            }
        }
    }
}
