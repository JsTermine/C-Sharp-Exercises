using System;
using System.Threading;

namespace ArraysAlsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 13 };
            
            double averageResult = GetAverage(studentsGrades);
            
            Console.ReadKey();
        }

        public static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            int sum = 0;
            double average;

            for (int i = 0; i < gradesArray.Length; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;

            Console.WriteLine("Der Durchschnitt ist: {0}", average);

            return average;
        }
    }
}
