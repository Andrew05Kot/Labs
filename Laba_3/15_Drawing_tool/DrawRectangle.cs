using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Drawing_tool
{
    class DrawRectangle : Drawing
    {
        public static void Draw(int height, int width)
        {
            for (int i = 0; i < height; i++)
            {

                Console.Write("|");
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(" - ");
                    }
                }
                else
                {
                    for (int j = 0; j < width; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
        }
    }
}
