using System;

namespace BreakAndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zähler, welches Nummer 3 überspringt
            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 3)
                {
                    Console.WriteLine("Bei drei überspringen!");
                    continue;
                }
                Console.WriteLine(counter);

            }

            Console.ReadKey();
        }
    }
}
