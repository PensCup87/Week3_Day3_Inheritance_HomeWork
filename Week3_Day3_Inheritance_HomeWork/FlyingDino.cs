using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance_HomeWork
{
    class FlyingDino : Dinosaurs
    {
        public int numberOfWings;
        public string color;
        public int flyingSpeed;



        public int NumberOfWings
        {
            get { return this.numberOfWings; }
            set { this.numberOfWings = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = color; }
        }
        
        public int FlyingSpeed
        {
            get { return this.flyingSpeed; }
            set { this.flyingSpeed = value; }
        }
        public int DistanceCovered
        {
            get { return this.distanceCovered; }
        }

        public FlyingDino(int numberOfWings, string color, string name, string moveStyle, string eats, int flyingSpeed)
        {
            this.NumberOfWings = numberOfWings;
            this.Color = color;
            this.name = name;
            this.moveStyle = moveStyle;
            this.eats = eats;
            this.flyingSpeed = flyingSpeed;
            this.distanceCovered = 0;
        }

        public override void Running()
        {
            distanceCovered = distanceCovered + flyingSpeed;
        }
    }
}
