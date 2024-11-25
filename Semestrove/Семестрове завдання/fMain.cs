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
        
        public fMain()
        {
            InitializeComponent();
            circles = new CCircle[100];
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (CircleCount >= 99) 
            {
                MessageBox.Show("Досягнуто межі кількості об'єктів");
                return;
            }

            Graphics graphics = pnMain.CreateGraphics();
            CurrentCircleIndex = CircleCount;

            circles[CurrentCircleIndex] = new CCircle(graphics, pnMain.Width / 2, pnMain.Height / 2, 50);
            circles[CurrentCircleIndex].Show();
            CircleCount++;

            cbCircles.Items.Add("Коло №" + (CircleCount - 1).ToString());
            cbCircles.SelectedIndex = CircleCount - 1;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;
            
            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Hide();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Expand(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Collapse(5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Move(0, -10);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Move(0, 10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Move(10, 0);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            circles[CurrentCircleIndex].Move(-10, 0);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(-1, 0);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, -1);
                System.Threading.Thread.Sleep(5);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CurrentCircleIndex = cbCircles.SelectedIndex;

            if ((CurrentCircleIndex > CircleCount) || (CurrentCircleIndex < 0))
            {
                return;
            }

            for (int i = 0; i < 100; i++)
            {
                circles[CurrentCircleIndex].Move(0, 1);
                System.Threading.Thread.Sleep(5);
            }
        }
    }
}
