using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class truck : motor_vehicle
    {

        protected float BedSize;


        public truck(int weight, int height, int NumWheels, string make, string model, string engine_type, float BedSize)
            :base (weight, height, NumWheels, make, model, engine_type)
        {
            this.BedSize = BedSize;
        }

        public override void printcar()
        {
            Console.WriteLine("\nWeight: " + weight + "\nheight: " + height + "\nNumWheels: " + NumWheels + "\nMake: " + make + "\nModel: " + model + "\nEngine type: " + engine_type + "\nBed Size: " + BedSize);
        }
    }
}
