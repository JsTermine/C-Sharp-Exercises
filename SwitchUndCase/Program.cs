using System;

namespace SwitchUndCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            
            // Verzweigungen durch Switch
            switch (age) 
            {
                case 15:
                    Console.WriteLine("Zu jung zum Feiern");
                    break;
                case 25:
                    Console.WriteLine("Erlaubt zum Feiern");
                    break;

                // Default: Wie Else, bei einem If-Statement
                default:
                    Console.WriteLine("Wie alt bist du eigentlich?");
                    break;
            }


            // If-Else abbildung vom oberen Switch-Statement
            if (age <= 15)
            {
                Console.WriteLine("Zu jung zum Feiern");
            }
            else if (age >= 25)
            {
                Console.WriteLine("Alles klar, ab gehts");
            } 
            else 
            {
                Console.WriteLine("Wie alt bist du eigentlich?");
            }
            

            Console.ReadKey(); 
        }
    }
}
