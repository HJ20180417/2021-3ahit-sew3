using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201118_fahrzeugVererbung
{
    class Privatjet : Luftfahrzeug
    {
        

        public override string Info()
        {
            return (base.Info());
        }

        public Privatjet(string type, bool hasEngine,bool engineRunning,int wheelCount,int speed,string name,string engineType)
        {
            Type = type;
            HasEngine = hasEngine;
            EngineRunning = engineRunning;
            WheelCount = wheelCount;
            Speed = speed;
            Name = name;
            EngineType = engineType;
        }
    }
}