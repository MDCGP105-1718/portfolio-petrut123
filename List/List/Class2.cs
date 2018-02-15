using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    
    class Stack
    {
        int Counter = 0;

        private LinkedList stack;


        public LinkedList CreateStack()
        {
            LinkedList s = new LinkedList();
            return s;
        }
        public LinkedList DestroyStack(LinkedList stack)
        {
            while (stack != null)
            {
                stack.RemoveBeginning();
            }
            return stack;
        }
        public LinkedList Pop(LinkedList stack)
        {
            object Data;
            if (stack.GetFront() != null)
            {
                Data = stack.GetFront();
                stack.RemoveBeginning();
                Counter--;
            }
            return stack;
        }
        public LinkedList Push(LinkedList stack, object Data)
        {
            stack.InsertBeginning(Data);
            Counter++;
            return stack;
        }
        public bool IsEmpty(LinkedList stack, object Data)
        {
            if (stack.GetFront() == null)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public object Peek(LinkedList stack)
        {
            return  stack.GetFront();
        }
        public int Count(LinkedList stack)
        {
            return Counter;
        }
    }
}
