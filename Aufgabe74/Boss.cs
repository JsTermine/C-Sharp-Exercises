using System;
using System.Collections.Generic;
using System.Text;

namespace Aufgabe74
{
    class Boss : Employee
    {
        protected string CompanyCar { get; set; }
    
        public Boss(string companyCar, string name, string firstname, int salary):base(name, firstname, salary) 
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("Ich bin der Chef. Mein Name ist: {0} {1}", FirstName, Name);
        }

    }
}
