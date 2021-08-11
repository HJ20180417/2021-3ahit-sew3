using System;
using System.Collections.Generic;
using System.Text;

namespace _15012021_shaped
{
    class Cuboid : Shapes3D, IScalable, IInfo
    {
        private double laenge, breite, hoehe;
        private string name;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override double Laenge
        {
            get { return laenge; }
            set { laenge = value; }
        }
        public override double Breite
        {
            get { return breite; }
            set { breite = value; }
        }
        public override double Hoehe
        {
            get { return hoehe; }
            set { hoehe = value; }
        }
        public Cuboid(double laenge, double breite, double hoehe, string name)
        {
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            Name = name;
        }
        public override void Draw()
        {
            Console.WriteLine("Das ist ein " + name);
        }
        public string Info()
        {
            double o = 2 * (laenge * breite + laenge * hoehe + breite * hoehe);
            double v = laenge * breite * hoehe;
            return ($"Oberfläche: " + o.ToString() + " Volumen: " + v.ToString());
        }
        public void Scale(double refactor)
        {
            laenge *= refactor;
            breite *= refactor;
            hoehe *= refactor;
        }
    }
}
