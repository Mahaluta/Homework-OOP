using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        private List<int> list = new List<int>();
        

        public void Push(int num)
        {
            list.Add(num);
        }

        public void Pop()
        {
            if (list.Count != 0)
                list.Remove(list.Count);
            else
                Console.WriteLine("The stack is empty.");
        }

        public void Print()
        {
            foreach (int element in list)
                Console.Write(element + " ");
        }
    }
}
