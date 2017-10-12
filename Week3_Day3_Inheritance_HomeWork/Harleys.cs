using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance_HomeWork
{
    class Harleys
    {
        //fields
        protected int engineSize;
        protected double fuelTankCapacity;
        protected string rearTireWidth;
        protected int weight;

        //Properties (Instance Variables)

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
        protected int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Constructor(s)
        public Harleys()
        {
            //default constructor
        }

    }
}
