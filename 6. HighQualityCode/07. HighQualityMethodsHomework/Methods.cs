namespace Methods
{
    using System;

    public class Methods
    {
        private static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            double halfPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
            return area;
        }

        private static string NumberToDigit(int number)
        {
            string digit;

            switch (number)
            {
                case 0:
                    digit = "zero";
                    break;
                case 1:
                    digit = "one";
                    break;
                case 2:
                    digit = "two";
                    break;
                case 3:
                    digit = "three";
                    break;
                case 4:
                    digit = "four";
                    break;
                case 5:
                    digit = "five";
                    break;
                case 6:
                    digit = "six";
                    break;
                case 7:
                    digit = "seven";
                    break;
                case 8:
                    digit = "eight";
                    break;
                case 9:
                    digit = "nine";
                    break;
                default:
                    throw new ArgumentException("Invalid number!");
            }

            return digit;
        }

        private static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array is empty!");
            }

            int max = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        private static void PrintAsNumber(object number, string format)
        {
            switch (format)
            {
                case "f":
                    Console.WriteLine("{0:f2}", number);
                    break;
                case "%":
                    Console.WriteLine("{0:p0}", number);
                    break;
                case "r":
                    Console.WriteLine("{0,8}", number);
                    break;
                default:
                    throw new ArgumentException("Invalid format!");
            }
        }

        private static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        private static bool CheckVertical(double x1, double x2)
        {
            bool isVertical = Math.Abs(x1 - x2) < 0.01;
            return isVertical;
        }

        private static bool CheckHorisontal(double y1, double y2)
        {
            bool isHorizontal = Math.Abs(y1 - y2) < 0.01;
            return isHorizontal;
        }

        private static void Main()
        {
            const double TriangleSideA = 3;
            const double TriangleSideB = 4;
            const double TriangleSideC = 5;

            Console.WriteLine(CalculateTriangleArea(TriangleSideA, TriangleSideB, TriangleSideC));

            Console.WriteLine(NumberToDigit(5));

            int[] numbers = { 5, -1, 3, 2, 14, 2, 3 };
            Console.WriteLine(FindMax(numbers));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            const double X1 = 3;
            const double Y1 = -1;
            const double X2 = 3;
            const double Y2 = 2.5;

            Console.WriteLine(CalculateDistance(X1, Y1, X2, Y2));

            bool horizontal = CheckHorisontal(Y1, Y2);
            bool vertical = CheckVertical(X1, X2);
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            DateTime petersBirthDate = new DateTime(1992, 3, 17);
            Student peter = new Student("Peter", "Ivanov", "Sofia", petersBirthDate);

            DateTime stellasBirthDate = new DateTime(1993, 11, 3);
            Student stella = new Student("Stella", "Markova", "Vidin", stellasBirthDate, "gamer, high results");

            Console.WriteLine(
                "{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
