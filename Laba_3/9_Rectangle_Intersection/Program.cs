using System;

namespace _9_Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int numbeOfRectangles = Convert.ToInt32(parameters[0]);
            int intersectionChecks = Convert.ToInt32(parameters[0]);

            Rectangle[] rectangles = new Rectangle[numbeOfRectangles];


            for (int i = 0; i < numbeOfRectangles; i++)
            {
                string[] parameters1 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string id = parameters1[0];
                int width = Convert.ToInt32(parameters1[1]);
                int height = Convert.ToInt32(parameters1[2]);
                int x = Convert.ToInt32(parameters1[3]);
                int y = Convert.ToInt32(parameters1[4]);
                rectangles[i] = new Rectangle(id, width, height, x, y);
            }

            int first = 0;
            int second = 0;
            for (int i = 0; i < intersectionChecks; i++)
            {
                string[] parameters2 = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string Id1 = parameters2[0];
                string Id2 = parameters2[1];

                for (int j = 0; j < numbeOfRectangles; j++)
                {
                    if (rectangles[j].id == Id1)
                    {
                        first = j;
                    }
                    if (rectangles[j].id == Id2)
                    {
                        second = j;
                    }
                }
                Console.WriteLine(rectangles[first].Check(rectangles[first], rectangles[second]));
            }
        }
    }
}
