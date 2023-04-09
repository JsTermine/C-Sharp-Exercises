using System;
using System.Data;

namespace VerzweigteArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Verzweigte Arrays - Jagged Arrays

            // Deklarieren eines Verzweigten Arrays
            int[][] jaggedArray = new int[3][];

            // Deklarieren der Arrays die sich im Jagged Array befinden
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            // Andere Schreibweise
            jaggedArray[0] = new int[] { 2, 3, 5, 7, 11 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 13, 21 };

            // Weitere Variante um arrays zu Definieren
            int[][] jaggedArray2 = new int[][]
                { 
                    new int[] { 2, 3, 5, 7, 11 },
                    new int[] { 1, 2, 3 } 
                };

            Console.WriteLine("Der Wert in der Mitte des ersten Eintrages ist: {0}", jaggedArray2[0][2]);
            Console.WriteLine("Der Wert in der Mitte des zweiten Eintrages ist: {0}", jaggedArray2[1][1]);

            
            // Jeder Wert im jaggedArray2 ausgeben mit for Schleife
            for (int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("Zeile: {0}", i);

                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("{0}", jaggedArray2[i][j]);
                }
            };
            

            // Jeder Wert im jaggedArray2 ausgeben mit foreach Schleife
            int counter = 0;
            foreach (int[] row in jaggedArray2)
            {
                Console.WriteLine("Zeile: {0}", counter);
                foreach (int column in row)
                {
                    Console.WriteLine("{0}", column);
                }
                counter++;
            }


            Console.ReadKey();
        }
    }
}
