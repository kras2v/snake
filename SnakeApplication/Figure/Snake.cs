using SnakeApplication.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnakeApplication.Figure.Window;

namespace SnakeApplication.Figure
{
    public class Snake : Shape
    {
        DirectionEnum _direction;
        public Snake()
        {
            _points = new List<Point>();
            _tail = new List<Point>();
        }

        public void CreateSnake(int length, Point tail, DirectionEnum direction)
        {
            _direction = direction;

            for (int i = 0; i < length; i++)
            {
                Point point = new Point(tail);
                point.SetDirection(i, direction);
                _points.Add(point);
            }
            //CreateHorizontalTail(_points[0]);
        }
        public void Move()
        {
            Point head = new Point(_points.Last());
            head.SetDirection(1, _direction);

            Point? tail = _points.FirstOrDefault();

            if (tail != null)
            {
                _points.Remove(tail);

                //DeleteTail();
                //CreateHorizontalTail(tail);
                //MoveTail(tail);

                tail.ClearPoint();
            }

            _points[_points.Count - 1].Symbol = 'x';
            _points.Add(head);
        }

        public void MoveFrom(Point body, int length)
        {
            _points.Clear();
            _direction = DirectionEnum.RIGHT;
            for (int i = 0; i < length; i++)
            {
                Point point = new Point(body);
                point.SetDirection(i, _direction);
                _points.Add(point);
            }
            //DeleteTail();
            //CreateHorizontalTail(_points[0]);
        }

        public void Control(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    _direction = DirectionEnum.UP;
                    break;

                case ConsoleKey.RightArrow:
                    _direction = DirectionEnum.RIGHT;
                    break;

                case ConsoleKey.DownArrow:
                    _direction = DirectionEnum.DOWN;
                    break;

                case ConsoleKey.LeftArrow:
                    _direction = DirectionEnum.LEFT;
                    break;

                default:
                    break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = new Point(_points.Last());
            head.SetDirection(1, _direction);

            if (head.Equals(food))
            {
                food.Symbol = head.Symbol;
                _points.Add(food);
                return true;
            }
            if (_tail.Any(t => t.Equals(food)))
            {
                Console.ForegroundColor = ColorPicker.Color;
                _tail.Find(x => x.Equals(food)).Symbol = '*';
            }

            return false;
        }

        //public void CreateHorizontalTail(Point last)
        //{
        //    Point point = new Point(last);
        //    point.Y = point.Y + 1;
        //    _tail.Add(point);

        //    Point point2 = new Point(last);
        //    point2.Y = point2.Y - 1;
        //    _tail.Add(point2);
        //}

        //public void CreateVerticalTail(Point last)
        //{
        //    Point point = new Point(last);
        //    point.X = point.X + 1;
        //    _tail.Add(point);

        //    Point point2 = new Point(last);
        //    point2.X = point2.X - 1;
        //    _tail.Add(point2);
        //}

        //public void DeleteTail()
        //{
        //    foreach (Point point in _tail) point.ClearPoint();
        //    _tail.Clear();
        //}

        //public void MoveTail(Point last)
        //{
        //    if (_direction == DirectionEnum.UP || _direction == DirectionEnum.DOWN)
        //    {
        //        if (_points.Last().X == _points.First().X)
        //        {
        //            DeleteTail();
        //            CreateVerticalTail(last);
        //        }
        //    }
        //    _tail[0].SetDirection(1, _direction);
        //    _tail[1].SetDirection(1, _direction);
        //}

        public bool IsTailAte()
        {
            var head = _points.Last();

            for (int i = 0; i < _points.Count - 1; i++)
            {
                if (head.Equals(_points[i]))
                {
                    HealthHelper.ReduceHealth();
                    Game.Start();
                    return true;
                }
            }
            return false;
        }
    }
}