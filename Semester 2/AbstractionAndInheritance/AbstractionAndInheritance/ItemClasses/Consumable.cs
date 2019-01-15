using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    enum ConsumableType { HP, Mana, Buff }
    abstract class Consumable : Item
    {
        protected ConsumableType type;
        protected float potency;

        public Consumable(string description, ConsumableType type, float potency)
            : base(description)
        {
            this.type = type;
            this.potency = potency;
        }
    }
}
