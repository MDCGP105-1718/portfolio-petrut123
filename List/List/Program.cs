using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            
            list.InsertBeginning(1);
            list.InsertBeginning(2);
            list.InsertBeginning(3);
            list.InsertBeginning(4);
            list.RemoveAfter(2);
            list.Length();
            Console.WriteLine();
            list.PrintList();
            Console.ReadLine();
        }
    }
}

