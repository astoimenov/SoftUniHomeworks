namespace Abstraction
{
    using System;

    public class FiguresExample
    {
        public static void Main()
        {
            IFigure[] figures =
            {
                new Circle(5),
                new Rectangle(2, 3)
            };

            foreach (IFigure figure in figures)
            {
                Console.WriteLine(
                "I am a " + figure.GetType().Name + ". " + "My perimeter is {0:f2}. My surface is {1:f2}.",
                figure.CalcPerimeter(), figure.CalcSurface());
            }
        }
    }
}
