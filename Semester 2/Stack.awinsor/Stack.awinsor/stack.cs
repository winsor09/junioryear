using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.awinsor
{
    class stack
    {
        
        List<int> holder = new List<int>();

        public stack()
        {

        }

        //push
        public void Push(int val)
        {
            

            holder.Add(val);
        }

        //pop
        public int Pop()
        {
            
            if (holder.Count > 1)
            {
                int dumdum = holder[holder.Count - 1];

                holder.RemoveAt(holder.Count - 1);

                return dumdum;
            }
            else
            return 000000000000000000000000000000000000000000000000000000000000000000000000000000000000000;
            
        }

        //peek
        public int Peek()
        {
            if (holder.Count > 1)
            {
                int dumdum = holder[holder.Count - 1];

                return dumdum;
            }

            else
                return 0000000000000000000000000000000000000000000000000000000000000000000000000000000000;
        }

        //print
        public void Print()
        {
            for (int i = 0; i < holder.Count; i++)
            {
                Console.WriteLine(holder[i]);
            }
        }
    }
}
