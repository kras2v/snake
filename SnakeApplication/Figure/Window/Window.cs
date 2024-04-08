using SnakeApplication.Figure.Window.Lines;
using SnakeApplication.Tools;

namespace SnakeApplication.Figure.Window
{
    public class Window
    {
        private List<Shape> _walls;
    
        public VerticalLine DOWN { get; }
        public VerticalLine UP { get; }
        public HorizontalLine LEFT { get; }
        public HorizontalLine RIGHT { get; }

        public int WIDTH { get; }
        public int HEIGHT { get; }

        public Window(int width, int height)
        {
            _walls = new List<Shape>();
            
             UP = new VerticalLine(0, 1, '|', height);
             DOWN = new VerticalLine(width - 1, 1, '|', height);

             LEFT = new HorizontalLine(0, 0, '=', width);
             RIGHT = new HorizontalLine(0, height, '=', width);

             WIDTH = width;
             HEIGHT = height;

            _walls.AddRange(new List<Shape>(){ UP, DOWN, LEFT, RIGHT});    
        }

        public void DrawWindow()
        {
            HealthHelper.ShowHealth(this);
            foreach (Shape shape in _walls) { shape.Draw(); }
        }

        public bool IsCollision(Shape shape)
        {
            foreach (var item in _walls)
                if (item.IsCollision(shape)) 
                {
                    HealthHelper.ReduceHealth();
                    Game.Start();
                    return true; 
                }
            
            return false;
        }
    }
}
