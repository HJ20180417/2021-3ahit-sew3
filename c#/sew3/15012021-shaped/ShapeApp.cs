using System;

namespace _15012021_shaped
{
    class ShapeApp
    {
        static void Main(string[] args)
        {
            int count = 0;
            int check = 0;
            Rectangle r = new Rectangle(5, 7, "Rechteck");
            Square sq = new Square(5, 10, "Quadrat");
            Cuboid cb = new Cuboid(5, 7, 4, "Quader");
            Cube c = new Cube(3, 4, 5, "Würfel");
            Shapes[] shapes = { r, sq, cb, c };

            do
            {
                Console.WriteLine("Would you like to refactor the values? Press 1 if you want to, press 2 if you don't want to!");
                count = Int32.Parse(Console.ReadLine());
                if (count == 1)
                {
                    Console.WriteLine("Type in the refactor value!");
                    double refactor = Double.Parse(Console.ReadLine());
                    r.Draw();
                    r.Scale(refactor);
                    r.Info();
                    sq.Draw();
                    sq.Scale(refactor);
                    sq.Info();
                    cb.Draw();
                    cb.Scale(refactor);
                    cb.Info();
                    c.Draw();
                    c.Scale(refactor);
                    c.Info();
                    check = 1;
                }
                else if (count == 2)
                {
                    r.Draw();
                    r.Info();
                    sq.Draw();
                    sq.Info();
                    cb.Draw();
                    cb.Info();
                    c.Draw();
                    c.Info();
                    check = 1;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe, es ist nur 1 oder 2 erlaubt! Bitte versuche es nochmal");
                }
            } while (check == 0);


        }
    }
}
