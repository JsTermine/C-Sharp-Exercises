using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe74
{
    class Employee
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string firstname, int Salary) 
        {
            this.Name = name;
            this.FirstName = firstname;
            this.Salary = Salary;
        }

        public Employee() 
        {
            Name = "John";
            FirstName = "Wayne";
            Salary = 15000;
        }

        public void Work()
        {
            Console.WriteLine("Ich arbeite");
        }
        
        public void Pause()
        {
            Console.WriteLine("Ich mache Pause");
        }


    }
}
