using System;
using System.Collections.Generic;
using System.Text;

namespace TextAusDateiLesen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Liest Textinhalt von textFile.txt aus
            string text = System.IO.File.ReadAllText(@"[Pfad]\textFile.txt");

            Console.WriteLine("Die Textdatei beinhaltet folgenden Text: {0}", text);

            // Andere herangehensweise
            string[] zeilen = System.IO.File.ReadAllLines(@"[Pfad]\textFile.txt");

            // Ausgabe von textFile.txt
            Console.WriteLine("Die Inhalte der Datei sind: ");

            foreach (string zeile in zeilen)
            {
                Console.WriteLine("\t " + zeile);
            }

            Console.ReadKey();
        }
    }
}
