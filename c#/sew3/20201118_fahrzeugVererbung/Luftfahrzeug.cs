using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20201118_fahrzeugVererbung
{
    class Luftfahrzeug : Fortbewegungsmittel
    {
        private bool engineRunning;
        private string type;
        private string engineType;
        private bool hasEngine;
        private string name;
        private int speed;
        private int wheelCount;

        public override string EngineType
        {
            get { return engineType; }
            set { engineType = value; }
        }
        public override bool HasEngine
        {
            get { return hasEngine; }
            set { hasEngine = value; }
        }
        public override string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public override int WheelCount
        {
            get { return wheelCount; }
            set { wheelCount = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool EngineRunning
        {
            get { return engineRunning; }
            set { engineRunning = value; }
        }

        public void motorAn()
        {
            throw new System.NotImplementedException();
        }

        public void motorAus()
        {
            throw new System.NotImplementedException();
        }
        public virtual string Info()
        {
            return ($"Motorart = {EngineType} Fahrzeugtyp = {Type} Räderanzahl = {WheelCount} Name = {Name}");
        }
        public override int speedUp(int speedUpValue)
        {
            return Speed = Speed + speedUpValue;
        }
    }
}