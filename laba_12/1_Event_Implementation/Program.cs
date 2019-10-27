using System;

namespace _1_Event_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var dispatcher = new Dispatcher();
            var handler = new Hendler();
            dispatcher.NameChange += handler.OnDispatcherNameChange;

            var name = Console.ReadLine();

            while (name != "End")
            {
                dispatcher.Name = name;
                name = Console.ReadLine();
            }
        }
    }
}
