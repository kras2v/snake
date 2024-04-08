using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeApplication.Figure.Window.Lines
{
    public class HorizontalLine : Shape
    {
        public HorizontalLine(int x, int y, char symbol, int length)
        {
            _points = new List<Point>();
            for (int i = x; i < length; i++)
            {
                Point point = new Point(i, y, symbol);
                _points.Add(point);
            }
        }
    }
}
