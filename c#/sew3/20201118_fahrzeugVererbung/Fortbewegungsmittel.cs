using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201118_fahrzeugVererbung
{
    abstract class Fortbewegungsmittel
    {
        private string engineType;
        private bool hasEngine;
        private string name;
        private int speed;
        private int wheelCount;

        public abstract bool HasEngine
        {
            get;
            set;
        }

        public abstract int WheelCount
        {
            get;
            set;
        }

        public abstract int Speed
        {
            get;
            set;
        }

        public abstract string Name
        {
            get;
            set;
        }

        public abstract string EngineType
        {
            get;
            set;
        }

        public abstract int speedUp(int speedUpValue);
        
    }
}