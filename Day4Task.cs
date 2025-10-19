using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    interface IShape
    {
        double GetArea();
    }
    class Circle : IShape
    {
        public int Radius;

        public Circle(int radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class Rectangle : IShape
    {
        public int Length;
        public int Width;

        public Rectangle(int length,int width)
        {
            Length = length;
            Width = width;
        }
        public double GetArea()
        {
            return Length * Width;
        }
      
    }
    class Square : IShape
    {
        public int Side;
        public Square(int side)
        {
            Side = side;
        }
        public double GetArea()
        {
            return Side * Side;
        }
    }
    class Program4
    {
        public static void Main3()
        {
            IShape c = new Circle(3);
            IShape r = new Rectangle(3, 4);
            IShape s = new Square(5);

            Console.WriteLine($"Area of the Circle:{c.GetArea()}");
            Console.WriteLine($"Area of the Rectangle:{r.GetArea()}");
            Console.WriteLine($"Area of the Square:{s.GetArea()}");
        }
    }
}
