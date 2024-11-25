using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Семестрове_завдання
{
    public partial class fMain : Form
    {
        List<object> shapes;  // Список для хранения всех объектов
        int ShapeCount = 0;    // Количество объектов, добавленных в список

        private CCircle newCircle;
        private CSquare newSquare;
        private CTriangle newTriangle;

        public fMain()
        {
            InitializeComponent();
            shapes = new List<object>();  // Инициализация списка

            cbShapes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbShapes.FormattingEnabled = true;
            cbShapes.Items.Add("Circle");
            cbShapes.Items.Add("Square");
            cbShapes.Items.Add("Triangle");

            cbObjects.DropDownStyle = ComboBoxStyle.DropDownList;
            cbObjects.FormattingEnabled = true;
        }

        // Метод для создания нового объекта
        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnMain.CreateGraphics();

            if (cbShapes.SelectedItem != null)
            {
                string selectedShape = cbShapes.SelectedItem.ToString();

                if (selectedShape == "Circle")
                {
                    newCircle = new CCircle(graphics, 100, 100);
                    newCircle.Show();
                    shapes.Add(newCircle);  // Добавляем круг в список
                    cbObjects.Items.Add("Круг №" + ShapeCount);  // Добавляем в комбобокс
                }
                else if (selectedShape == "Square")
                {
                    newSquare = new CSquare(graphics, 100, 100);
                    newSquare.Show();
                    shapes.Add(newSquare);  // Добавляем квадрат в список
                    cbObjects.Items.Add("Квадрат №" + ShapeCount);  // Добавляем в комбобокс
                }
                else if (selectedShape == "Triangle")
                {
                    newTriangle = new CTriangle(graphics, 100, 100);
                    newTriangle.Show();
                    shapes.Add(newTriangle);  // Добавляем треугольник в список
                    cbObjects.Items.Add("Треугольник №" + ShapeCount);  // Добавляем в комбобокс
                }

                ShapeCount++;  // Увеличиваем счетчик
                cbObjects.SelectedIndex = ShapeCount - 1;  // Устанавливаем выбранный индекс
            }
        }

        // Метод для скрытия выбранного объекта
        private void btnHide_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedItem != null)
            {
                int selectedIndex = cbObjects.SelectedIndex;

                if (shapes[selectedIndex] is CCircle)
                {
                    ((CCircle)shapes[selectedIndex]).Hide();
                }
                else if (shapes[selectedIndex] is CSquare)
                {
                    ((CSquare)shapes[selectedIndex]).Hide();
                }
                else if (shapes[selectedIndex] is CTriangle)
                {
                    ((CTriangle)shapes[selectedIndex]).Hide();
                }
            }
        }

        // Метод для отображения выбранного объекта
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedItem != null)
            {
                int selectedIndex = cbObjects.SelectedIndex;

                if (shapes[selectedIndex] is CCircle)
                {
                    ((CCircle)shapes[selectedIndex]).Show();
                }
                else if (shapes[selectedIndex] is CSquare)
                {
                    ((CSquare)shapes[selectedIndex]).Show();
                }
                else if (shapes[selectedIndex] is CTriangle)
                {
                    ((CTriangle)shapes[selectedIndex]).Show();
                }
            }
        }

        // Метод для расширения выбранного объекта
        private void button3_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedItem == null) return;

            int selectedIndex = cbObjects.SelectedIndex;

            if (shapes[selectedIndex] is CCircle)
            {
                ((CCircle)shapes[selectedIndex]).Expand();
            }
            else if (shapes[selectedIndex] is CSquare)
            {
                ((CSquare)shapes[selectedIndex]).Expand();
            }
            else if (shapes[selectedIndex] is CTriangle)
            {
                ((CTriangle)shapes[selectedIndex]).Expand();
            }
        }

        // Метод для сжатия выбранного объекта
        private void button4_Click(object sender, EventArgs e)
        {
            if (cbObjects.SelectedItem == null) return;

            int selectedIndex = cbObjects.SelectedIndex;

            if (shapes[selectedIndex] is CCircle)
            {
                ((CCircle)shapes[selectedIndex]).Collapse();
            }
            else if (shapes[selectedIndex] is CSquare)
            {
                ((CSquare)shapes[selectedIndex]).Collapse();
            }
            else if (shapes[selectedIndex] is CTriangle)
            {
                ((CTriangle)shapes[selectedIndex]).Collapse();
            }
        }

        // Метод для перемещения объекта
        private void MoveSelectedShape(int dx, int dy)
        {
            if (cbObjects.SelectedItem == null) return;

            int selectedIndex = cbObjects.SelectedIndex;

            if (shapes[selectedIndex] is CCircle)
            {
                ((CCircle)shapes[selectedIndex]).Move(dx, dy);
            }
            else if (shapes[selectedIndex] is CSquare)
            {
                ((CSquare)shapes[selectedIndex]).Move(dx, dy);
            }
            else if (shapes[selectedIndex] is CTriangle)
            {
                ((CTriangle)shapes[selectedIndex]).Move(dx, dy);
            }
        }

        // Двигаем объект вверх
        private void button2_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(0, -10); // Двигаем вверх
        }

        // Двигаем объект вниз
        private void button5_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(0, 10); // Двигаем вниз
        }

        // Двигаем объект вправо
        private void button9_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(10, 0); // Двигаем вправо
        }

        // Двигаем объект влево
        private void button8_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(-10, 0); // Двигаем влево
        }

        // Плавное движение объекта вправо
        private void button10_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(1, 0); // Плавное движение вправо
        }

        // Плавное движение объекта влево
        private void button7_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(-1, 0); // Плавное движение влево
        }

        // Плавное движение объекта вверх
        private void button1_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(0, -1); // Плавное движение вверх
        }

        // Плавное движение объекта вниз
        private void button6_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(0, 1); // Плавное движение вниз
        }

        // Плавное перемещение объекта
        private void MoveShapeSmoothly(int dx, int dy)
        {
            if (cbObjects.SelectedItem == null) return;

            int selectedIndex = cbObjects.SelectedIndex;

            for (int i = 0; i < 100; i++)
            {
                if (shapes[selectedIndex] is CCircle)
                {
                    ((CCircle)shapes[selectedIndex]).Move(dx, dy);
                }
                else if (shapes[selectedIndex] is CSquare)
                {
                    ((CSquare)shapes[selectedIndex]).Move(dx, dy);
                }
                else if (shapes[selectedIndex] is CTriangle)
                {
                    ((CTriangle)shapes[selectedIndex]).Move(dx, dy);
                }

                System.Threading.Thread.Sleep(5);  // Пауза для плавного движения
            }
        }
    }
}
