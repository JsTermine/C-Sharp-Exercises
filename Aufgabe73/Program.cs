using System;

namespace Aufgabe73
{
    class Program
    {
        // Herausforderung
        // Füge eine erbende Klasse "VideoPost" hinzu, mit den Eigenschaften VideoURL unf Length
        // Erstelle die benötigten Konstruktoren um ein VideoPost Objekt anzulegen
        // Passe die ToString Methode entsprechen an
        // Erstelle eine Instanz von VideoPost und verwende die ToString Methode darauf.


        static void Main(string[] args)
        {
            VideoPost videoPost1 = new VideoPost("Fail Video", "John", "[URL Link]", true, 10);
            Console.WriteLine(videoPost1.ToString());



            Console.ReadKey();
        }
    }
}
