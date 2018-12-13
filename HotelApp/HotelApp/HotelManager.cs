using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class HotelManager
    {
        public List<Hotel> Hotels = new List<Hotel>();

        public void CreateHotel()
        {
            Console.WriteLine("You're creating a new hotel;");
            Console.WriteLine("Read the specifications: ");
            Console.WriteLine("What's the name of the hotel: ");
            string name = Console.ReadLine();
            Console.WriteLine("In which city is this hotel placed?: ");
            string city = Console.ReadLine();
            Console.WriteLine("How many stars does it have?: ");
            int stars = Convert.ToInt32(Console.ReadLine());

            var hotel = new Hotel(name, city, stars);
            Hotels.Add(hotel);
        }

        public void RemoveHotel(string name)
        {
            foreach (Hotel hotel in Hotels)
            {
                if (hotel.Name == name)
                {
                    Hotels.Remove(hotel);
                }
            }
        }

        public void Print()
        {
            foreach (var hotel in Hotels)
            {
                hotel.Print();
            }
        }
    }
}
