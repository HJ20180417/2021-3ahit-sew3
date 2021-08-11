using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210311_points
{
    class ReferencePointComparer
    {
        private double x, y;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public ReferencePointComparer() { }
        public ReferencePointComparer(double x,double y)
        {
            this.x = x;
            this.y = y;
        }

        public int Compare(object obj1, object obj2)
        {
            if (obj1 == null && obj2 == null) return 0;
            if (obj1 == null) return 1;
            if (obj2 == null) return -1;
            if (!(obj1 is Point) || !(obj2 is Point))
            {
                throw new ArgumentException("Beide Objekte müssen vom Typ Punkt sein!");
            }
            else
            {
                Point p1 = (Point)obj1;
                Point p2 = (Point)obj2;
                double r2 = Distance(p1);
                double r1 = Distance(p2);

                if (r1 == r2)
                {
                    return 0;
                }
                else if (r1 > r2)
                {
                    return 1;
                }
                else if (r1 < r2)
                {
                    return -1;
                }
            }

            return 1;
        }

        public double Distance(object obj)
        {
            double r = Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
            return r;
        }
    }
}
