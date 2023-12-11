using Hospital_Management__System.Data;
using Hospital_Management__System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management__System.Service
{
    public class RoomService
    {
        public void AddRoom()
        {
            var context1 = new HospitalContext();
            using (context1)
            {
                // Create a new Room
                var newRoom = new Room();

                Console.WriteLine("Add Room");

                
                Console.WriteLine("RoomNumber:");
                newRoom.RoomNumber = Console.ReadLine();
                Console.WriteLine("Specialty:");
                newRoom.RoomType = Console.ReadLine();



                // Add the new doctor to the context and save changes
                context1.Rooms.Add(newRoom);
                context1.SaveChanges();
                Console.WriteLine("added successifully");
            }
        }
        public void ViewRoom()
        {
            using (var context2 = new HospitalContext())
            {
                // Retrieve Rooms
                var rooms = context2.Rooms.ToList();

                // Display or process the retrieved Rooms
                foreach (var room in rooms)
                {
                    Console.WriteLine($"Room Number: {room.RoomNumber}");
                    Console.WriteLine($"Room Type: {room.RoomType}");

                    Console.WriteLine();
                }
            }
        }
        public void RemoveRoom()
        {
            using (var context4 = new HospitalContext())
            {
                // Find a Room to delete
                Console.WriteLine("Enter RoomID to Delete Room");
                var input = Convert.ToInt32(Console.ReadLine());
                var RoomToDelete = context4.Rooms.Find(input);

                // Delete the patient if found
                if (RoomToDelete != null)
                {
                    // Delete the patient from the context and save changes
                    context4.Rooms.Remove(RoomToDelete);
                    context4.SaveChanges();
                    Console.WriteLine("Room Deleted Successifully");
                }
            }
        }
        public void RoomUI()
        {
            Console.WriteLine("1.Add Room");
            Console.WriteLine("2.View Rooms");
            Console.WriteLine("3.Delete Room");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    AddRoom();
                    break;

                case 2:
                    ViewRoom();
                    break;

                case 3:
                    RemoveRoom();
                    break;

                default:
                    Console.WriteLine("wrong choice");
                    break;
            }
        }
    }
    
}
