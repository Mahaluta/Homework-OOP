using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Rate
    {
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        
        public void Print()
        {
            Console.WriteLine($"The price is: {Amount} {Currency}");
        }

    }
}
