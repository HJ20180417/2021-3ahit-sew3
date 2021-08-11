using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201118_fahrzeugVererbung
{
    class Yacht : Wasserfahrzeug
    {
        

        public override string Info()
        {
            return (base.Info());
        }

        public Yacht(string type, bool hasEngine,bool engineRunning,int wheelCount,int speed,string name,string engineType)
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