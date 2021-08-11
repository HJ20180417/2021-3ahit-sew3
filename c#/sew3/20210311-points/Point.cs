using System;
using System.Collections.Generic;
using System.Text;

namespace _20210311_points
{
    public class Point : IComparable
    {   // Sortierbar machen des ArrayList of Points
        // Vergleich der Punktabstände vom Ursprung (0,0)
        private double xcoord, ycoord;
        public double Xcoord
        {
            get { return xcoord; }
            set { xcoord = value; }
        }
        public double Ycoord
        {
            get { return ycoord; }
            set { ycoord = value; }
        }
        public Point() { }
        // X, Y Koordinaten ....
        public Point(double xcoord,double ycoord)
        {
            this.xcoord = xcoord;
            this.ycoord = ycoord;
        }
        public int CompareTo(object obj)
        {   // Vergleich des Abstandes der Punkte vom Ursprung (0, 0)
            if (obj==null)     {  return 1; }
            if (this.GetType() != obj.GetType())
            {
                throw (new ArgumentException("Both objects being compared must be of type Point."));
            }
            else
            {
                // Der Parameter obj in CompareTo(object obj) muss in einen Point konvertiert werden.
                Point p = (Point) obj;
                // Quadratische Abstand vom Ursprung (0, 0) ...
                // ... des betrachteten Punkts (this)
                double r1 = this.Radius;
                // ... des Punktes, der als Parameter übergeben wurde
                double r2 = Math.Sqrt(Math.Pow(p.Xcoord, 2) + Math.Pow(p.Ycoord, 2));
 
                // Vergleich der beiden Punkte und Berechnung des Rückgabewertes von CompareTo(p)
                if (r1 == r2)       { return (0); }
                else if (r1 > r2)   { return (1); }
                else if (r1 < r2)   { return (-1);}
            } // else
            return 1;
        } // CompareTo

        public double Radius
        {
            get
            {
                double r = Math.Sqrt(Math.Pow(this.Xcoord, 2) + Math.Pow(this.Ycoord, 2));
                return r;
            }
        }

    } // Point
}
