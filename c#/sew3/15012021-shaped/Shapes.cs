using System;
using System.Collections.Generic;
using System.Text;

namespace _15012021_shaped
{
    abstract class Shapes : ShapeApp
    {
        public abstract string Name
        {
            get;
            set;
        }
        public abstract void Draw();
    }
}
