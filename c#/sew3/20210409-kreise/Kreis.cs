using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409_kreise
{
    class Kreis : IEquatable<Kreis>
    {
        private double radius;

        public double Radius
        {
            get { return radius; }
        }

        public Kreis(double radius)
        {
            this.radius = Radius;
        }
        
        

        public bool Equals(Kreis k1)
        {
            return (this.Radius == k1.Radius);
        }
    }
}
