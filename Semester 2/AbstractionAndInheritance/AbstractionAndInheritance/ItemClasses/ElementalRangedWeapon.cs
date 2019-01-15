using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    class ElementalRangedWeapon : RangedWeapon
    {
        protected ElementType elementType;
        protected float elementDamage;
        public ElementalRangedWeapon(string description, WeaponType type, float damage, int ammoCapacityMax, ElementType elementType, float elementDamage)
            : base(description, type, damage, ammoCapacityMax)
        {
            this.elementType = elementType;
            this.elementDamage = elementDamage;
        }

        public override void ActivateItem()
        {
            if (ammoCapacityCur > 0)
            {
                base.ActivateItem();
                Console.WriteLine("The " + elementType.ToString() + " element of this weapon did an additional " + elementDamage + " damage to the enemy");
            }
        }
    }
}
