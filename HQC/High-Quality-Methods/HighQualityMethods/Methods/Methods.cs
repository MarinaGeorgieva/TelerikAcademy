namespace Methods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            bool positiveSides = a > 0 && b > 0 && c > 0;
            bool sumOfTwoSidesBiggerThanThirdSide = a + b > c && a + c > b && b + c > a;

            if (!positiveSides)
            {
                throw new ArgumentException("Sides of the triangle must be positive");
            }

            if (!sumOfTwoSidesBiggerThanThirdSide)
            {
                throw new ArgumentException("Side cannot be bigger than the sum of the other two sides");
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        public static string NumberToDigitName(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException(number + " is not a valid digit");
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
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

        public static void PrintAsNumber(object number, string format)
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
                    throw new ArgumentException(format + " is invalid format");
            }
        }

        public static double CalculateDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double distance = Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) + 
                (secondPointY - firstPointY) * (secondPointY - firstPointY));
            return distance;
        }

        public static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            bool isHorizontal = firstPointY == secondPointY;
            return isHorizontal;
        }

        public static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            bool isVertical = firstPointX == secondPointX;
            return isVertical;
        }       
    }
}
