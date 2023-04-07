using System;


namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialisierung von Strings
            string meinName = "Jason";
            string meinNachname = "Termine";
            string nachricht = "Hallo, mein Name ist: ";
            
            //Länge der nachricht mit der .Length property
            int laenge = nachricht.Length;

            //Eintrag alles gross schreiben
            string allesGrossGeschrieben = nachricht.ToUpper();
            string allesKleinGeschrieben = nachricht.ToLower();
            
            //Verwednung von concat für Zeichenketten/strings
            Console.WriteLine(nachricht + meinName + meinNachname);
            Console.WriteLine("Die länge der Nachricht ist: " + laenge);
            
            //Variable alles Gross oder alles Klein schreiben
            Console.WriteLine(allesGrossGeschrieben);
            Console.WriteLine(allesKleinGeschrieben);
            
            //Verwendung von {0}.
            //{n} fügt den Eintrag ein, welches nach dem Komma kommt.
            Console.WriteLine(nachricht + "ist {0} Zeichen lang", laenge);
            Console.ReadKey();
            
        }
    }
}
