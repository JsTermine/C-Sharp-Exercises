using System;

namespace MehrDimensionaleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarieren eines 2D Arrays
            string[,] matrix;


            // Deklarieren eines 3D Array
            int[,,] threeD;


            // 2D Array Beispiel
            int[,] twoD = new int[,]
            {
                { 1, 2, 3}, // Zeile 0
                { 4, 5, 6}, // Zeile 1
                { 7, 8, 9}  // Zeile 2
            };
            
            Console.WriteLine("Mittlerer Wert ist: {0}", twoD[1,1]);
            Console.WriteLine("Erster Wert in der letzten Zeile ist: {0}", twoD[2,0]);


            // 3D Array Beispiel
            string[,,] array3D = new string[,,]
            { //------------------------------------------> Erste Dimension
                { // -------------------------------------> Zweite Dimension

                    {"000", "001"}, // -------------------> Dritte Dimension
                    {"010", "011"},
                    {"Hallo", "Wie gehts"}
                },
                {
                    {"100", "101"},
                    {"110", "111"},
                    {"Brot", "Nutella"}
                }
            };
            
            Console.WriteLine("011 ist bei: {0}", array3D[0,1,1]);
            Console.WriteLine("100 ist bei: {0}", array3D[1,0,0]);

            Console.WriteLine("'Hallo' ist bei: {0}", array3D[0,2,0]);
            Console.WriteLine("'Nutella' ist bei: {0}", array3D[1,2,1]);
            

            // Deklarieren eines 2D Arrays mit Initialisierung
            string[,] array2DString = new String[3, 2]
                {
                    {"eins","zwei"},
                    {"drei","vier"},
                    {"fünf","sechs"}
                };

            // Überschreiben eines Wertes in einem Array2D
            array2DString[1, 1] = "Hänchen!";

            Console.WriteLine("Heute gibt es: {0}", array2DString[1, 1]);

            Console.WriteLine("Anzahl der Dimensionen: {0}", array2DString.Rank);


            Console.ReadKey();
        }
    }
}
