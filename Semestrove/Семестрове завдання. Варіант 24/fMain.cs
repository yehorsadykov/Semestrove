using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Семестрове_завдання
{
    public partial class fMain : Form
    {
        CCircle[] circles;
        
        int CircleCount = 0;
        int CurrentCircleIndex;

        private CCircle newCircle; // Глобальная переменная для круга
        private CSquare newSquare; // Глобальная переменная для квадрат
        private CTriangle newTriangle; 

        public fMain()
        {
            InitializeComponent();
            circles = new CCircle[100];

            cbCircles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbCircles.FormattingEnabled = true;
            cbCircles.Items.Add("Circle");  // Добавляем круг
            cbCircles.Items.Add("Square");  // Добавляем квадрат
            cbCircles.Items.Add("Triangle");
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            Graphics graphics = pnMain.CreateGraphics();

            if (cbCircles.SelectedItem != null)
            {
                string selectedShape = cbCircles.SelectedItem.ToString();

                if (selectedShape == "Circle")
                {
                    // Создаем новый круг и сохраняем в глобальной переменной
                    newCircle = new CCircle(graphics, 100, 100);
                    newCircle.Show();
                }
                else if (selectedShape == "Square")
                {
                    // Создаем новый квадрат и сохраняем в глобальной переменной
                    newSquare = new CSquare(graphics, 100, 100);
                    newSquare.Show();
                }
                else if (selectedShape == "Triangle")
                {
                    // Создаем новый треугольник и сохраняем в глобальной переменной
                    newTriangle = new CTriangle(graphics, 100, 100);
                    newTriangle.Show();
                }
            }
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (cbCircles.SelectedItem != null)
            {
                if (cbCircles.SelectedItem.ToString() == "Circle")
                {
                    // Создаем новый круг              
                    newCircle.Hide();
                }
                else if (cbCircles.SelectedItem.ToString() == "Square")
                {
                    // Создаем новый квадрат
                    newSquare.Hide();
                }
                else if (cbCircles.SelectedItem.ToString() == "Triangle")
                {
                    // Создаем новый треугольник
                    newTriangle.Hide();
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbCircles.SelectedItem != null)
            {
                if (cbCircles.SelectedItem.ToString() == "Circle")
                {
                    // Создаем новый круг              
                    newCircle.Show();
                }
                else if (cbCircles.SelectedItem.ToString() == "Square")
                {
                    // Создаем новый квадрат
                    newSquare.Show();
                }
                else if (cbCircles.SelectedItem.ToString() == "Triangle")
                {
                    // Создаем новый треугольник
                    newTriangle.Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbCircles.SelectedItem == null) return;

            string selectedShape = cbCircles.SelectedItem.ToString();

            if (selectedShape == "Circle" && newCircle != null)
            {
                newCircle.Expand();
            }
            else if (selectedShape == "Square" && newSquare != null)
            {
                newSquare.Expand();
            }
            else if (selectedShape == "Triangle" && newTriangle != null)
            {
                newTriangle.Expand();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbCircles.SelectedItem == null) return;

            string selectedShape = cbCircles.SelectedItem.ToString();

            if (selectedShape == "Circle" && newCircle != null)
            {
                newCircle.Collapse();
            }
            else if (selectedShape == "Square" && newSquare != null)
            {
                newSquare.Collapse();
            }
            else if (selectedShape == "Triangle" && newTriangle != null)
            {
                newTriangle.Collapse();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(0, -10); // Двигаем вверх
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(0, 10); // Двигаем вниз
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(10, 0); // Двигаем вправо
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MoveSelectedShape(-10, 0); // Двигаем влево
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(1, 0); // Плавное движение вправо
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(-1, 0); // Плавное движение влево
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(0, -1); // Плавное движение вверх
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MoveShapeSmoothly(0, 1); // Плавное движение вниз
        }

        private void MoveSelectedShape(int dx, int dy)
        {
            if (cbCircles.SelectedItem == null) return;

            string selectedShape = cbCircles.SelectedItem.ToString();

            if (selectedShape == "Circle" && newCircle != null)
            {
                newCircle.Move(dx, dy);
            }
            else if (selectedShape == "Square" && newSquare != null)
            {
                newSquare.Move(dx, dy);
            }
            else if (selectedShape == "Triangle" && newTriangle != null)
            {
                newTriangle.Move(dx, dy);
            }
        }

        private void MoveShapeSmoothly(int dx, int dy)
        {
            if (cbCircles.SelectedItem == null) return;

            string selectedShape = cbCircles.SelectedItem.ToString();

            for (int i = 0; i < 100; i++)
            {
                if (selectedShape == "Circle" && newCircle != null)
                {
                    newCircle.Move(dx, dy);
                }
                else if (selectedShape == "Square" && newSquare != null)
                {
                    newSquare.Move(dx, dy);
                }
                else if (selectedShape == "Triangle" && newTriangle != null)
                {
                    newTriangle.Move(dx, dy);
                }

                System.Threading.Thread.Sleep(5);
            }
        }
    }
}