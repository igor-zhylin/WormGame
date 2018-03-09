namespace WormGame
{
    using System;
    using GameObjects;

    class Program
    {
        static void Main(string[] args)
        {
            var snake = new Snake(x: 5, y: 5, size: 7);
            Print(snake);
            var lastDirection = Direction.Up;
            while (true)
            {
                var key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        snake.Direction = Direction.Up;
                        lastDirection = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        snake.Direction = Direction.Down;
                        lastDirection = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        snake.Direction = Direction.Left;
                        lastDirection = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        snake.Direction = Direction.Right;
                        lastDirection = Direction.Right;
                        break;
                }
                snake.Move(1);
                Print(snake);
            }
        }

        private static void Print(Snake snake)
        {
            Console.Clear();
            for (var i = 0; i < snake.Size; i++)
            {
                Console.SetCursorPosition(snake[i].X, snake[i].Y);
                Console.Write(i == 0 ? "*" : "0");
            }
        }
    }
}