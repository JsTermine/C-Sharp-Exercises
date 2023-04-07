using System;
using System.Collections.Generic;
using System.Text;

namespace ErsteKlasse
{
    // Mensch Klasse
    // Eine Blaupause für einen Datentypen
    class Human
    {
        // Membervariable Vorname
        public string firstname;
        // Membervariable Nachname
        public string lastname;
        // Membervariable Augenfarbe
        string eyeColor;
        // Membervariable Alter
        int age;


        public Human()
        {
            Console.WriteLine("Default Konstruktor aufgerufen");
            age = 0;
            eyeColor = "Braun";
            firstname = "Unbekannt";
            lastname = "Unbekannt";
        }


        // Parameterisierter Konstruktor
        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.eyeColor = eyeColor;
            this.age = age;
            Console.WriteLine("Neuer Human erstellt:");
        }


        // Member Methode
        public void IntroduceMyself()
        {

            if (age == 1)
            {
                Console.WriteLine("Hi, ich bin {0} {1} und meine Augenfarbe ist {2} und bin {3} Jahr alt.", firstname, lastname, eyeColor, age);

            }
            else
            { 
                Console.WriteLine("Hi, ich bin {0} {1} und meine Augenfarbe ist {2} und bin {3} Jahre alt.", firstname, lastname, eyeColor, age);
            
            }
               

        }
    }
}
