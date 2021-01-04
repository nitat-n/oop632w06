using System;
using System.Collections.Generic;
using System.Text;

namespace oop_w06
{
    class Building
    {
        private string code;
        private string name;
        private Room[] rooms = new Room[20];

        public Building() { }
        public Building(string c,string n) {
            this.Code = c;
            this.Name = n;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        //internal Room[] Rooms { get => rooms; set => rooms = value; }
        public void setRooms(int index,Room room) {
            this.rooms[index] = room;
        }
        public Room getRoom(int index) {
            return this.rooms[index];
        }
        public int getBuildingArea() {
            int totalArea = 0;
            for (int i=0;i<rooms.Length;i++) {
                if (this.rooms[i] != null) {
                    totalArea += this.rooms[i].getArea();
                }
            }
            return totalArea;
        }

    }
}
