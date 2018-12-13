using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        private List<int> coada = new List<int>();

        public void Enqueue(int num)
        {
            coada.Insert(0, num);
        }

        public void Dequeue()
        {
            if (coada.Count != 0)
                coada.RemoveAt(coada.Count-1);
            else
                Console.WriteLine("The queue is empty");
        }

        public void Print()
        {
            foreach(int element in coada)
            {
                Console.Write(element + " ");
            }
        }
    }
}
