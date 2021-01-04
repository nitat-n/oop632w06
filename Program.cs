using System;

namespace oop_w06
{
    class Program
    {
        static void Main(string[] args)
        {
            Building b4 = new Building("4","Building 4");
            b4.setRooms(0, new Room("433","433",4,4));
            b4.setRooms(1, new Room("431", "431", 8, 4));
            Console.WriteLine(b4.Name + " has area : " + b4.getBuildingArea());
            Console.ReadLine();

        }
    }
}
