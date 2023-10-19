using System;

namespace Uppgift_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";

            while (val != "3")
            {
                Console.WriteLine();
                
                Console.WriteLine("Välj ett av följande alternativ.");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat.");
                Console.WriteLine("3. Avsluta programmet.");
                val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        Console.WriteLine("Skriv in talet som ska subrtraheras.");
                        double term1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Vad ska det subtraheras med?");
                        double term2 = double.Parse(Console.ReadLine());
                        double differens = term1 - term2;
                        Console.WriteLine($"Differensen är {differens}.");
                        break;
                    case "2":
                        Console.WriteLine("Skriv in täljaren.");
                        double taljare = double.Parse(Console.ReadLine());
                        Console.WriteLine("Skriv in nämnaren.");
                        double namnare = double.Parse(Console.ReadLine());
                        double kvot = taljare / namnare;
                        Console.WriteLine($"Kvoten är {kvot}.");
                        break;
                    case "3":
                        Console.WriteLine("Programmet avslutas.");
                        break;
                    default:
                        Console.WriteLine("Kunde inte hittas. Välj ett nytt alternativ.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}