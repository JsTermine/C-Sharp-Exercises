using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    class Box
    {
        // Membervariablen
        private string color = "weiss";
        // Länge
        int length;
        // Höhe
        int height;
        // Breite
        int width;
        // Volumen
        int volume;
        
        // Auto - implemented Property // type prop
        public int Height { get; set; }

        // write only
        public int Volume
        {
            get 
            {
                return Height * Length * Width;
            }
            set
            {
                volume = value;
            }
        }

        // read only
        public int Width
        {
            get
            {
                return width;
            }
            
            set
            {
                //if (value < 0) throw new Exception("Breite sollte Positiv sein!");
                if (value < 0) 
                {
                    value = -value;
                };
                width = value;
            }
            
        }

        public int Length
        {
            get => length;
            set => length = value;
        }


        /*
        // Custom Property
        public int Length
        {
            get 
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        */
        
        public void DisplayInfo()
        {
            Console.WriteLine("Länge ist {0} und Höhe ist {1} und Breite ist {2} somit ist das Volumen {3}.", length, Height, Width, volume = length*Height*Width);
        }
        

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.Height = height;
            this.width = width;
        }

    }
}
