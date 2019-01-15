using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractionAndInheritance.ItemClasses;

namespace AbstractionAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first part of this program demonstrates different types of items in a list. Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine("\n");
            List<Item> inventory = new List<Item>();
            inventory.Add(new InstantConsumable("This item heals you for 50 health points", ConsumableType.HP, 50));
            inventory.Add(new OverTimeConsumable("This item restores 75 mana points over 5 seconds", ConsumableType.Mana, 75, 5));
            inventory.Add(new MeleeWeapon("A rock melee weapon that does 10 damage with no element", WeaponType.Rock, 10));
            inventory.Add(new ElementalMeleeWeapon("A wood melee weapon that does 5 damage with a fire element that does 15 damage", WeaponType.Wood, 5, ElementType.Fire, 15));
            inventory.Add(new RangedWeapon("A wood ranged weapon that does 15 damage with no element that can hold 10 arrows", WeaponType.Wood, 15, 10));
            inventory.Add(new ElementalRangedWeapon("A steel ranged weapon that does 20 damage with a lightning element that does an additional 25 damage that can hold 15 arrows", WeaponType.Metal, 20, 15, ElementType.Lightning, 25));

            for (int i = 0; i < inventory.Count; i++)
            {
                inventory[i].ActivateItem();
                Console.WriteLine();
                Console.WriteLine("Press any key to continue:");
                Console.ReadKey();
                Console.WriteLine("\n");
            }

            Console.WriteLine("You have seen every item in your inventory. Next part is demonstrating ammo usage. Press any key to continue:");
            Console.ReadKey();
            Console.WriteLine("\n");

            Item bow = new RangedWeapon("A wood ranged weapon that does 15 damage with no element that can hold 7 arrows", WeaponType.Wood, 15, 7);

            for (int i = 0; i < 10; i++)
            {
                bow.ActivateItem();
            }

            Console.WriteLine("End of testing. Press any key to terminate program");
            Console.ReadKey();
        }
    }
}
