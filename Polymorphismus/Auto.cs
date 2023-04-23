using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphismus
{
    class Auto
    {
        // Eigenschaft Farbe
        public string Farbe { get; set; }

        // Eigenschaft PS
        public int PS { get; set; }

        // Default Konstruktor
        public Auto() { }

        // Basis-Konstruktor für Auto
        public Auto(int ps, string farbe) 
        { 
            this.Farbe = farbe;
            this.PS = ps;
        }

        // Virtuelle ausgabe von Details
        public virtual void ZeigeDetails()
        {
            Console.WriteLine("Das Modell ist: {0}", PS);
            Console.WriteLine("Die Marke ist: {0}", Farbe);
        }
        
        public void Repairiert() {
            Console.WriteLine("Auto wurde repariert!\n");
        }

    }
}
