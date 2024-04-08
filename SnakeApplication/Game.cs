using SnakeApplication.Factory;
using SnakeApplication.Figure;
using SnakeApplication.Figure.Window;
using SnakeApplication.Tools;

namespace SnakeApplication
{
    static class Game
    {
        static bool game = true;
        public static bool Game_ { get { return game; } set { game = value; } }
        static int snakeSize = 3;

        public static void Start()
        {
            Console.Clear();
            #region Window
            Console.ResetColor();
            Console.CursorVisible = false;
            var win = new Window(120, 20);
            win.DrawWindow();
            int screenMiddleHight = win.HEIGHT / 2;
            #endregion

            #region Snake
            Snake snake = new Snake();
            Point startPoint = new Point(1, screenMiddleHight, '0');
            snake.CreateSnake(snakeSize, startPoint, DirectionEnum.RIGHT);
            snake.Draw();
            #endregion

            #region Food
            FoodFactory factory = new FoodFactory();
            Point food = factory.CreateFood(win);
            food.DrawPoint();
            Console.ResetColor();
            #endregion

            #region Score
            ScoreHelper.ShowScore(win);
            #endregion

            while (Game_)
            {
                if (win.IsCollision(snake) || snake.IsTailAte())
                {
                    snake.MoveFrom(startPoint, snakeSize);
                }
                Console.ResetColor();

                if (snake.Eat(food))
                {
                    food = factory.CreateFood(win);
                    food.DrawPoint();
                    Console.ResetColor();

                    snakeSize++;
                    ScoreHelper.Score++;
                    ScoreHelper.ShowScore(win);
                }

                snake.Move();
                snake.Draw();

                if (Console.KeyAvailable)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    var key = Console.ReadKey();
                    snake.Control(key.Key);
                }
                Thread.Sleep(100);
            }
            Console.SetCursorPosition(20, 25);
        }
    }
}
