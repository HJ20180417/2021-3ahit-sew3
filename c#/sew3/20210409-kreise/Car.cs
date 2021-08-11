using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409_kreise
{
    class Car : IEquatable<Car>
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Serialnumber { get; set; }

        public Car(string make, string model, string year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        bool IEquatable<Car>.Equals(Car car)
        {
            return Equals(car);
        }

        public bool Equals(Car car)
        {
            if (Object.ReferenceEquals(car, null)) return false;
            return (this.Serialnumber == car.Serialnumber && this.Make == car.Make && car.Model == this.Model && this.Year == car.Year);
        }
        public override bool Equals(object obj)
        {
            Car carObj = obj as Car;
            if (Object.ReferenceEquals(carObj, null)) return false;
            else return Equals(carObj);
        }
        
        public override int GetHashCode()
        {
            return this.Serialnumber.GetHashCode();
        }
    }
}
