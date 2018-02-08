using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class LinkedList
    {
        public class Node
        {
            public object Content;
            public Node Next;
        }

        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public Node GetFront()
        {

            return head;
        }

        public void InsertBeginning(object Data)
        {
            Node newNode = new Node();
            newNode.Content = Data;

            if (head == null)
            { 
              newNode.Next = null; 
            }
            else
            {
              newNode.Next = head;
            }
            head = newNode;
        }

        public void PrintList()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.Content.ToString());
                current = current.Next;
            }
        }

        public void InsertAfter(object Data, int index)
        {
            Node newNode = new Node();
            newNode.Content = Data;

            int count = 0;
            Node currentNode = head;
            while (count < index)
            {
                if (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;

                }
                else
                {
                    break;
                }
                count++;
            }
            newNode = currentNode.Next;
            currentNode.Next = newNode;
        }
        public void RemoveBeginning()
        {
            
            if (head != null)
            {
                head = head.Next;
            }
        }
        public void RemoveAfter(int index)
        {
            int count = 0;
            Node currentNode = head;
            if (head != null)
            {
                
                while (count < index)
                {
                    if (currentNode.Next != null)
                    {
                        currentNode = currentNode.Next;

                    }
                    else
                    {
                        break;
                    }
                    count++;
                }
                if (currentNode.Next != null)
                {
                    currentNode.Next = currentNode.Next.Next;
                }
                else
                {
                    Console.WriteLine("You can't delete this!");
                }
            }
        }
        public int Length()
        {
            Node currentNode = head;
            int count = 0;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                count++;
            }
            Console.WriteLine(count + 1);
            return count + 1;
        }
      
    }

}
