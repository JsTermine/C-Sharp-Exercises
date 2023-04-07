using System;

namespace TryCatchUndFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            // Abfrage um eine Zahl
            Console.WriteLine("Bitte trage eine Zahl ein:");
            string userInput = Console.ReadLine();
            


            try
            {
               int userInputAsInt = int.Parse(userInput) / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Zahl kann nicht durch 0 geteilt werden!");
            }

            
            
            // Fehler abfangen und formulieren
            try
            {
                // ArgumentNullExeption zu simulieren
                //userInput = null;
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException) // Fängt Fehler ab, wenn ein falsches Format eingegeben wird
            {
                Console.WriteLine("Format war inkorrekt. Du hättest hier eine Zahl eintragen sollen!");
            }
            catch (ArgumentNullException) // Fängt Fehler ab, wenn kein Input eingegeben wird
            {
                Console.WriteLine("ArgumentNullExeption, der Wert war leer (null)");
            }
            catch (OverflowException) // Fängt Fehler ab, wenn Zahl zu gross ist
            {
                Console.WriteLine("OverflowExeption, Der eingegebene Wert war zu lang");
            }
            finally // Standardwert, welches ausgegeben wird.
            {
                Console.WriteLine("Ich werde sowieso ausgeführt");
            }
            

            Console.ReadKey();

        }
    }
}
