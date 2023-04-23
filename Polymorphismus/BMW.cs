using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphismus
{
    class BMW : Auto
    {
        // Eigenschaft Model
        public string Model { get; set; }
        
        // Private Eigenschaft Marke
        private string Marke = "BMW";

        // BMW Konstruktor, welches von Auto erbt
        public BMW(string model, int ps, string farbe):base(ps, farbe) {
            this.Model = model;
        }

        // Überladung der von ZeigeDetails()
        public override void ZeigeDetails()
        {
            Console.WriteLine("Die Marke ist: {0}", Marke);
            Console.WriteLine("Das Modell ist: {0}", Model);
            Console.WriteLine("Die PS-Leistung ist: {0}", PS);
            Console.WriteLine("Die Farbe ist: {0}\n", Farbe);
        }

    }
}
