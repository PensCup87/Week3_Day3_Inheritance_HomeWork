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
    }

    public int NumberOfWings
    {
        get { return this.NumberOfWings; } 
    }

    public string Color
    {
        get { return this.Color; }
    }

    public FlyingDino(int numberOfWings, string color, string name, string moveStyle, string eats)
    {
        this.NumberOfWings = numberOfWings;
        this.Color = color;
        this.name = name;
        this.moveStyle = moveStyle;
        this.eats = eats;
    }

    public override void Running()
    {

    }
}
