using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance_HomeWork
{
    class Harleys
    {
        //fields (Instance Variables)
        protected int engineSize;
        protected double fuelTankCapacity;
        protected string rearTireWidth;
        protected string color;
        //protected int weight;
        protected int travelingSpeed;

        //Properties 

        protected int EngineSize
        {
            get { return this.engineSize; }

        }
        protected double FuelTankCapacity
        {
            get { return this.fuelTankCapacity; }
            set { this.fuelTankCapacity = value; }
        }
        protected string RearTireWidth
        {
            get { return this.rearTireWidth; }
            set { this.rearTireWidth = value; }
        }
        protected string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        //Constructor(s)
        public Harleys()
        {
            //default constructor
        }
        public Harleys(int engineSize, double fuelTankCapacity, string rearTireWidth, string color, int travelingSpeed)
        {
            this.engineSize = engineSize;
            this.fuelTankCapacity = fuelTankCapacity;
            this.rearTireWidth = rearTireWidth;
            this.color = color;
            this.travelingSpeed = travelingSpeed;
        }
    }
}
