using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Aufgabe24
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklaration Namen
            string friendOne = "Frank";
            string friendTwo = "Stefan";
            string friendThree = "Pippo";

            /* Methodenaufruf GreetFriend, mit statischen Namen */
            GreetFriend(friendOne);
            GreetFriend(friendTwo);
            GreetFriend(friendThree);


            // Schleife, welches 3 Inputs vom Benutzer liest
            Console.WriteLine("Bitte gib 3 weitere Namen ein:");
            for (int i = 0; i < 3; i++)
            {
                GreetFriend(Console.ReadLine());
            }

            Console.ReadKey();
        }


        // Methode welches einen "Friend" grüsst, mit string manipulation
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi {0}, mein Freund!", friendName);
        }
    }
}
