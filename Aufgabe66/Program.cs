using System;

namespace Aufgabe66
{
    class Program
    {
        static void Main(string[] args)
        {

            // Herausforderung:
            // erstlle einen Jagged Array, welcher 3 "Freunde Arrays" beinhaltet,
            // in welchem zwei Familienmitglieder gespeichert werden.
            // Stelle jedem Familienmitglied Mitglieder anderer Familien vor (via Konsole und insgesamt 3 Vorstellungen)


            string[][] freundeArray = new String[][]
            {
                new String[] {"Levi", "Frank"},    // Ronaldos' Familienmitglieder
                new String[] {"Noah", "Maurice"},  // Claudias' Familienmitglieder
                new String[] {"Micha", "Jack"}     // Alberts' Familienmitglieder
            };


            Console.WriteLine("Hallo {0}! Ich stelle dir {1} vor!\n", freundeArray[0][0], freundeArray[1][1]);  // Levi wird Maurice vorgestellt
            Console.WriteLine("Hallo {0}! Ich stelle dir {1} vor!\n", freundeArray[2][0], freundeArray[0][1]);  // Micha wird Frank vorgestellt
            Console.WriteLine("Hallo {0}! Ich stelle dir {1} vor!\n", freundeArray[2][1], freundeArray[1][0]);  // Jack wird Noah vorgestellt

            Console.ReadKey();

        }
    }
}
