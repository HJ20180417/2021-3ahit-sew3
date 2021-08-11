using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409_kreise
{
    class Kreis1 : IEquatable<Kreis1>
    {
        public double Radius { get; set; }
        public double Umfang { get; set; }
        public string Name { get; set; }
        public string KreisID { get; set; }

        public Kreis1(double radius, double umfang, string name)
        {
            Radius = radius;
            Umfang = umfang;
            Name = name;
        }

        bool IEquatable<Kreis1>.Equals(Kreis1 k1)
        {
            return Equals(k1);
        }

        public bool Equals(Kreis1 k1)
        {
            if (Object.ReferenceEquals(k1, null)) return false;
            return (this.KreisID == k1.KreisID && this.Radius == k1.Radius && k1.Umfang == this.Umfang && this.Name == k1.Name);
        }
        public override bool Equals(object obj)
        {
            Kreis1 carObj = obj as Kreis1;
            if (Object.ReferenceEquals(carObj, null)) return false;
            else return Equals(carObj);
        }
        
        public override int GetHashCode()
        {
            return this.KreisID.GetHashCode();
        }
    }
}
