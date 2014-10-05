namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Minesweeper
    {
        private static void Main()
        {
            const int Max = 35;

            string command;
            char[,] gameBoard = CreateGameBoard();
            char[,] bombs = PlaceBombs();

            List<HighScore> highScores = new List<HighScore>(6);

            int row = 0;
            int column = 0;
            int count = 0;

            bool isNewGame = true;
            bool win = false;
            bool lose = false;

            do
            {
                if (isNewGame)
                {
                    Console.WriteLine(
                        "Lets play Minesweeper. Command 'top' shows the high scores, 'restart' starts new game, 'exit' exits from the game!");
                    RenderBoard(gameBoard);
                    isNewGame = false;
                }

                Console.Write("Type row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    bool isValidRow = 
                        int.TryParse(command[0].ToString(), out row) && row <= gameBoard.GetLength(0);
                    bool isValidColumn = 
                        int.TryParse(command[2].ToString(), out column) && column <= gameBoard.GetLength(1);
                    if (isValidRow && isValidColumn)
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        PrintHighScores(highScores);
                        break;
                    case "restart":
                        gameBoard = CreateGameBoard();
                        bombs = PlaceBombs();
                        RenderBoard(gameBoard);
                        lose = false;
                        isNewGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                NextTurn(gameBoard, bombs, row, column);
                                count++;
                            }

                            if (Max == count)
                            {
                                win = true;
                            }
                            else
                            {
                                RenderBoard(gameBoard);
                            }
                        }
                        else
                        {
                            lose = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nInvalid command!\n");
                        break;
                }

                if (lose)
                {
                    RenderBoard(bombs);
                    Console.Write("\nGame over! You made {0} points. \nUsername: ", count);
                    string userName = Console.ReadLine();
                    HighScore highScore = new HighScore(userName, count);
                    if (highScores.Count < 5)
                    {
                        highScores.Add(highScore);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].Points < highScore.Points)
                            {
                                highScores.Insert(i, highScore);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((HighScore first, HighScore second) => second.Name.CompareTo(first.Name));
                    highScores.Sort((HighScore first, HighScore second) => second.Points.CompareTo(first.Points));
                    PrintHighScores(highScores);

                    gameBoard = CreateGameBoard();
                    bombs = PlaceBombs();
                    count = 0;
                    lose = false;
                    isNewGame = true;
                }

                if (win)
                {
                    Console.WriteLine("\nYou win!");
                    RenderBoard(bombs);
                    Console.WriteLine("Username: ");

                    string userName = Console.ReadLine();
                    HighScore highScore = new HighScore(userName, count);
                    highScores.Add(highScore);
                    PrintHighScores(highScores);

                    gameBoard = CreateGameBoard();
                    bombs = PlaceBombs();
                    count = 0;
                    win = false;
                    isNewGame = true;
                }
            }
            while (command != "exit");
            Console.Read();
        }

        private static void PrintHighScores(List<HighScore> highScores)
        {
            Console.WriteLine("\nPoints:");
            if (highScores.Count > 0)
            {
                for (int i = 0; i < highScores.Count; i++)
                {
                    Console.WriteLine(
                        "{0}. {1} --> {2} cells opened", i + 1, highScores[i].Name, highScores[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty chart!\n");
            }
        }

        private static void NextTurn(char[,] gameBoard, char[,] bombs, int row, int column)
        {
            char mines = MinesCount(bombs, row, column);
            bombs[row, column] = mines;
            gameBoard[row, column] = mines;
        }

        private static void RenderBoard(char[,] board)
        {
            int boardRows = board.GetLength(0);
            int boardColumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < boardRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < boardColumns; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameBoard()
        {
            const int BoardRows = 5;
            const int BoardColumns = 10;
            char[,] board = new char[BoardRows, BoardColumns];
            for (int i = 0; i < BoardRows; i++)
            {
                for (int j = 0; j < BoardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] PlaceBombs()
        {
            const int BoardRows = 5;
            const int BoardColumns = 10;
            char[,] gameBoard = new char[BoardRows, BoardColumns];

            for (int i = 0; i < BoardRows; i++)
            {
                for (int j = 0; j < BoardColumns; j++)
                {
                    gameBoard[i, j] = '-';
                }
            }

            List<int> minesPlaces = new List<int>();
            while (minesPlaces.Count < 15)
            {
                Random random = new Random();
                int asfd = random.Next(50);
                if (!minesPlaces.Contains(asfd))
                {
                    minesPlaces.Add(asfd);
                }
            }

            foreach (int place in minesPlaces)
            {
                int column = place / BoardColumns;
                int row = place % BoardColumns;
                if (row == 0 && place != 0)
                {
                    column--;
                    row = BoardColumns;
                }
                else
                {
                    row++;
                }

                gameBoard[column, row - 1] = '*';
            }

            return gameBoard;
        }

        private static char MinesCount(char[,] gameBoard, int row, int column)
        {
            int mines = 0;
            int rows = gameBoard.GetLength(0);
            int columns = gameBoard.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameBoard[row - 1, column] == '*')
                {
                    mines++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameBoard[row + 1, column] == '*')
                {
                    mines++;
                }
            }

            if (column - 1 >= 0)
            {
                if (gameBoard[row, column - 1] == '*')
                {
                    mines++;
                }
            }

            if (column + 1 < columns)
            {
                if (gameBoard[row, column + 1] == '*')
                {
                    mines++;
                }
            }

            if ((row - 1 >= 0) && (column - 1 >= 0))
            {
                if (gameBoard[row - 1, column - 1] == '*')
                {
                    mines++;
                }
            }

            if ((row - 1 >= 0) && (column + 1 < columns))
            {
                if (gameBoard[row - 1, column + 1] == '*')
                {
                    mines++;
                }
            }

            if ((row + 1 < rows) && (column - 1 >= 0))
            {
                if (gameBoard[row + 1, column - 1] == '*')
                {
                    mines++;
                }
            }

            if ((row + 1 < rows) && (column + 1 < columns))
            {
                if (gameBoard[row + 1, column + 1] == '*')
                {
                    mines++;
                }
            }

            return char.Parse(mines.ToString());
        }
    }
}