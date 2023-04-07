using System;

namespace IfBedingungenEinführung
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Wie warm ist es gerade? Trage den Wert als Zahl ein");
            
            // Benutzereingabe
            string temperaturInput = Console.ReadLine();


            // int temperature = int.Parse(temperaturInput);
            int temperature;
            int number;

            // int Parse andere Schreibweise
            bool userEnteredANumber = int.TryParse(temperaturInput, out number);


            if (userEnteredANumber)
            { 
                temperature = number;
            }
            else
            {
                temperature = 0;
            }


            // Normale If-Else Statements
            if (temperature < 20)
            {
                Console.WriteLine("Zieh deine Jacke an!");
            }
            else if (temperature == 20)
            {
                Console.WriteLine("Es ist genau 10 Grad C° Warm");
            }
            else if (temperature > 30)
            {
                Console.WriteLine("Es ist eine Bullenhitze!");
            }
            else 
            {
                Console.WriteLine("Zwichen 21 und 30 Grad - T-shirt und Kurze Hose reicht!");
            }




            Console.ReadKey();
        }
    }
}
