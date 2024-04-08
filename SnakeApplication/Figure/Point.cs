using SnakeApplication.Tools;

namespace SnakeApplication.Figure.Window
{
    public class Point
    {
        int _x, _y;
        char _symbol;

        public char Symbol
        {
            get { return _symbol; }
            set { _symbol = value; }
        }
        public int X { get { return _x; } set { _x = value; } }
        public int Y { get { return _y; } set { _y = value; } }

        public Point(int x, int y, char symbol)
        {
            _x = x;
            _y = y;
            _symbol = symbol;
        }

        public Point(Point point)
        {
            _x = point._x;
            _y = point._y;
            _symbol = point._symbol;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_symbol);
        }

        public void SetDirection(int i, DirectionEnum direction)
        {
            switch (direction)
            {
                case DirectionEnum.LEFT:
                    _x = _x - i;
                    break;
                case DirectionEnum.RIGHT:
                    _x = _x + i;
                    break;
                case DirectionEnum.UP:
                    _y = _y - i;
                    break;
                case DirectionEnum.DOWN:
                    _y = _y + i;
                    break;

            }
        }

        public void ClearPoint()
        {
            if (_symbol != '*')
                _symbol = ' ';
            DrawPoint();
        }

        public override bool Equals(object? obj)
        {
            Point? p = obj as Point;
            if (p == null) return false;

            return _x == p._x && _y == p._y;
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
