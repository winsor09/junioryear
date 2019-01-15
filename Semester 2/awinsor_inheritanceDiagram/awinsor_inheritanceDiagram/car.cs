using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class car : motor_vehicle
    {
        protected bool hastrunk;
        protected bool hashatchback;
        protected bool hasClosedBody;

        public car(int weight, int height, int NumWheels, string make, string model, string engine_type, bool hastrunk, bool hashatchback, bool hasClosedBody)
            : base(weight, height, NumWheels, make, model, engine_type)
        {

            this.hastrunk = hastrunk;
            this.hashatchback = hashatchback;
            this.hasClosedBody = hasClosedBody;

    }

        public override void printcar()
        {

            Console.WriteLine("\nWeight: " + weight + "\nheight: " + height + "\nNumWheels: " + NumWheels + "\nMake: " + make + "\nModel: " + model + "\nEngine type: " + engine_type + "\nHas trunk: " + hastrunk + "\nHas hatchback: " + hashatchback + "\nHas Closed Body: " + hasClosedBody);
        }
    }
}
