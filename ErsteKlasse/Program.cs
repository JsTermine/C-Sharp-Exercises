using System;

namespace ErsteKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen eines Objektes meiner Human Klasse
            Human max = new Human("Max", "Mustermann", "Braun", 1);
            max.IntroduceMyself();

            Human john = new Human("John","Doe", "Hellbraun", 22);
            john.IntroduceMyself();

            Human cron = new Human("Cron","Job", "Braun", 26);
            cron.IntroduceMyself();

            Human ronaldo = new Human("Ronaldo", "Da Costa", "Dunkelbraun", 25);
            ronaldo.IntroduceMyself();

            Human unbekannt = new Human();
            unbekannt.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
