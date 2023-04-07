using System;

namespace Aufgabe37
{
    class Program
    {
        // höchste Punktzahl
        static int highscore = 100;
        // Rekordhalter
        static string highscorePlayer = "John";
        static void Main(string[] args)
        {
            // Benutzernamen eingeben
            Console.WriteLine("Bitte gib deinen SpielerNamen an:");
            string playerName = Console.ReadLine();
            // Erzielter Score
            Console.WriteLine("Bite gib deinen Score an:");
            string highscorePlayerString = Console.ReadLine();
            int score = int.Parse(highscorePlayerString);

            // Methode aufrufen
            Punktzahl(score, playerName);

            Console.ReadKey();
        }

        // Methode vergleicht erzieltes Score mit höchstpunktzahl
        public static void Punktzahl(int score, string playerName)
        {
            if (score >= highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine("Neuer Score ist: {0}", highscore);
                Console.WriteLine("Neuer Rekordhalter ist: {0}", highscorePlayer);
            } 
            else if (score < highscore)
            {
                Console.WriteLine("Der alte highscore von {0} konnte nicht gebrocheb werden und wird immer noch gehalten von {1}", highscore, highscorePlayer);
            }
        }
    }
}
