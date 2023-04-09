using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            // Erste Variante mit 10 definierte durchläufe
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 10;
            }

            // Zweite Variante mit der Länger der nums als anzahl Durchläufe
            for (int i = 0;i < nums.Length ;i++) 
            {
                Console.WriteLine("Element {0} = {1}", i, nums[i]);
            }

            // Dritte Variante mit foreach
            int counter = 0;
            foreach (int wert in nums) 
            {
                Console.WriteLine("Element {0} = {1}", counter++, wert);
            }

            // Vierte Variante mit einem String Array
            string[] friends = { "Levi", "Fridli", "Willi", "Hamin", "Muji" };

            foreach (string name in friends)
            {
                Console.WriteLine("Hi, {0}", name);
            }

            Console.ReadKey();
        }
    }
}
