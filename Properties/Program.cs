using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(5,3,4);
            Console.WriteLine("Volume {0}", box.Volume);


            box.DisplayInfo();

            Console.ReadKey();
        }
    }
}
