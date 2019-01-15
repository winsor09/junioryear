using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    class InstantConsumable : Consumable
    {
        public InstantConsumable(string description, ConsumableType type, float potency)
            :base(description, type, potency)
        {

        }

        public override void ActivateItem()
        {
            Console.WriteLine("Instant " + type.ToString() + " consumable of " + potency + " potency activated");
        }
    }
}
