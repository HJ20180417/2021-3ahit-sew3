using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using _20210311_points;

namespace PointCoords
{
    class ReferencePointComparer:IComparer
    {
        private Point pref = new Point();

        public ReferencePointComparer()
        {
            this.pref.Xcoord = 0; 
            this.pref.Ycoord = 0;
        }
        
        public ReferencePointComparer(double x, double y)
        {
            this.pref.Xcoord = x;
            this.pref.Ycoord = y;
        }

        public double X
        {
            set
            {
                this.pref.Xcoord = value;
            }
            get
            {
                return this.pref.Xcoord;
            }
        }

        public double Y
        {
            set
            {
                this.pref.Ycoord = value;
            }
            get
            {
                return this.pref.Ycoord;
            }
        }
        
        public int Compare(object obj1, object obj2)
        {
            if(obj1 == null && obj2 == null) return 0;
            if(obj1 == null) return 1;
            if(obj2 == null) return -1;

            if (!(obj1 is Point) ||  !(obj2 is Point) )
            {       
                throw (new ArgumentException("Both objects being compared must be of type Point."));
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
        } // Compare
        public double Distance(object obj)
        {
            double r = Math.Sqrt(Math.Pow(this.X, 2) + Math.Pow(this.Y, 2));
            return r;
        }
    } // class
} // ns
