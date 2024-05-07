using System;
using System.Collections.Generic;
using System.Threading;

namespace ConnectFour
{
    class Program
    {
        static Dictionary<string, string[]> rows = new Dictionary<string, string[]>
        {
            { "row0", new string[] { ".", ".", ".", ".", ".", ".", "." } },
            { "row1", new string[] { ".", ".", ".", ".", ".", ".", "." } },
            { "row2", new string[] { ".", ".", ".", ".", ".", ".", "." } },
            { "row3", new string[] { ".", ".", ".", ".", ".", ".", "." } },
            { "row4", new string[] { ".", ".", ".", ".", ".", ".", "." } },
            { "row5", new string[] { ".", ".", ".", ".", ".", ".", "." } }
        };

        static string char1, char2;
        static int game_mode;

        static void Main(string[] args)
        {
            GetPlayerInput();
            PlayGame();
        }

        static void GetPlayerInput()
        {
            Console.Write("Select player1 sign (enter for default): ");
            char1 = string.IsNullOrEmpty(Console.ReadLine()) ? "X" : Console.ReadLine();

            Console.Write("Select player2 sign (enter for default): ");
            char2 = string.IsNullOrEmpty(Console.ReadLine()) ? "O" : Console.ReadLine();

            Console.WriteLine("Select game mode:");
            Console.WriteLine("1 to connect four (p v p),");
            Console.WriteLine("2 to connect four (p v cpu),");
            Console.WriteLine("3 to connect four (cpu v cpu),");
            Console.WriteLine("4 to xox advanced (p v p),");
            Console.WriteLine("5 to xox advanced (p v cpu),");
            Console.WriteLine("6 to xox advanced (cpu v cpu): ");
            game_mode = int.Parse(Console.ReadLine());
        }

