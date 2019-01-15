using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_inheritanceDiagram
{
    class Program
    {
        static void Main(string[] args)
        {

            List<motor_vehicle> motor_Vehicles = new List<motor_vehicle>();
            motor_Vehicles.Add(new truck(4000, 7, 4, "chevy", "colorado", "V8", 6));
            motor_Vehicles.Add(new muscle_car(4000, 5, 4, "pontiac", "GTO", "V8", true, false, true, true));
            motor_Vehicles.Add(new sport_car(4000, 4, 4, "chevy", "corvette", "LS3", false, false, true, true));
            motor_Vehicles.Add(new sedan_car(4000, 6, 4, "idk", "idc", "v5", false, true, true));
            motor_Vehicles.Add(new sport_motorcycle(3000, 4, 2, "Harley Davidson", "Iron 883", "v twin cylinder", 1f));
            motor_Vehicles.Add(new touring_motorcycle(3000, 4, 2, "Harley Davidson", "Road King", "v twin cylinder", 1f, 52f));
            motor_Vehicles.Add(new cruiser_motorcycle(3000, 4, 2, "Harley Davidson", "CVO limited", "v twin cylinder", 1f));


            for (int i = 0; i < motor_Vehicles.Count; i++)
            {
                motor_Vehicles[i].printcar();

            }

            Console.ReadLine();
        }
    }
}
