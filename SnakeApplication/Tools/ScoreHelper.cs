using SnakeApplication.Figure.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication.Tools
{
    public static class ScoreHelper
    {
        static int score = 0;
        public static int Score
        {
            get { return score; }
            set { score = value; }
        }


        public static void ShowScore(Window win)
        {
            Console.SetCursorPosition(10, win.HEIGHT + 3);
            Console.WriteLine($"Score: {Score}");
        }
    }
}
