using SnakeApplication.Figure.Window;

namespace SnakeApplication.Figure
{
    public class Shape
    {
        protected List<Point> _points;
        protected List<Point> _tail;

        public Shape()
        {
            _points = new List<Point>();
            _tail = new List<Point>();
        }

        public void Draw()
        {
            foreach (var point in _points)
            {
                point.DrawPoint();
            }

            if (_tail != null)
                foreach (var tail in _tail)
                {
                    tail.DrawPoint();
                }
        }

        public bool IsCollision(Shape shape)
        {
            foreach (var point in _points)
                if (shape.CompareShapePoint(point))
                    return true;

            return false;
        }

        private bool CompareShapePoint(Point point)
        {
            foreach (var item in _points)
                if (point.Equals(item))
                    return true;
            return false;
        }
    }
}
