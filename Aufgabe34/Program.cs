using System;

namespace Aufgabe34
{
    class Program
    {
        // Statische deklaration
        static string benutzerName;
        static string password;

        static string loginB;
        static string loginPw;

        // Methoden aufrufen
        static void Main(string[] args)
        {
            Registrieren();
            Login();

            Console.ReadKey();
        }

        // Methode zur registrierung
        public static void Registrieren()
        {
            // Registrierung, Benutzername
            Console.WriteLine("Bitte lege einen Konto an:");
            Console.WriteLine("Benutzername:");
            benutzerName = Console.ReadLine();
            // Registrierung, Passwort
            Console.WriteLine("Password:");
            password = Console.ReadLine();

            Console.WriteLine("Du bist registriert :)");

            // Trennung von Registrierung und Login
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------");
            Console.ForegroundColor = ConsoleColor.White;

        }

        // Methode welches nach Logindaten fragt
        public static void Login()
        {
            // Login, Benutzername
            Console.WriteLine("Benutzername:");
            loginB = Console.ReadLine();
            // Login, Passwort
            Console.WriteLine("Gib deinen Passwort an:");
            loginPw = Console.ReadLine();

            // Überprüfen ob Login existiert
            if (loginB.Equals(benutzerName) && loginPw.Equals(password))
            {
                Console.WriteLine("Willkommen in deinem Account");
            }
            else
            {
                Console.WriteLine("Unbekanntes Konto. Bitte lege ein konto an.");
                Registrieren();
            }
        }
    }
}
