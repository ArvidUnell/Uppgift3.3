using System;

namespace Uppgift3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bil?");
            byte timmar = byte.Parse(Console.ReadLine());

            if (timmar*80 < 950)
            {
                Console.WriteLine($"Det kommer att kosta {timmar*80} kr.");
            }
            else
            {
                Console.WriteLine("Det kommer att kosta 950 kr.");
            }

            Console.WriteLine("Tryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}