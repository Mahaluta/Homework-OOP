using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stiva = new Stack();

            // testing Push(int num)
            stiva.Push(1);
            stiva.Push(2);
            stiva.Push(3);
            stiva.Push(4);
            stiva.Push(5);
            Console.WriteLine();
            stiva.Print();

            // testing Pop()
            Console.WriteLine();
            stiva.Pop();
            stiva.Pop();
            

            Console.WriteLine();
            stiva.Print();
            Console.ReadKey();

            

        }
    }
}
