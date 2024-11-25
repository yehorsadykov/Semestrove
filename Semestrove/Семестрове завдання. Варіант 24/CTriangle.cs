using System.Drawing;

namespace Семестрове_завдання
{
    public class CTriangle
    {
        private Graphics graphics;
        public int X { get; set; }
        public int Y { get; set; }
        public int SideLength { get; set; }

        public CTriangle(Graphics graphics, int X, int Y, int sideLength = 50)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.SideLength = sideLength;
        }

        public void Draw(Pen pen)
        {
            Point[] points = new Point[3];
            points[0] = new Point(X, Y - SideLength / 2);
            points[1] = new Point(X - SideLength / 2, Y + SideLength / 2);
            points[2] = new Point(X + SideLength / 2, Y + SideLength / 2);
            graphics.DrawPolygon(pen, points);
        }

        public void Show()
        {
            Draw(Pens.Red);  // Используем красный цвет для треугольника
        }

        public void Hide()
        {
            Draw(Pens.White);  // Используем белый цвет для скрытия
        }

        public void Move(int dx, int dy)
        {
            Hide();
            X += dx;
            Y += dy;
            Show();
        }

        public void Expand()
        {
            Hide();
            SideLength++;
            Show();
        }

        public void Collapse()
        {
            Hide();
            SideLength--;
            Show();
        }
    }
}