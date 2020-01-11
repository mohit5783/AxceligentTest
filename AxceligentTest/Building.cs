using System;
using System.Collections.Generic;

namespace AxceligentTest
{
    public class Building : List<Room>
    {
        public static List<Room> RoomsList { get; set; } = new List<Room>();
        public Building rooms { get; set; } 
        public Building AddKitchen()
        {
            rooms = new Building();
            rooms.Add(new Room("kitchen"));
            RoomsList.Add(new Room("kitchen"));
            return rooms;
        }
        public Building AddBedroom(string BedroomType)
        {
            rooms = new Building();
            rooms.Add(new Room(BedroomType));
            RoomsList.Add(new Room(BedroomType));
            return rooms;
        }
        public Building AddBalcony()
        {
            rooms = new Building();
            rooms.Add(new Room("balcony"));
            RoomsList.Add(new Room("balcony"));
            return rooms;
        }
        public BuiltProperty Build()
        {
            BuiltProperty bp = new BuiltProperty();
            string Desc = string.Empty;
            foreach(Room rm in RoomsList)
            {
                Desc += rm.RoomName + ", ";
            }
            bp.Description = Desc;
            return bp;
        }
    }
    public class Room
    {
        public string RoomName { get; set; }
        public Room(string roomName)
        {
            RoomName = roomName;
        }
    }
    public class BuiltProperty
    {
        public string Description { get; set; }
        public string Describe()
        {
            return Description;
        }
    }
}