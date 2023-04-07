using System;

namespace Aufgabe47
{
    internal class Program
    {
        static string eingabeLehrer = "0";
        static int eingabePunktzahl;
        static int gesamtPunktzahl;
        static int counter;

        static void Main(string[] args)
        {
            Console.WriteLine("Anzahl der eingegebenen Noten: {0}", counter);
            Console.WriteLine("Bitte gib deine Punktzahlen an:");
            while (eingabeLehrer != "-1")
            {

                eingabeLehrer = Console.ReadLine();

                if (eingabeLehrer.Equals("-1"))
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Die Gesamtpunktzahl ist: {0}", gesamtPunktzahl);
                    Console.WriteLine("Durchschnitt der Punktzahl ist: {0}", ((float)gesamtPunktzahl / (float)counter));
                }
                if (int.TryParse(eingabeLehrer, out eingabePunktzahl) && eingabePunktzahl > 1 && eingabePunktzahl < 7)
                {
                    gesamtPunktzahl += eingabePunktzahl;
                }
                else
                {
                    if (!(eingabeLehrer.Equals("-1")))
                    {
                        Console.WriteLine("Bitte trage einen Wert zwischen 1 und 6 ein.");
                    }
                    continue;
                }
                counter++;
            }

            Console.ReadKey();
        }
    }
}
