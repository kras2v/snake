using SnakeApplication.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication
{
    public static class Menu
    {
        public static void Draw() 
        {
            DrawBtn();
            while (Start());
        }

        private static bool Start()
        {
            if(Console.KeyAvailable) 
            {
                var key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        return false;
                    //case ConsoleKey.Escape:
                    //    return true;
                    default:
                        ColorPicker.Pick(new Random().Next(1,5));
                        Draw();
                        break;
                }
            }
            return true;
        }

        private static void StartGame()
        {

        }

        private static void DrawBtn()
        {
            string ent = "Press | Enter | to start";

            int start = Console.WindowWidth / 2 - ent.Length / 2;
            int startHeight = Console.WindowHeight / 2 - 3;
            Console.SetCursorPosition(start, startHeight);

            Console.WriteLine(ent);
            var index = ent.IndexOf('|');
            Console.SetCursorPosition(start + index, startHeight - 1);
            Console.WriteLine(new string('_', 9));

            Console.SetCursorPosition(start + index, startHeight + 1);
            Console.Write(new string('-', 5));

            Console.SetCursorPosition(start + index + 4, startHeight + 2);
            Console.Write(new string('|', 1));

            Console.SetCursorPosition(start + index + 4, startHeight + 3);
            Console.Write(new string('|', 1));
            Console.Write(new string('_', 3));
            Console.Write(new string('|', 1));

            Console.SetCursorPosition(start + index + 8, startHeight + 2);
            Console.Write(new string('|', 1));

            Console.SetCursorPosition(start + index + 8, startHeight + 1);
            Console.Write(new string('|', 1));

            Console.SetCursorPosition(start + index + 8, startHeight);
            Console.Write(new string('|', 1));

            Console.SetCursorPosition(0, 20);
        }
    }
}
