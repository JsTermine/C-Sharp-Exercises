using System;
using System.Linq.Expressions;

namespace Aufgabe67
{
    class Program
    {
        static void Main(string[] args)
        {
            // Herausforderung - Erstelle einen Array "Zufriedenheit" in der Main Methode und füge 5 Werte hinzu
            // Erstelle eine Methode welche einen Array des Typen Int als Parameter verwendet
            // Diese Methode sollde den jeden Wert  des gegebenen Argumentes um 2 erhöhen
            // Rufe die Methode auf und benutze "Zufriedenheit" als argument.
            // Erstelle einen Foreachloop in der Main Methode, welcher alle Werte von "Zufriedenheit" auf die Konsole ausgibt

            int[] zufriedenheit = new int[] { 1, 2, 3, 4, 5 };
            int[] zufriedengeitNeu = zufriedenheit;


            foreach (int item in zufriedengeitNeu)
            {
                Console.WriteLine("Vorheriger Eintrag: {0}", item);
            }

            Console.WriteLine("\n");

            foreach (int item in Rueckgabe(zufriedenheit))
            {
                Console.WriteLine("Eintrag um zwei erhöht: {0}", item);
            }
            

            Console.ReadKey();
        }

        
        public static int[] Rueckgabe(int[] input)
        {
            
            for (int i = 0; i < input.Length; i++)
            {
                input[i] +=  2;
            }

            return input;
        }

    }
}
