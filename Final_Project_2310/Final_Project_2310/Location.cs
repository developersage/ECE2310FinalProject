using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Location
    {
        private const int size = 15;
        private const int y_axis = 10;
        private const int x_axis = 14;
        private int x;
        private int y;

        public Location(Random a)
        {
            x = a.Next(0, size); y = a.Next(0, size);
        }
        public Location(int a, int b)
        {
            x = a; y = b;
        }
        public int X
        {
            get => x; set => x = value;
        }
        public int Y
        {
            get => y; set => y = value;
        }
        public int Size
        {
            get => size;
        }
        public void Display()
        {
            for (int i = y_axis; i >= 0; i--)
            {
                for (int j = 0; j <= x_axis * 2; j += 2)
                {
                    if (j == x * 2 && i == y)
                    {
                        if (j == 0 && i == 0 || j == 0)
                        {
                            Console.WriteLine();
                        }
                        Console.Write("[]");
                    }
                    else if (j == 0 && i != 0)
                    {
                        Console.Write("\n| ");
                    }
                    else if (i == 0 && j != 0)
                    {
                        Console.Write("--");
                    }
                    else if (i == 0 && j == 0)
                    {
                        Console.Write("\n*-");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
            }
            Console.WriteLine();
        }
        public override string ToString()
        {
            return String.Format("({0},{1})", x, y);
        }
    }
}
