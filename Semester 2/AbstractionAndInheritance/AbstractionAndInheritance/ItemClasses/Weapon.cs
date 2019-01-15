using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    enum ElementType { Fire, Ice, Lightning }
    enum WeaponType { Wood, Rock, Metal }
    abstract class Weapon : Item
    {
        protected WeaponType type;
        protected float damage;

        public Weapon(string description, WeaponType type, float damage)
            : base(description)
        {
            this.type = type;
            this.damage = damage;
        }
    }
}
