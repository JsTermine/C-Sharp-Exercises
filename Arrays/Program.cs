using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarieren eines Arrays
            int[] schulNoten = new int[5];
            // Beginnt das Zählen bei 0
            // ArrayName[index] = n (Wert)
            schulNoten[0] = 3;
            schulNoten[1] = 2;
            schulNoten[2] = 4;
            schulNoten[3] = 1;
            schulNoten[4] = 1;


            Console.WriteLine("Die Note bei index 0 ist {0}", schulNoten[0]);

            string input = Console.ReadLine();
            schulNoten[0] = int.Parse(input);
            Console.WriteLine("Die Note bei index 0 ist {0}", schulNoten[0]);

            // weiterer Weg Arrays anzulgene
            int[] schulNotenVonMatheStudenten = { 1, 3, 2, 2, 5, 4, 4, 3 };

            // weiterer Weg Array anzulegen
            int[] schulNotenVonDeutschStudenten = new int[] { 1, 3, 2, 2, 3, 2, 2, 2, 5, 6 };
            Console.WriteLine("Länge des Arrays: {0}", schulNotenVonDeutschStudenten.Length);

            Console.ReadKey();
        }
    }
}