        static void PlayGame()
        {
            if (game_mode == 1)
            {
                while (true)
                {
                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Console.Write("p1, select column: ");
                    int posc1 = int.Parse(Console.ReadLine());
                    Player1(0, posc1); // Adjusted method call
                    if (CheckWin(char1) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();

                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Console.Write("p2, select column: ");
                    int posc2 = int.Parse(Console.ReadLine());
                    Player2(0, posc2); // Adjusted method call
                    if (CheckWin(char2) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();
                }
            }
            
            else if (game_mode == 2)
            {
                while (true)
                {
                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Console.Write("p1, select column: ");
                    int posc1 = int.Parse(Console.ReadLine());
                    Player1(0, posc1); // Adjusted method call
                    if (CheckWin(char1) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();

                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Thread.Sleep(new Random().Next(1, 4) * 1000);

                    int posc2 = new Random().Next(0, 7);
                    Player2(0, posc2); // Adjusted method call
                    if (CheckWin(char2) == 1)
                    {
                        Console.WriteLine("p2 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();
                }
            }

            else if (game_mode == 3)
            {
                while (true)
                {
                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Thread.Sleep(new Random().Next(1, 4) * 1000);

                    int posc1 = new Random().Next(0, 7);
                    Player1(0, posc1); // Adjusted method call
                    if (CheckWin(char1) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();

                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Thread.Sleep(new Random().Next(1, 4) * 1000);

                    int posc2 = new Random().Next(0, 7);
                    Player2(0, posc2); // Adjusted method call
                    if (CheckWin(char2) == 1)
                    {
                        Console.WriteLine("p2 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();
                }
            }

            else if (game_mode == 4)
            {
                while (true)
                {
                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Console.Write("p1, select row: ");
                    int posr1 = int.Parse(Console.ReadLine());
                    Console.Write("p1, select column: ");
                    int posc1 = int.Parse(Console.ReadLine());
                    Player1(posr1, posc1);
                    if (CheckWin(char1) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }
                        break;
                    }

                    Console.Clear();

                    foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Console.Write("p2, select row: ");
                    int posr2 = int.Parse(Console.ReadLine());
                    Console.Write("p2, select column: ");
                    int posc2 = int.Parse(Console.ReadLine());
                    Player2(posr2, posc2);
                    if (CheckWin(char2) == 1)
                    {
                        Console.WriteLine("p2 has won!");
                        foreach (var row in rows)
                        {
                            Console.WriteLine(string.Join(" ", row.Value));
                        }
                        break;
                    }

                    Console.Clear();
                }
            }

            else if (game_mode == 5)
            {
                while (true)
                {
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Console.Write("p1, select row: ");
                    int posr1 = int.Parse(Console.ReadLine());
                    Console.Write("p1, select column: ");
                    int posc1 = int.Parse(Console.ReadLine());
                    Player1(posr1, posc1);
                    if (CheckWin(char1) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }
                        break;
                    }

                    Console.Clear();

                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Thread.Sleep(new Random().Next(3, 19) * 1000);

                    int posr2 = new Random().Next(0, 6);
                    int posc2 = new Random().Next(0, 7);
                    Player2(posr2, posc2);
                    if (CheckWin(char2) == 1)
                    {
                        Console.WriteLine("p2 has won!");
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }
                        break;
                    }

                    Console.Clear();
                }
            }

            else if (game_mode == 6)
            {
                while (true)
                {
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Thread.Sleep(new Random().Next(1, 4) * 1000);

                    int posr1 = new Random().Next(0, 6);
                    int posc1 = new Random().Next(0, 7);
                    Player1(posr1, posc1);
                    if (CheckWin(char1) == 1)
                    {
                        Console.WriteLine("p1 has won!");
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }
                        break;
                    }

                    Console.Clear();

                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }

                    Thread.Sleep(new Random().Next(1, 4) * 1000);

                    int posr2 = new Random().Next(0, 6);
                    int posc2 = new Random().Next(0, 7);
                    Player2(posr2, posc2);
                    if (CheckWin(char2) == 1)
                    {
                        Console.WriteLine("p2 has won!");
                        foreach (var row in rows)
                    {
                        Console.WriteLine(string.Join(" ", row.Value));
                    }
                        break;
                    }

                    Console.Clear();
                }
            }

            else if (game_mode >= 4)
            {
                Player1(0, 0); 
                Player2(0, 0); 
            }
            else
            {
                Player1(0, 0); 
                Player2(0, 0); 
            }
        }

        static void Player1(int r1, int c1)
        {
            if (game_mode >= 4)
            {
                if (rows[$"row{r1}"][c1] == ".")
                {
                    rows[$"row{r1}"][c1] = char1;
                }
            }
            else
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (rows[$"row{i}"][c1] == ".")
                    {
                        rows[$"row{i}"][c1] = char1;
                        break;
                    }
                }
            }
        }

        static void Player2(int r2, int c2)
        {
            if (game_mode >= 4)
            {
                if (rows[$"row{r2}"][c2] == ".")
                {
                    rows[$"row{r2}"][c2] = char2;
                }
            }
            else
            {
                for (int i = 5; i >= 0; i--)
                {
                    if (rows[$"row{i}"][c2] == ".")
                    {
                        rows[$"row{i}"][c2] = char2;
                        break;
                    }
                }
            }
        }

        static int CheckWin(string char_)
        {
            int c0 = CheckHorizontal(char_);
            int c1 = CheckVertical(char_);
            int c2 = CheckCrossToRight(char_);
            int c3 = CheckCrossToLeft(char_);

            if (c0 == 1 || c1 == 1 || c2 == 1 || c3 == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int CheckHorizontal(string char_)
        {
            foreach (var row in rows.Values)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (string.Concat(row[i], row[i + 1], row[i + 2], row[i + 3]) == char_ + char_ + char_ + char_)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        static int CheckVertical(string char_)
        {
            Dictionary<string, List<string>> columns = new Dictionary<string, List<string>>
            {
                { "column0", new List<string> { rows["row0"][0], rows["row1"][0], rows["row2"][0], rows["row3"][0], rows["row4"][0], rows["row5"][0] } },
                { "column1", new List<string> { rows["row0"][1], rows["row1"][1], rows["row2"][1], rows["row3"][1], rows["row4"][1], rows["row5"][1] } },
                { "column2", new List<string> { rows["row0"][2], rows["row1"][2], rows["row2"][2], rows["row3"][2], rows["row4"][2], rows["row5"][2] } },
                { "column3", new List<string> { rows["row0"][3], rows["row1"][3], rows["row2"][3], rows["row3"][3], rows["row4"][3], rows["row5"][3] } },
                { "column4", new List<string> { rows["row0"][4], rows["row1"][4], rows["row2"][4], rows["row3"][4], rows["row4"][4], rows["row5"][4] } },
                { "column5", new List<string> { rows["row0"][5], rows["row1"][5], rows["row2"][5], rows["row3"][5], rows["row4"][5], rows["row5"][5] } },
                { "column6", new List<string> { rows["row0"][6], rows["row1"][6], rows["row2"][6], rows["row3"][6], rows["row4"][6], rows["row5"][6] } }
            };

            foreach (var column in columns.Values)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (string.Concat(column[i], column[i + 1], column[i + 2], column[i + 3]) == char_ + char_ + char_ + char_)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        static int CheckCrossToRight(string char_)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (string.Concat(rows[$"row{r}"][c], rows[$"row{r + 1}"][c + 1], rows[$"row{r + 2}"][c + 2], rows[$"row{r + 3}"][c + 3]) == char_ + char_ + char_ + char_)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }

        static int CheckCrossToLeft(string char_)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (string.Concat(rows[$"row{r}"][c + 3], rows[$"row{r + 1}"][c + 2], rows[$"row{r + 2}"][c + 1], rows[$"row{r + 3}"][c]) == char_ + char_ + char_ + char_)
                    {
                        return 1;
                    }
                }
            }
            return 0;
        }
    }    
}
