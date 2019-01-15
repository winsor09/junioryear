using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    class ElementalMeleeWeapon : MeleeWeapon
    {
        protected ElementType elementType;
        protected float elementDamage;
        public ElementalMeleeWeapon(string description, WeaponType type, float damage, ElementType elementType, float elementDamage)
            : base(description, type, damage)
        {
            this.type = type;
            this.damage = damage;
            this.elementType = elementType;
            this.elementDamage = elementDamage;
        }

        public override void ActivateItem()
        {
            base.ActivateItem();
            Console.WriteLine("The " + elementType.ToString() + " element component of this weapon did an additional " + elementDamage + " damage to your enemy");
        }
    }
}
