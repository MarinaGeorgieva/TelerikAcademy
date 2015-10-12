namespace Methods
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigitName(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Methods.PrintAsNumber(1.3, "f");
            Methods.PrintAsNumber(0.75, "%");
            Methods.PrintAsNumber(2.30, "r");

            bool horizontal = Methods.IsLineHorizontal(-1, 2.5);
            bool vertical = Methods.IsLineVertical(3, 3);

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");

            Console.WriteLine(
                "{0} {1} older than {2} {3} -> {4}",
                peter.FirstName, 
                peter.LastName, 
                stella.FirstName, 
                stella.LastName, 
                peter.IsOlderThan(stella));
        }
    }
}
