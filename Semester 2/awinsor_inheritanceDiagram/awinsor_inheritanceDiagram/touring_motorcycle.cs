using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class touring_motorcycle : motorcycle
    {
        protected float storage_space;


        public touring_motorcycle(int weight, int height, int NumWheels, string make, string model, string engine_type, float handlebar_length, float storage_space)
            : base (weight, height, NumWheels, make, model, engine_type, handlebar_length)
        {

            this.storage_space = storage_space;

        }
        public override void printcar()
        {
            Console.WriteLine("\nWeight: " + weight + "\nheight: " + height + "\nNumWheels: " + NumWheels + "\nMake: " + make + "\nModel: " + model + "\nEngine type: " + engine_type + "\nHandle Bar Length: " + handlebar_length +"\nStorage Space: " + storage_space);
        }

    }
}
