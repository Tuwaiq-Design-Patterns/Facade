using System;

namespace Faced
{
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

        public void DrawShap() // This method is to hide implementation details from the user
        { 

            circle.Draw(); 
        

            rectangle.Draw();
        

            square.Draw();
        }
    }
    

    public interface Shape
    {
        void Draw();
    }
    public class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Rectangle ..");

        }
    }
    public class Square : Shape
        { 
    public void Draw()
    {
             Console.WriteLine("Drawing Square ..");
     }
       }
    public class Circle : Shape
        {

            
         public void Draw()
        {
                Console.WriteLine("Drawing Circle ..");
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeMaker shapeMaker = new ShapeMaker();

            shapeMaker.DrawShap();
        }
    }
}