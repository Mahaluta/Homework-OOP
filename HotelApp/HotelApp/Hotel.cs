using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp
{
    class Hotel
    {

        public Hotel(string Name, string City, int Stars)
        {
            this.Name = Name;
            this.City = City;
            this.Stars = Stars;
        }

        public string Name { get; set; }
        public string City { get; set; }
        public int Stars {get;set;}
        public List<Room> Rooms = new List<Room>();

        public void AddRoom(string roomName)
            {
                Room room = new Room(roomName);

            Console.WriteLine("You're adding a new room");
            Console.WriteLine("Read the specifications");
                Console.WriteLine("How many adults?: ");
                room.Adults = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many children?: ");
                room.Children = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many stars?: ");
                room.Stars = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What rate?: ");
            room.Rate.Amount = Convert.ToDecimal(Console.ReadLine());
            room.Rate.Currency = Console.ReadLine();
            

            Rooms.Add(room);
            }

        public void RemoveRoom(string roomName)
        {
            foreach (Room room in Rooms.ToList())
            {
                if (room.Name == roomName)
                    this.Rooms.Remove(room);
            }
        }

        public void UpdatePrice(decimal Amount)
        {
            foreach (Room room in Rooms)
            {
                room.Rate.Amount = Amount;

            }
        }



        public void Print()
        {
            Console.WriteLine($"Hotel: {Name}");
            Console.WriteLine($"\tCity: {City}, Stars: {Stars}");
            foreach (var room in Rooms)
            {
                room.Print();
            }
        }

        public decimal GetPriceForNumberOfRooms(int numberOfRooms)
        {
            decimal sum = 0;

            if (Rooms.Count >= numberOfRooms)
            {
                for (int i = 0; i < numberOfRooms; i++)
                {
                    sum = sum + Rooms[i].GetPrice();
                }
            }
            else
            {
                Console.WriteLine("Not enough rooms!");
            }

            return sum;
        }

        public Room FindRoomWithLowerPriceThan(decimal price)
        {
            foreach (var room in Rooms)
            {
                if (room.GetPrice() < price)
                {
                    return room;
                }
            }

            return null;
        }

        public decimal GetPriceForAllRooms()
        {
            decimal x = 0;

            foreach (var room in Rooms)
            {
                x = x + room.Rate.Amount;
            }

            return x;
        }

        ~Hotel()
        {
            Console.WriteLine("The destructor is called");
        }
    }
}
