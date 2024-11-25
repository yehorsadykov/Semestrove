using System.Drawing;

namespace Семестрове_завдання
{
    public class CEmblem
    {
        private CCircle circle;
        private CSquare square;
        private CTriangle triangle;

        private Graphics graphics;
        private string currentShape;

        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }

        public CEmblem(Graphics graphics, string shape, int X, int Y, int size = 50)
        {
            this.graphics = graphics;
            this.X = X;
            this.Y = Y;
            this.Size = size;
            currentShape = shape;

            switch (shape)
            {
                case "Circle":
                    circle = new CCircle(graphics, X, Y, size);
                    break;
                case "Square":
                    square = new CSquare(graphics, X, Y, size);
                    break;
                case "Triangle":
                    triangle = new CTriangle(graphics, X, Y, size);
                    break;
            }
        }

        public void Show()
        {
            switch (currentShape)
            {
                case "Circle":
                    circle.Show();
                    break;
                case "Square":
                    square.Show();
                    break;
                case "Triangle":
                    triangle.Show();
                    break;
            }
        }

        public void Hide()
        {
            switch (currentShape)
            {
                case "Circle":
                    circle.Hide();
                    break;
                case "Square":
                    square.Hide();
                    break;
                case "Triangle":
                    triangle.Hide();
                    break;
            }
        }

        public void Expand()
        {
            switch (currentShape)
            {
                case "Circle":
                    circle.Expand();
                    break;
                case "Square":
                    square.Expand();
                    break;
                case "Triangle":
                    triangle.Expand();
                    break;
            }
        }

        public void Collapse()
        {
            switch (currentShape)
            {
                case "Circle":
                    circle.Collapse();
                    break;
                case "Square":
                    square.Collapse();
                    break;
                case "Triangle":
                    triangle.Collapse();
                    break;
            }
        }

        public void Move(int dx, int dy)
        {
            switch (currentShape)
            {
                case "Circle":
                    circle.Move(dx, dy);
                    break;
                case "Square":
                    square.Move(dx, dy);
                    break;
                case "Triangle":
                    triangle.Move(dx, dy);
                    break;
            }
        }
    }
}
