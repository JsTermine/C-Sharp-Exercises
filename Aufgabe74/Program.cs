using System;

namespace Aufgabe74
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstelle eine Hauptklasse mit der Methode Main, dann eine Mitarbeiterklasse Namens "Employee"
            // als Basiskalsse (Superklasse) mit den Eigenschaften Name, Firstname, Salary und die Methoden Work() und Pause()
            // Erstelle eine erbende Klasse Boss mit der Eigenschaft CommpanyCar und der Methode Lead().
            // Erstelle eine weitere Erbende Klasse von Employee - trainee (Auszubildende) mit den Eigenschaften WorkingHours
            // und SchoolHours und eine Methode Learn().
            // Überschreibe die Methode Work() der Trainee-Klasse, so dass sie Folgendes anzeigen
            // die Arbeitszeit und Auszubildenden.
            // Vergiss nicht, die Konstruktoren zu erstellen.
            // Lege ein Objekt jeder der drei Klassen (mit beliebigen Werten) an
            // und rufe die Methoden Lead() von Boss und Work() von Trainee auf.
            // Gib einfach den jeweiligen Text aus, was die jeweiligen Mitarbeiter tun
            // 

            
            Employee john = new Employee("Wayne","John", 40000);
            john.Work();
            john.Pause();

            Boss enzoFerrari = new Boss("LaFerrari", "Ferrari", "Enzo", 100000);
            enzoFerrari.Lead();
            enzoFerrari.Work();

            Trainee michael = new Trainee(32, 8, "Gärtner", "Michael", 10000);
            michael.Learn();
            michael.Work();

            Console.ReadKey();

        }
    }
}
