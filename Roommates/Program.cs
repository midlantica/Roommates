using System;
using System.Collections.Generic;
using Roommates.Models;
using Roommates.Repositories;

namespace Roommates
{
    class Program
    {
        /// <summary>
        ///  This is the address of the database.
        ///  We define it here as a constant since it will never change.
        /// </summary>
        private const string CONNECTION_STRING = @"server=localhost\SQLExpress;database=Roommates;integrated security=true";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            RoomRepository roomRepo = new RoomRepository(CONNECTION_STRING);
            RoommateRepository roommateRepo = new RoommateRepository(CONNECTION_STRING);

            Console.WriteLine("Getting All Rooms:");
            Console.WriteLine();

            List<Room> allRooms = roomRepo.GetAll();

            foreach (Room room in allRooms)
            {
                Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            }

            //>>>>>>>>>>>>>>>>>
            Console.WriteLine("----------------------------");
            Console.WriteLine("Getting Room with Id 1");

            Room singleRoom = roomRepo.GetById(1);

            Console.WriteLine($"{singleRoom.Id} {singleRoom.Name} {singleRoom.MaxOccupancy}");

            // >>>>>>>>>>>>>>>>
            Room bathroom = new Room
            {
                Name = "Bathroom",
                MaxOccupancy = 1
            };

            roomRepo.Insert(bathroom);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Added the new Room with id {bathroom.Id}");


            // >>>>>>>>>>>>>>>>
            // 18. Write some code in Program.Main to test the Update method.
            Room kitchen = new Room
            {
                Name = "La Cocina",
                MaxOccupancy = 1
            };

            roomRepo.Insert(kitchen);

            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Added the new Room with id {kitchen.Id} and name of {kitchen.Name}");

            // >>>>>>>>>>>>>>>>>
            // >>>>>>>>>>>>>>>>
            // 20. Write some code in Program.Main to test the Delete method.
            roomRepo.Delete(kitchen.Id);

            Console.WriteLine("-------------------------------");
            foreach (Room room in allRooms)
            {
                Console.WriteLine($"{room.Id} {room.Name} {room.MaxOccupancy}");
            }

            // >>>>>>>>>>>>>>>>>>>>>>>.
            // >>>>>>>>>>>>>>>>>>>>>>>.
            // >>>>>>>>>>>>>>>>>>>>>>>.
            Console.WriteLine("-------------------------------");
            Console.WriteLine("ROOMATE!!");

            List<Roommate> allRoommates = roommateRepo.GetAll();
            
            foreach (Roommate roomy in allRoommates)
            {
                Console.WriteLine($"{roomy.Id}, {roomy.Firstname} {roomy.Lastname}, {roomy.MoveInDate}");
            }

            foreach (roommatesByRoom roomy in allRoommates)
            {
                Console.WriteLine($"{roomy.Id}, {roomy.Firstname} {roomy.Lastname}, {roomy.MoveInDate}");
            }

        }
    }
}
