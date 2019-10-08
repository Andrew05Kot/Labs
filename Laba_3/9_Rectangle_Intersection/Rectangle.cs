using System;
using System.Collections.Generic;
using System.Text;

namespace _9_Rectangle_Intersection
{
    class Rectangle
    {
        public string id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int x { get; set; }
        public int y { get; set; }

        public Rectangle(string id, int width, int heigth, int x, int y)
        {
            this.id = id;
            this.width = width;
            this.height = heigth;
            this.x = x;
            this.y = y;
        }
        public bool Check(Rectangle ractangle1, Rectangle ractangle2)
        {

            if((ractangle1.x >= ractangle2.x && ractangle1.x <= ractangle2.x + ractangle2.width)
                || (ractangle1.x + ractangle1.width >= ractangle2.x && ractangle1.x + ractangle1.width <= ractangle2.x + ractangle2.width)
                || (ractangle1.y + ractangle1.height >= ractangle2.y && ractangle1.y + ractangle1.height <= ractangle2.y + ractangle2.height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
