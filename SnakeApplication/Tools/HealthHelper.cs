using SnakeApplication.Figure.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication.Tools
{
    public static class HealthHelper
    {
        public static int Health {  get; set; }

        static HealthHelper()
        {
            Health = 3;
        }

        public static void ShowHealth(Window win)
        {
            Console.SetCursorPosition(win.WIDTH - 10, win.HEIGHT + 3);
            Console.ForegroundColor = ConsoleColor.Red;

            for (int i = 0; i < Health; i++)
            {
                Console.Write("X ");
            }
            Console.ResetColor();
        }
        public static void ReduceHealth()
        {
            HealthHelper.Health--;
            if (HealthHelper.Health <= 0)
                Game.Game_ = false;
        }
    }
}
