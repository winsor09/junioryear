﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class sport_motorcycle : motorcycle
    {
        public sport_motorcycle(int weight, int height, int NumWheels, string make, string model, string engine_type, float handlebar_length)
           : base(weight, height, NumWheels, make, model, engine_type, handlebar_length)
        {
        }
        public override void printcar()
        {
            Console.WriteLine("\nWeight: " + weight + "\nheight: " + height + "\nNumWheels: " + NumWheels + "\nMake: " + make + "\nModel: " + model + "\nEngine type: " + engine_type + "\nHandle Bar Length: " + handlebar_length);
        }
    }
}
