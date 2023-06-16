using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий RectanglesGroupBox.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {
        /// <summary>
        /// Инициализация массива с прямоугольниками размерностью 5.
        /// </summary>
        private Rectangle[] _rectangles = new Rectangle[5];

        /// <summary>
        /// Массив с данными текущего выбранного прямоугольника.
        /// </summary>
        private Rectangle _currentRectangle = new Rectangle();

        /// <summary>
        /// Инициализация Point2D, хранящее центр координат.
        /// </summary>
        private Point2D _point2D = new Point2D();

        public RectanglesControl()
        {
            InitializeComponent();
            string[] colors = { "White", "Yellow", "Blue", "Green", "Purple" };
            Random random = new Random();
            double[] PointX = new double[5];
            double[] PointY = new double[5];
            for (int i = 0; i < 5; i++)
            {
                var Length = random.Next(1, 25);
                var Width = random.Next(1, 25);
                int randIndex = random.Next(colors.Length);
                var CurrentColors = colors[randIndex];
                _point2D = new Point2D(random.Next(1, 40), random.Next(1, 40));
                _rectangles[i] = new Rectangle(Length, Width, CurrentColors, _point2D);
                PointX[i] = _rectangles[i].Center.X;
                PointY[i] = _rectangles[i].Center.Y;
            }

        }

        /// <summary>
        /// Метод, который выполняет поиск прямоугольника с максимальной шириной 
        /// в списке прямоугольников.
        /// </summary>
        /// <returns>Индекс прямоугольника с максимальной шириной.</returns>
        private int FindRectangleWithMaxWidth()
        {
            double maxWidthRectangle = 0;
            int IndexRectangleWithMaxWidth = 0;
            for (int i = 0; i < RectanglesListBox.Items.Count; i++)
            {
                var currentWidthRectangle = _rectangles[i].Width;
                if (currentWidthRectangle > maxWidthRectangle)
                {
                    maxWidthRectangle = currentWidthRectangle;
                    IndexRectangleWithMaxWidth = i;
                }
            }
            return IndexRectangleWithMaxWidth;
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            PointXTextBox.Text = _currentRectangle.Center.X.ToString();
            PointYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LengthTextBox.Text == "")
                {
                    LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var lengthRectangle = Convert.ToDouble(LengthTextBox.Text);
                _currentRectangle.Length = lengthRectangle;
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (WidthTextBox.Text == "")
                {
                    WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var widthRectangle = Convert.ToDouble(WidthTextBox.Text);
                _currentRectangle.Width = widthRectangle;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindRectangleWithMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }

    }
}
