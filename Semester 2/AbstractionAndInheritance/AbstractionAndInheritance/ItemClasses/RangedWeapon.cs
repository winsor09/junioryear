using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    class RangedWeapon : Weapon
    {
        protected int ammoCapacityMax;
        protected int ammoCapacityCur;
        public RangedWeapon(string description, WeaponType type, float damage, int ammoCapacityMax)
            : base(description, type, damage)
        {
            this.ammoCapacityMax = ammoCapacityMax;
            ammoCapacityCur = ammoCapacityMax;
        }

        public override void ActivateItem()
        {
            if (ammoCapacityCur > 0)
            {
                Console.WriteLine(type.ToString() + " ranged weapon just did " + damage + " damage to your opponent. You have " + ammoCapacityCur + " remaining ammo.");
                ammoCapacityCur--;
            }
            else
            {
                Console.WriteLine("No more ammo for ranged weapon!");
            }
        }
    }
}
