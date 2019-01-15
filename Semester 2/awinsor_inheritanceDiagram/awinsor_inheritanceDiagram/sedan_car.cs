using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class sedan_car : car
    {

        

        public sedan_car(int weight, int height, int NumWheels, string make, string model, string engine_type, bool hastrunk, bool hashatchback, bool hasClosedBody)
            : base(weight, height, NumWheels, make, model, engine_type, hastrunk, hashatchback, hasClosedBody)
        {
            this.hasClosedBody = true;
        }

        public override void printcar()
        {

            Console.WriteLine("\nWeight: " + weight + "\nheight: " + height + "\nNumWheels: " + NumWheels + "\nMake: " + make + "\nModel: " + model + "\nEngine type: " + engine_type + "\nHas trunk: " + hastrunk + "\nHas hatchback: " + hashatchback + "\nHas Closed Body: " + hasClosedBody);
        }

    }
}
