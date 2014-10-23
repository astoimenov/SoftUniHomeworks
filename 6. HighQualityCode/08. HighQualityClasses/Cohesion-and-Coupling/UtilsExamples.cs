namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(Files.GetExtension("example"));
            Console.WriteLine(Files.GetExtension("example.pdf"));
            Console.WriteLine(Files.GetExtension("example.new.pdf"));

            Console.WriteLine(Files.GetName("example"));
            Console.WriteLine(Files.GetName("example.pdf"));
            Console.WriteLine(Files.GetName("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                DistanceCalulator.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                DistanceCalulator.CalcDistance3D(5, 2, -1, 3, -6, 4));

            SpaceFigure spaceFigure = new SpaceFigure(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", spaceFigure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", spaceFigure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", spaceFigure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", spaceFigure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", spaceFigure.CalcDiagonalYZ());
        }
    }
} 