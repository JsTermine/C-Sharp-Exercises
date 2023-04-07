using System;

namespace ErweiterteIfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Temperatur des Wassers
            int temperature = -5;

            // Aggregatszustand
            string stateofMatter;


            if (temperature < 0)
            {
                stateofMatter = "fest";
            }
            else
            {
                stateofMatter = "flüssig";
            }

            Console.WriteLine("Aggregatszustand ist: {0}", stateofMatter);


            temperature += 30;

            // Erweitertes If-Statement (Verkürzt)
            stateofMatter = temperature < 0 ? "fest" : "flüssig";

            Console.WriteLine("Aggregatszustand ist: {0}", stateofMatter);


            temperature += 100;

            // (Herausforderung) Erweitertes If-Statement mit 2 Bedingungen
            stateofMatter = temperature > 100 ? "Gas" : (stateofMatter = temperature < 0 ? "fest" : "flüssig");
            Console.WriteLine("Aggregatszustand ist: {0}", stateofMatter);


            Console.ReadKey(); 
        }
    }
}
