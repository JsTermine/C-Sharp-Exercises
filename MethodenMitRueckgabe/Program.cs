using System;

namespace MethodenMitRueckgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            // int result = Add(2, 5);
            
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Add(2, 5));
            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Divide(13, 23));
            Console.ReadKey();
        }

        // Methode welches Multipliziert
        public static int Multiply(int num1, int num2)
        { 
            return num1 * num2;
        }

        // Methode welches Addiert
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // Methode welches eine Division ausgibt
        public static double Divide(double num1, double num2)
        { 
            return num1 / num2;
        }
    }
}
