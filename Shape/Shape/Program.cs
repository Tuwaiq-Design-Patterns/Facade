using System;

//Example for DP Fascade

namespace Shape
{
    class Program
    {
        public class ShapeMaker
        {
            public Shape circle;
            public Shape rectangle;
            public Shape square;

            public ShapeMaker()
            {
                circle = new Circle();
                rectangle = new Rectangle();
                square = new Square();
            }

            public void DrawCircle()
            {
                circle.draw();
            }
            public void DrawRectangle()
            {
                rectangle.draw();
            }
            public void DrawSquare()
            {
                square.draw();
            }

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
            }


       public static void Main(string[] args)
        {
            ShapeMaker ShapeDraw = new ShapeMaker();

            ShapeDraw.DrawCircle();
            ShapeDraw.DrawRectangle();
            ShapeDraw.DrawSquare();
        }
    }
}
