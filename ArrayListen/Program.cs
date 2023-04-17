using System;
using System.Collections; // Notwendig für ArrayList

namespace ArrayListen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarieren einer ArrayList mit undefinierter Anzahl an Objekten
            ArrayList myArrayList = new ArrayList();
            // Deklarieren einer ArrayList mit bestimmten Anzahl an Objekten
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(25);
            myArrayList.Add("Hallo");
            myArrayList.Add(13.37);
            myArrayList.Add(13);
            myArrayList.Add(128);
            myArrayList.Add(25.3);
            myArrayList.Add(13);

            // Löschen eines Elementes mit einem spiezifischem Wert
            myArrayList.Remove(13);

            // Löschen eines Elementes an einer spezifischer Position (index)
            myArrayList.RemoveAt(0);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if (obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if (obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string) 
                {
                    Console.WriteLine(obj);
                }
            }

            Console.WriteLine("Die Summe ist: {0}", sum);

            Console.WriteLine("Anzahl der Elemente in der ArrayList ist: {0}", myArrayList.Count);

            Console.ReadKey();
        }
    }
}
