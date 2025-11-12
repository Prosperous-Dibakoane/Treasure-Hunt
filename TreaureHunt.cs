using System;
using System.Threading;

namespace TreasureHunt
{
    class Program
    {
        // Game constants
        static int width = 20;
        static int height = 10;
        static char[,] map = new char[height, width];
        static int playerX = 0;
        static int playerY = 0;
        static int treasures = 5;
        static int collected = 0;
        static bool gameOver = false;
        static Random rand = new Random();

        static void Main()
        {
            Console.CursorVisible = false;
            InitializeMap();

            while (!gameOver)
            {
                DrawMap();
                HandleInput();
                CheckCollision();
                Thread.Sleep(100); // Slow down the loop slightly
            }

            Console.Clear();
            if (collected == treasures)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("🎉 You collected all treasures! You win!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("💀 You hit a trap! Game Over!");
            }

            Console.ResetColor();
        }

        static void InitializeMap()
        {
            // Fill map with dots (empty space)
            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    map[y, x] = '.';

            // Place player
            playerX = rand.Next(width);
            playerY = rand.Next(height);

            // Place treasures
            for (int i = 0; i < treasures; i++)
            {
                int tx, ty;
                do
                {
                    tx = rand.Next(width);
                    ty = rand.Next(height);
                } while (map[ty, tx] != '.');
                map[ty, tx] = '$';
            }

            // Place traps
            for (int i = 0; i < treasures; i++)
            {
                int tx, ty;
                do
                {
                    tx = rand.Next(width);
                    ty = rand.Next(height);
                } while (map[ty, tx] != '.');
                map[ty, tx] = 'X';
            }
        }

        static void DrawMap()
        {
            Console.SetCursorPosition(0, 0);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write('@');
                        Console.ResetColor();
                    }
                    else
                    {
                        char c = map[y, x];
                        if (c == '$')
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(c);
                            Console.ResetColor();
                        }
                        else if (c == 'X')
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(c);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write(c);
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\n💰 Treasures Collected: {collected}/{treasures}");
        }

        static void HandleInput()
        {
            if (!Console.KeyAvailable) return;
            ConsoleKey key = Console.ReadKey(true).Key;

            int newX = playerX;
            int newY = playerY;

            switch (key)
            {
                case ConsoleKey.LeftArrow: newX--; break;
                case ConsoleKey.RightArrow: newX++; break;
                case ConsoleKey.UpArrow: newY--; break;
                case ConsoleKey.DownArrow: newY++; break;
            }

            // Keep player within boundaries
            if (newX >= 0 && newX < width && newY >= 0 && newY < height)
            {
                playerX = newX;
                playerY = newY;
            }
        }

        static void CheckCollision()
        {
            char current = map[playerY, playerX];

            if (current == '$')
            {
                collected++;
                map[playerY, playerX] = '.';
                if (collected == treasures)
                    gameOver = true;
            }
            else if (current == 'X')
            {
                gameOver = true;
            }
        }
    }
}
