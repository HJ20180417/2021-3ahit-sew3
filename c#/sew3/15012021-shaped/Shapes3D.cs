using System;
using System.Collections.Generic;
using System.Text;

namespace _15012021_shaped
{
    abstract class Shapes3D : Shapes
    {
        public abstract double Laenge
        {
            get;
            set;
        }
        public abstract double Breite
        {
            set;
            get;
        }
        public abstract double Hoehe
        {
            get;
            set;
        }
    }
}
