using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue_awinsor
{
    class QueueGeneric<T> : IEmptyable, IPrintable, ICountable where T : IComparable
    {

        List<T> holder = new List<T>();

        public QueueGeneric(){}

        public void Count()
        {
            throw new NotImplementedException();
        }

        public void Empty()
        {
            throw new NotImplementedException();
        }

        //DeQueue
        public T DeQueue()
        {

            if (holder.Count >= 1)
            {
                T dumdum = holder[holder.Count - 1];

                holder.RemoveAt(holder.Count - 1);
                return dumdum;
            }

            else
                return default(T);


        }


        //EnQueue
        public void EnQueue(T val)
        {

            holder.Insert(0, val);

        }

        //peek
        public T Peek()
        {
            if (holder.Count > 1)
            {
                T dumdum = holder[holder.Count - 1];

                return dumdum;
            }

            else
                return default(T);
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
