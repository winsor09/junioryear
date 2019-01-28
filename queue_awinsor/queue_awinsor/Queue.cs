using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_awinsor
{
    class Queue
    {

        List<int> holder = new List<int>();

        public Queue()
        {

        }

        //DeQueue
        public int DeQueue()
        {

            if (holder.Count >= 1)
            {
                int dumdum = holder[holder.Count - 1];

                holder.RemoveAt(holder.Count - 1);
                return dumdum;
            }

            else
                return -1;


        }

        //EnQueue
        public void EnQueue(int val)
        {

            holder.Insert(0, val);

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
