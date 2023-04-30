using System;
using System.Collections.Generic;
using System.Text;
using System.IO; // Notwendig

namespace TextInDateiSchreiben
{
    class Program
    {
        static void Main(string[] args)
        {

            // Methode 1
            // Erstellt automatisch die Datei "meinText.txt", falls nicht vorhanden
            string[] zeilen = {"250","242","240"};
            File.WriteAllLines(@"[Pfad]\meinText.txt", zeilen);

            
            // Methode 2
            // Überschreibt letzte Datei
            File.WriteAllText(@"[Pfad]\meinText.txt", "Mein Text Test");


            // Kleine Herausforderung - Program erstellen, welches den Benutzer nach Dateinamen und Inhalt fragt.
            Console.WriteLine("Wie soll die Datei heissen?");
            string fileName = Console.ReadLine();

            Console.WriteLine("Was möchtest du in die Datei schreiben?");
            string fileText = Console.ReadLine();

            File.WriteAllText(@"[Pfad]\" + fileName + ".txt", fileText);
            

            // Methode 3
            using (StreamWriter datei = new StreamWriter(@"[Pfad]\meinText2.txt")) 
            {
                foreach (string zeile in zeilen)
                {
                    if (zeile.Contains("250"))
                    {
                        datei.WriteLine(zeile);
                    }
                }

            }

            // "true" signalisiert, dass die Datei bereits existiert
            using (StreamWriter datei = new StreamWriter(@"[Pfad]\meinText2.txt", true)) 
            {
                datei.WriteLine("Zusätzliche Zeile");
            }

        }
    }
}
