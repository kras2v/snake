using SnakeApplication.Figure.Window;
using SnakeApplication.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point = SnakeApplication.Figure.Window.Point;

namespace SnakeApplication.Factory
{
    public class FoodFactory
    {
        Random _random = new Random();
        public Point CreateFood(Window win)
        {
            var maxX = win.WIDTH - 2;
            var minX = 2;

            var maxY = win.HEIGHT - 2;
            var minY = 2;

            ColorPicker.Pick(_random.Next(1,5));

            return new Point(_random.Next(minX,maxX), _random.Next(minY,maxY), '*');
        }
    }
}
