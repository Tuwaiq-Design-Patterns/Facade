using System;

namespace Facade
{
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square");
        }
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle");
        }
    }


    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.drawCircle();
            shapeMaker.drawRectangle();
            shapeMaker.drawSquare();
        }
    }
}
