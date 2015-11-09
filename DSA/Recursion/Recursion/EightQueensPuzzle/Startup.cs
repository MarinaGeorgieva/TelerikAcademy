namespace EightQueensPuzzle
{
    public class Startup
    {
        public static void Main()
        {
            QueenPuzzleSolver solver = new QueenPuzzleSolver(8);
            solver.PutQueens(0);
        }
    }
}
