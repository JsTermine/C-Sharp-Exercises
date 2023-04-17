using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe74
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }
        public int SchoolHours { get; set; }

        public Trainee(int workingHours, int schoolHours, string name, string firstname, int salary):base(name, firstname, salary)
        {
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("Ich lerne {0} Stunden in der Woche", SchoolHours);
        }

        public new void Work() 
        {
            Console.WriteLine("Ich arbeite {0} Stunden in der Woche.", WorkingHours);
        }
        
    }

}
