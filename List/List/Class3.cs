using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Queue
    {
        private LinkedList queue;
        public LinkedList CreateQueue()
        {
            LinkedList q = new LinkedList();
            return q;
        }

        public LinkedList Enqueue(LinkedList queue, object Data)
        {
            int count = 0;
            if (queue.GetFront() == null)
            {
                queue.InsertBeginning(Data);
                count++;
            } else
            {
                queue.InsertAfter(Data, count);
                count++;
            }
            return queue;
        }
        public LinkedList Dequeue(LinkedList queue)
        {
            object Data;
            if (queue.GetFront() != null)
            {
                Data = queue.GetFront();
                queue.RemoveBeginning();
            }
            return queue;
        }
    }




}

