using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210409_kreise
{
    class Program
    {
        static void Main(string[] args)
        {
            Kreis1 k1 = new Kreis1(3,17,"Kreis1");
            Kreis1 k2 = new Kreis1(4,20,"Kreis2");

            if (k1 is IEquatable<Kreis1> && k2 is IEquatable<Kreis1>)
            {
                if (((IEquatable<Kreis1>)k1).Equals(k2))
                {
                    Console.WriteLine("Beide Kreise sind gleich");
                }
                else
                {
                    Console.WriteLine("Die Kreis sind ungleich");
                }
            }

            Console.ReadLine();
        }
    }
}
