using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_Dependency_Inversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine().Split();
            char @operator = '+';

            while (!command[0].Equals("End"))
            {
                if (command[0].Equals("mode"))
                {
                    @operator = char.Parse(command[1]);
                }
                else
                {
                    var firstNumber = int.Parse(command[0]);
                    var secondNumber = int.Parse(command[1]);

                    Primitive_Calculator primitivCalculator = new Primitive_Calculator();

                    primitivCalculator.@operator = @operator;

                    Console.WriteLine(primitivCalculator.PerformCalculation(firstNumber, secondNumber));
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
