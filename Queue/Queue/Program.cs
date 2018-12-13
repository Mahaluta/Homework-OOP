using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue coada = new Queue();
            coada.Enqueue(1);
            coada.Enqueue(2);
            coada.Enqueue(3);
            coada.Enqueue(4);

            coada.Dequeue();

            coada.Print();
            Console.ReadKey();
            
            }
        }
    }

