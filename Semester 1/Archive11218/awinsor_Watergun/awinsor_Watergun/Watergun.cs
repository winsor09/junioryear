using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace awinsor_Watergun
{
    class Watergun
    {
        public float capacity;
        public float amount;
        public bool isWet;
        Random rand = new Random();


        public bool Shoot(float amount)
        {

            if (capacity > 0)
            {
                capacity -= amount;
                float percChance = (amount * .2f) + .2f;
                
                if(rand.NextDouble() < percChance)
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }
            
            else
            {
                return false;
            }

        }

        public void Reload()
        {
            capacity += .25f;
        }

    }
}
