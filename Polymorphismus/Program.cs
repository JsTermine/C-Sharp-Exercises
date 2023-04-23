using System;
using System.Collections.Generic;

namespace Polymorphismus
{
    class Program
    {
        // Erstelle eine Basisklasse Auto mit zwei Eigenschaften "PS" und "Farbe"
        // Erstelle einen Konstruktor, der diese beiden Eigenschaften setzt.
        // Erstelle eine Methode namens ZeigeDetails(), die die PS und die Farbe des Fahrzeugs auf der Konsnole ausgibt.
        // Erstelle eine Reparaturmethode, die "Auto wurde repariert" auf die Konsole schreibt.
        // Erstellen Sie zwei abgeleitete Klassen, BMW und Audi, die über einen eigenen Konstruktor verfügen
        // und eine zusätzliche Eigenschaft, Model genannt, haben.
        // Auch ein privates Mitlgied namens Marke. Marke sollte in jeder der beiden Klassen unterschiedlich sein.
        // Erstelle die beiden Methoden ZeigeDetails() und Repair auch in diesen beiden Klassen. Passe diese Methoden entsprechend an.


        static void Main(string[] args)
        {

            // Polymorphie, Audi und BMW erben von Auto
            var Autos = new List<Auto>
            {
                new Audi("A4", 231, "Blau" ),
                new BMW("720i", 536, "Schwarz" )
            };


            // autos in Auto ausgeben
            foreach ( Auto auto in Autos )
            {
                auto.ZeigeDetails();
                auto.Repairiert();
            }


            Console.ReadKey();
        }
    }
}
