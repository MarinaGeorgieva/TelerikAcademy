namespace _02_IfStatements
{
    using System;

    public class IfStatements
    {
        public static void Main()
        {
            const int MinX = 1;
            const int MaxX = 27;
            const int MinY = -6;
            const int MaxY = 10;

            //if (x >= MIN_X && (x =< MAX_X && ((MAX_Y >= y && MIN_Y <= y) && !shouldNotVisitCell)))
            //{
            //    VisitCell();
            //}

            int x = 5;
            int y = 7;

            bool isCellVisited = false;

            if (!isCellVisited && IsInRange(x, MinX, MaxX) && IsInRange(y, MinY, MaxY))
            {
                VisitCell();
            }
        }

        private static void VisitCell()
        {
            Console.WriteLine("The cell is visited!");
        }

        private static bool IsInRange(int number, int min, int max)
        {
            bool isInRange = (min <= number && number <= max);

            return isInRange;
        }
    }
}
