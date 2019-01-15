using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    abstract class motor_vehicle
    {
        public int weight;
        public int height;
        public int NumWheels;
        public string make;
        public string model;
        public string engine_type;

        public motor_vehicle(int weight, int height, int NumWheels, string make, string model, string engine_type)
        {
            this.weight = weight;
            this.height = height;
            this.NumWheels = NumWheels;
            this.make = make;
            this.model = model;
            this.engine_type = engine_type;
        }

        public abstract void printcar();
        
    }

   
}
