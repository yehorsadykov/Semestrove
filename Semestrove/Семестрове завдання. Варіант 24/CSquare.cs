using System.Drawing;

public class CSquare
{
    private Graphics graphics;
    public int X { get; set; }
    public int Y { get; set; }
    public int SideLength { get; set; }

    public CSquare(Graphics graphics, int X, int Y, int sideLength = 50)
    {
        this.graphics = graphics;
        this.X = X;
        this.Y = Y;
        this.SideLength = sideLength;
    }

    public void Draw(Pen pen)
    {
        Rectangle rectangle = new Rectangle(X - SideLength / 2, Y - SideLength / 2, SideLength, SideLength);
        graphics.DrawRectangle(pen, rectangle);
    }

    public void Show()
    {
        Draw(Pens.Red);  // Используем красный цвет для квадрата
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
