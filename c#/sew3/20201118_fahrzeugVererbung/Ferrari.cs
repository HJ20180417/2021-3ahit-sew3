using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201118_fahrzeugVererbung
{
    class Ferrari : Landfahrzeug
    {
        public override string Info()
        {
            return (base.Info());
        }

        public Ferrari(string type,bool hasEngine,bool engineRunning,int kmCount,int wheelCount,int speed,string name,string engineType)
        {
            Type = type;
            HasEngine = hasEngine;
            EngineRunning = engineRunning;
            KmCount = kmCount;
            WheelCount = wheelCount;
            Speed = speed;
            Name = name;
            EngineType = engineType;
        }
    }
}