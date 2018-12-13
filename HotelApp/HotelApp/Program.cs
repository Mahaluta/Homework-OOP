using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Program
    {

        
        static void Main(string[] args)
        {


            HotelManager A = new HotelManager();
            A.CreateHotel();
            A.CreateHotel();

            A.Hotels[0].AddRoom("C1");
            A.Hotels[0].AddRoom("C2");
            A.Hotels[1].AddRoom("C3");
            A.Hotels[1].AddRoom("C4");

            A.Hotels[0].RemoveRoom("C1");
            A.Hotels[1].RemoveRoom("C3");

            A.Hotels[1].UpdatePrice(1000);
            Console.WriteLine("After updating price: ");

            A.Print();            

            Console.ReadKey();
        }
        

        
    }
}
