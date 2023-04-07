using System;

namespace WhileLoopD
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";

            while (enteredText.Equals("")) 
            {
                Console.WriteLine("Bitte drücke <Enter>, um Eins hochzuzählen:");
                // Benutzereingabe
                enteredText = Console.ReadLine();
                Console.WriteLine("Aktuelle Anzahl Schüler: {0}", counter);
                // Zählen hoch
                counter++;
            }

            Console.ReadKey();
        }
    }
}
