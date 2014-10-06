namespace P01Shapes
{
    using System;

    public class Shapes
    {
        public static void Main()
        {
            BasicShape[] shapes = new BasicShape[]
            {
                new Triangle(5, 10, 60),
                new Rectangle(15, 13),
                new Circle(8) 
            };

            foreach (BasicShape shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine("Area: \t\t{0:##.00}", shape.CalculateArea());
                Console.WriteLine("Perimeter: \t{0:##.00}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}
