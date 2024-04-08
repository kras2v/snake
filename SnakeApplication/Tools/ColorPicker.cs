using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication.Tools
{
    public static class ColorPicker
    {
        public static ConsoleColor Color { get; set; }
        public static void Pick(int color)
        {
            switch (color)
            {
                case 1:
                    Console.ForegroundColor = Color = ConsoleColor.Green;
                    break;
                case 2:
                    Console.ForegroundColor = Color = ConsoleColor.Red;
                    break;
                case 3:
                    Console.ForegroundColor = Color = ConsoleColor.Yellow;
                    break;
                case 4:
                    Console.ForegroundColor = Color = ConsoleColor.Blue;
                    break;
                case 5:
                    Console.ForegroundColor = Color = ConsoleColor.Magenta;
                    break;
            }
        }
    }
}
