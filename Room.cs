using System;
using System.Collections.Generic;
using System.Text;

namespace oop_w06
{
    class Room
    {
        private string name;
        private string code;
        private int width;
        private int length;
        public Room() { }
        public Room(string c,string n,int w,int l) {
            this.Code = c;
            this.Name = n;
            this.Width = w;
            this.Length = l;
        }

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public int Width { get => width; set => width = value; }
        public int Length { get => length; set => length = value; }

        public int getArea() {
            return this.Length * this.Width;
        }
        public int allowAmount(int peoplePer2Meters) {
            return (int)this.getArea() / peoplePer2Meters;
        }
    }

 }
