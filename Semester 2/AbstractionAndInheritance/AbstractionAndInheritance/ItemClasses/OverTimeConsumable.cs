using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    class OverTimeConsumable : Consumable
    {
        protected float duration;
        public OverTimeConsumable(string description, ConsumableType type, float potency, float duration)
            :base(description, type, potency)
        {
            this.duration = duration;
        }

        public override void ActivateItem()
        {
            Console.WriteLine("Over time " + type.ToString() + " consumable of " + potency + " potency and " + duration + " duration activated");
        }
    }
}
