using System;

namespace Benutzereingabe
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bitte gib hier dein Benutzernamen ein!");

            // Buntzereingabe wird in einer Variable gespeichert
            string input = Console.ReadLine();
            Console.WriteLine("Benutzereingabe war: {0}", input);

            // Calculate Methode wird aufgerufen
            Calculate();
            Console.ReadKey();
        }

        // Methode welches inputs kalkuliert
        public static int Calculate() 
        {
            Console.WriteLine("Bitte gib Zahlen an die du Addieren möchtest:");
            string input1Num = Console.ReadLine();
            string input2Num = Console.ReadLine();
            
            // Konvertierung String zu integer
            int num1 = int.Parse(input1Num);
            int num2 = int.Parse(input2Num);

            int result = num1 + num2;
            Console.WriteLine("Dein Ergebnis ist: {0}", result);

            return result;
        }
    }
}
