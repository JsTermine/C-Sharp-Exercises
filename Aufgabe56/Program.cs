using System;

namespace Aufgabe56
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 3);
            Console.WriteLine("Dei Vorderfläche vom Würfel ist: {0}", box.FrontSurface);

            Console.ReadKey();
        }
    }
}
