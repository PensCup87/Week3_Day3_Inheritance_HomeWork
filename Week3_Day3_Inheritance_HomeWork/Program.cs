﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3_Inheritance_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Dinosaurs baseDino = new Dinosaurs("T-Rex", "Steady jog", "Meat Eater", 3);
            baseDino.Running();
            baseDino.Running();
            baseDino.Running();
            Console.WriteLine(baseDino.distanceCovered);
        }
    }
}
