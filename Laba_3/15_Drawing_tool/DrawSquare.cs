using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Drawing_tool
{
    class DrawSquare : Drawing
    {
        public static void Draw(int height)
        {
            for (int i = 0; i < height; i++)
            {

                Console.Write("|");
                if (i == 0 || i == height - 1)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Console.Write("-");
                    }
                }
                else
                {
                    for (int j = 0; j < height; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
        }
    }
}
