using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInheritance.ItemClasses
{
    abstract class Item
    {
        protected string description;

        public Item(string description)
        {
            this.description = description;
        }

        public abstract void ActivateItem();
    }
}
