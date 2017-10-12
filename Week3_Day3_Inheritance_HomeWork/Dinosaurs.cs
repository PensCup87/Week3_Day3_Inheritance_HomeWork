using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance_HomeWork
{
    class Dinosaurs
    {
        protected string name;
        protected string moveStyle;
        protected string eats;
        protected int runningSpeed;
        public int distanceCovered;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string MoveStyle
        {
            get { return this.moveStyle; }
            set { this.moveStyle = value; }
        }
        public string Eats
        {
            get { return this.eats; }
            set { this.eats = value; }
        }

        public Dinosaurs()
        {
            //default constructor
        }
        public Dinosaurs(string name, string moveStyle, string eats, int runningSpeed)
        {
            this.name = name;
            this.moveStyle = moveStyle;
            this.eats = eats;
            this.runningSpeed = 0;
            this.distanceCovered = 0;

        }

        public virtual void Running()
        {
            distanceCovered = distanceCovered + runningSpeed;
        }
            
    }
}
