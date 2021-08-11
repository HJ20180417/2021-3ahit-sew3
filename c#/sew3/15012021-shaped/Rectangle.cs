using System;
using System.Collections.Generic;
using System.Text;

namespace _15012021_shaped
{
    class Rectangle : Shape2D, IScalable, IInfo
    {
        private double laenge, breite;
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
        public Rectangle(double laenge, double breite, string name)
        {
            Breite = breite;
            Laenge = laenge;
            Name = name;
        }
        public override void Draw()
        {
            Console.WriteLine("Das ist ein " + name);
        }
        public string Info()
        {
            double u = 2 * (laenge + breite);
            double a = laenge * breite;
            return ($"Umfang: " + u.ToString() + " Fläche: " + a.ToString());
        }
        public void Scale(double refactor)
        {
            laenge *= refactor;
            breite *= refactor;
        }
    }

}
