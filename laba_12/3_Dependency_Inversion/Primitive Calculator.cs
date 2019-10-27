using System;
using System.Collections.Generic;
using System.Text;

namespace _3_Dependency_Inversion
{
    class Primitive_Calculator
    {
        public int Addition(int a, int b) => a + b;
        public int Substraction(int a, int b) => a - b;
        public int Multiplication(int a, int b) => a * b;
        public int Division(int a, int b) => a / b;

        public char @operator;
        public char ChangeStrategy()
        {
            return @operator;
        }
        public int PerformCalculation(int firstNumber, int secondNumber)
        {
            if (ChangeStrategy() =='+')
            {
                return Addition(firstNumber, secondNumber);
            }
            if (ChangeStrategy() == '-')
            {
                return Substraction(firstNumber, secondNumber);
            }
            if (ChangeStrategy() == '*')
            {
                return Multiplication(firstNumber, secondNumber);
            }
            if (ChangeStrategy() == '/')
            {
                return Division(firstNumber, secondNumber);
            }
            else
            {
                return Addition(firstNumber, secondNumber);
            }
        }
    }
}
