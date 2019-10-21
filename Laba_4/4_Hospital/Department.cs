﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Hospital
{
    class Department
    {
        public Department(string name)
        {
            this.Name = name;

            this.Rooms = new List<Room>();
            for (int i = 0; i < 20; i++)
            {
                Rooms.Add(new Room());
            }
        }

        public string Name { get; set; }
        public List<Room> Rooms { get; set; }
    }
}
