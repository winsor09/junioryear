using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    class MeleeWeapon : Weapon
    {
        public MeleeWeapon(string description, WeaponType type, float damage)
            : base(description, type, damage)
        {

        }

        public override void ActivateItem()
        {
            Console.WriteLine(type.ToString() + " weapon just did " + damage + " damage to your opponent");
        }
    }
}
