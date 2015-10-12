namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        public static void Main()
        {
            const int MaxCellsWithoutMines = 35;
            string command = string.Empty;
            char[,] playfield = CreatePlayfiled();
            char[,] mines = PlaceMines();
            int row = 0;
            int col = 0;
            int pointsCount = 0;            
            bool gameStarted = true;
            bool gameWon = false;
            bool gameOver = false;
            List<Player> players = new List<Player>(6);  

            do
            {
                if (gameStarted)
                {
                    Console.WriteLine("Let's play \"Minesweeper\". Try find the mine-free cells." +
                        " Command 'top' shows highscores, 'restart' starts a new game, 'exit' quits the game!");
                    ShowPlayfield(playfield);
                    gameStarted = false;
                }

                Console.Write("Enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= playfield.GetLength(0) && col <= playfield.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        ShowHighscores(players);
                        break;
                    case "restart":
                        playfield = CreatePlayfiled();
                        mines = PlaceMines();
                        ShowPlayfield(playfield);
                        gameOver = false;
                        gameStarted = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye!");
                        break;
                    case "turn":
                        if (mines[row, col] != '*')
                        {
                            if (mines[row, col] == '-')
                            {
                                MakeMove(playfield, mines, row, col);
                                pointsCount++;
                            }

                            if (MaxCellsWithoutMines == pointsCount)
                            {
                                gameWon = true;
                            }
                            else
                            {
                                ShowPlayfield(playfield);
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (gameOver)
                {
                    ShowPlayfield(mines);
                    Console.Write("\nGame Over! You died with {0} points. Enter your nickname: ", pointsCount);
                    string nickname = Console.ReadLine();
                    Player player = new Player(nickname, pointsCount);
                    if (players.Count < 5)
                    {
                        players.Add(player);
                    }
                    else
                    {
                        for (int i = 0; i < players.Count; i++)
                        {
                            if (players[i].Points < player.Points)
                            {
                                players.Insert(i, player);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    players.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    ShowHighscores(players);

                    playfield = CreatePlayfiled();
                    mines = PlaceMines();
                    pointsCount = 0;
                    gameOver = false;
                    gameStarted = true;
                }

                if (gameWon)
                {
                    Console.WriteLine("\nCongratulations! You opened all 35 mine-free cells.");
                    ShowPlayfield(mines);
                    Console.WriteLine("Enter your nickname: ");
                    string nickname = Console.ReadLine();
                    Player player = new Player(nickname, pointsCount);
                    players.Add(player);
                    ShowHighscores(players);
                    playfield = CreatePlayfiled();
                    mines = PlaceMines();
                    pointsCount = 0;
                    gameWon = false;
                    gameStarted = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Thank you for playing \"Minesweeper\"");
            Console.Read();
        }

        private static void ShowHighscores(List<Player> players)
        {
            Console.WriteLine("\nHighscores:");
            if (players.Count > 0)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, players[i].Name, players[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No highscores yet!\n");
            }
        }

        private static void MakeMove(char[,] playfield, char[,] mines, int row, int col)
        {
            char minesCount = CountMines(mines, row, col);
            mines[row, col] = minesCount;
            playfield[row, col] = minesCount;
        }

        private static void ShowPlayfield(char[,] playfield)
        {
            int rows = playfield.GetLength(0);
            int cols = playfield.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", playfield[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayfiled()
        {
            int rows = 5;
            int cols = 10;
            char[,] playfield = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    playfield[row, col] = '?';
                }
            }

            return playfield;
        }

        private static char[,] PlaceMines()
        {
            int rows = 5;
            int cols = 10;
            char[,] playfield = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    playfield[row, col] = '-';
                }
            }

            List<int> mines = new List<int>();
            while (mines.Count < 15)
            {
                Random random = new Random();
                int number = random.Next(50);
                if (!mines.Contains(number))
                {
                    mines.Add(number);
                }
            }

            foreach (int mine in mines)
            {
                int row = mine / cols;
                int col = mine % cols;
                if (col == 0 && mine != 0)
                {
                    row--;
                    col = cols;
                }
                else
                {
                    col++;
                }

                playfield[row, col - 1] = '*';
            }

            return playfield;
        }

        private static void CalculateMinesInField(char[,] playfield)
        {
            int rows = playfield.GetLength(0);
            int cols = playfield.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (playfield[row, col] != '*')
                    {
                        char minesCount = CountMines(playfield, row, col);
                        playfield[row, col] = minesCount;
                    }
                }
            }
        }

        private static char CountMines(char[,] playfield, int row, int col)
        {
            int count = 0;
            int rows = playfield.GetLength(0);
            int cols = playfield.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playfield[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (playfield[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playfield[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (playfield[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playfield[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playfield[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playfield[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playfield[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}