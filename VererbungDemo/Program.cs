using System;

namespace VererbungDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post("Meine neuen Schuhe", true, "John");
            Console.WriteLine("Post ToString Methode: {0}", post1.ToString());

            ImagePost bildPost1 = new ImagePost("Hier sind sie!", "John", "https://bilder.de/meineschuhe", true);
            Console.WriteLine("Post ToString Methode: {0}", bildPost1.ToString());
            
            

            Console.ReadKey();
        }
    }
}
