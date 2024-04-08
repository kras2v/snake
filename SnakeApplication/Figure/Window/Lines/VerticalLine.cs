using SnakeApplication.Figure.Window;
using SnakeApplication.Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication.Figure.Window.Lines
{
    public class VerticalLine : Shape
    {
        public VerticalLine(int x, int y, char symbol, int length)
        {
            _points = new List<Point>();
            for (int i = y; i < length; i++)
            {
                Point point = new Point(x, i, symbol);
                _points.Add(point);
            }
        }

    }
}
