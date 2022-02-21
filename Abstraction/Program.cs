using System;

namespace Abstraction
{
    abstract class Shape
    {
        public abstract float area();
    }
    class Square: Shape
    {
        private float side;
        public Square(float x)
        {
            side = x;
        }
        public override float area()
        {
            Console.Write(" Area of square:");
            return (side * side);
         
        }
    }
    class GFI
    {
        static void Main(string[] args)
        {
            Shape sh = new Square(4);
            float result = sh.area();
            Console.WriteLine("{0}",result);
        }
    }
}
