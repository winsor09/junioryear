using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class sport_car : car
    {

        protected bool is2seater;

        public sport_car(int weight, int height, int NumWheels, string make, string model, string engine_type, bool hastrunk, bool hashatchback, bool hasClosedBody, bool is2seater)
            : base(weight, height, NumWheels, make, model, engine_type, hastrunk, hashatchback, hasClosedBody)
        {

            this.is2seater = false;
            this.hashatchback = false;
            this.hastrunk = false;
        }

        public override void printcar()
        {
            Console.WriteLine("\nWeight: " + weight + "\nheight: " + height + "\nNumWheels: " + NumWheels + "\nMake: " + make + "\nModel: " + model + "\nEngine type: " + engine_type + "\nHas trunk: " + hastrunk + "\nHas hatchback: " + hashatchback + "\nHas Closed Body: " +hasClosedBody+ "\nIs 2 Seater: " + is2seater);
        }

    }

}
