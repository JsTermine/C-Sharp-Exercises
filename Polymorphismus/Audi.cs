using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphismus
{
    class Audi : Auto
    {
        // Eigenschaft Model
        public string Model { get; set; }
        
        // Private Eigenschaft Marke
        private string Marke = "Audi";

        // Audi Konstruktor, welches von Auto erbt
        public Audi(string model, int ps, string farbe):base(ps, farbe) {
            this.Model = model;
        }

        // Überladung von ZeigeDetails()
        public override void ZeigeDetails()
        {
            Console.WriteLine("Die Marke ist: {0}", Marke);
            Console.WriteLine("Das Modell ist: {0}", Model);
            Console.WriteLine("Die PS-Leistung ist: {0}", PS);
            Console.WriteLine("Die Farbe ist: {0}\n", Farbe);
        }

    }
}
