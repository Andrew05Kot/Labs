using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _7_Custom_List
{
    class Box<T> where T : IComparable<T>
    {
        public T Element { get; set; }
        public static int i = 0;
        private int index1;
        private int index2;
        public int count = 0;
        public List<T> Elements { get; set; } = new List<T>();

        public void Add(T element)
        {
            Elements.Add(element);
            i++;
        }
        public void Remove(int i)
        {
            this.Elements.Remove(this.Elements[i]);
        }
        public bool Contains(T element)
        {
            bool b = false;
            for (int j = 0; j < i; j++)
            {
                if (this.Elements[j].CompareTo(element) == 0)
                {
                    b = true;
                    break;
                }
            }
            return b;
        }
        public void Swap(int indexOne, int indexTwo)
        {
            this.index1 = indexOne;
            this.index2 = indexTwo;
            T str = this.Elements[index1];
            this.Elements[index1] = this.Elements[index2];
            this.Elements[index2] = str;
        }
        public int Greater(T element)
        {
            for (int j = 0; j < i; j++)
            {
                if (this.Elements[j].CompareTo(element) > 0)
                {
                    this.count++;
                }
            }
            return this.count;
        }

        public void Max()
        {
            T max = Elements[0];
            for (int j = 0; j < i; j++)
            {
                if (this.Elements[j].CompareTo(max) > 0)
                {
                    max = this.Elements[j];
                }
            }
            Console.WriteLine(max);
        }
        public void Min()
        {
            T min = Elements[0];
            for (int j = 0; j < i; j++)
            {
                if (this.Elements[j].CompareTo(min) < 0)
                {
                    min = this.Elements[j];
                }
            }
            Console.WriteLine(min);
        }
        public void Print()
        {
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(Elements[j]);
            }
        }
    }
}
