using System;

namespace _15_Drawing_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if(figure == "square")
            {
                Console.WriteLine("Height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                DrawSquare.Draw(height);
            }
            else if(figure == "rectangle")
            {
                Console.WriteLine("Height: ");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Wight: ");
                int width = Convert.ToInt32(Console.ReadLine());
                DrawRectangle.Draw(height, width);
            }

        }
    }
}
