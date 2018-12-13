using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    public class Room
    {
        // constructors

        public Room(string name)
        {
            this.Name = name;
            
        }

        // fields
        public string Name { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public int Stars { get; set; }
        public Rate Rate = new Rate();

        // methods

        public void AddRate(decimal Amount, string Currency)
        {
            this.Rate.Amount = Amount;
            this.Rate.Currency = Currency;
        }

        public string GetPriceForDays(int numberOfDays)
        {
            return $"The room costs: {Rate.Amount * numberOfDays} {Rate.Currency} for {numberOfDays} days.";
        }

        public decimal GetPrice()
        {
            if (this.Children == 1)
            {
                return this.Rate.Amount * Convert.ToDecimal(1.3);
            }
            return this.Rate.Amount;
        }

        public void Print()
        {
            Console.WriteLine($"\tRoom {Name}:");
            Console.WriteLine($"\t\tAdults: {Adults}, Children: {Children}");
            this.Rate.Print();

            Console.WriteLine($"\t\tAfter calculation: {this.GetPrice()}");
        }
    }
}
