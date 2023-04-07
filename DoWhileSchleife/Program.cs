using System;

namespace DoWhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            // Namenzähler und Liste der Namen deklarieren
            int nameCount = 0;
            string arrayNames = "";

            do
            {
                Console.WriteLine("Gib hier einen Namen ein:");
                string nameOfAFriend = Console.ReadLine();

                nameCount++;
                arrayNames += nameOfAFriend + " ";
            } while (nameCount < 5);


            // Ausgabe der eingegebenen Namen
            Console.WriteLine("Die eingegebene Namen sind: {0}", wholeText);
            

            Console.ReadKey();
        }
    }
}
