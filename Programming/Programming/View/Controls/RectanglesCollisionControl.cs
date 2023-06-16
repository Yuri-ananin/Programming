using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Controls
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий страницу Rectangles.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Инициализация Point2D, хранящее центр координат.
        /// </summary>
        private Point2D _point2D = new Point2D();

        /// <summary>
        /// Инициализация списка с прямоугольниками на вкладке Rectangles.
        /// </summary>
        private List<Rectangle> _rectanglesList = new List<Rectangle>();

        /// <summary>
        /// Список с данными текущего выбранного прямоугольника.
        /// </summary>
        private Rectangle _currentRectangleInList = new Rectangle();

        // <summary>
        /// Список с нарисованными прямоугольниками на вкладке Rectangles.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Индекс в RectanglesListBox для <see cref="UpdateRectangleInfo(Rectangle)"/>.
        /// </summary>
        private int _selectedIndex = -1;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int length = random.Next(20, 100);
            int width = random.Next(20, 100);
            int startPointX = random.Next(20, RectanglesPanel.Width - 100);
            int startPointY = random.Next(20, RectanglesPanel.Height - 100);

            _point2D = new Point2D(startPointX, startPointY);
            _currentRectangleInList = new Rectangle(length, width, _point2D);
            _rectanglesList.Add(_currentRectangleInList);
            PanelRectanglesListBox.Items.Add(String.Format("{0}:(X={1}; Y={2}; W={3}; H={4})",
            _currentRectangleInList.Id,
            _currentRectangleInList.Center.X,
            _currentRectangleInList.Center.Y,
            _currentRectangleInList.Width,
            _currentRectangleInList.Length));
            Panel currentPanelRectangle = new Panel();

            currentPanelRectangle.Location = new Point((int)_currentRectangleInList.Center.X - width / 2, (int)_currentRectangleInList.Center.Y - length / 2);
            currentPanelRectangle.Size = new Size(width, length);
            currentPanelRectangle.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            currentPanelRectangle.BorderStyle = BorderStyle.FixedSingle;
            RectanglesPanel.Controls.Add(currentPanelRectangle);
            _rectanglePanels.Add(currentPanelRectangle);
            FindCollision();
        }

        /// <summary>
        /// Метод, который определяет, сталиваются ли прямоугольники.
        /// </summary>
        private void FindCollision()
        {
            if (_rectanglesList.Count > 0)
            {
                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    _rectanglePanels[i].BackColor = Color.FromArgb(127, 127, 255, 127);
                }

                for (int i = 0; i < _rectanglesList.Count; i++)
                {
                    for (int j = 0; j < _rectanglesList.Count; j++)
                    {
                        if (_rectanglePanels[i] != _rectanglePanels[j])
                        {
                            if (CollisionManager.IsCollision(_rectanglesList[i], _rectanglesList[j]))
                            {
                                _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                                _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод, который очищает информацию о прямоугольнике.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdRectangleTextBox.Clear();
            XRectangleTextBox.Clear();
            YRectangleTextBox.Clear();
            WidthRectangleTextBox.Clear();
            HeightRectangleTextBox.Clear();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (PanelRectanglesListBox.SelectedIndex != -1)
            {
                int indexPanelRectangle = PanelRectanglesListBox.SelectedIndex;
                _currentRectangleInList = _rectanglesList[indexPanelRectangle];
                PanelRectanglesListBox.Items.RemoveAt(indexPanelRectangle);
                _rectanglesList.Remove(_currentRectangleInList);
                RectanglesPanel.Controls.RemoveAt(indexPanelRectangle);
                _rectanglePanels.RemoveAt(indexPanelRectangle);
                FindCollision();
            }
        }

        private void PanelRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PanelRectanglesListBox.SelectedIndex != -1 &&
                _selectedIndex != PanelRectanglesListBox.SelectedIndex)
            {
                ClearRectangleInfo();
                _selectedIndex = PanelRectanglesListBox.SelectedIndex;
                _currentRectangleInList = _rectanglesList[_selectedIndex];
                IdRectangleTextBox.Text = _currentRectangleInList.Id.ToString();
                XRectangleTextBox.Text = _currentRectangleInList.Center.X.ToString();
                YRectangleTextBox.Text = _currentRectangleInList.Center.Y.ToString();
                WidthRectangleTextBox.Text = _currentRectangleInList.Width.ToString();
                HeightRectangleTextBox.Text = _currentRectangleInList.Length.ToString();

            }
        }

        /// <summary>
        /// Метод, который обновляет информацию о прямоугольнике.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            PanelRectanglesListBox.Items[_selectedIndex] = String.Format("{0}:(X={1}; Y={2}; W={3}; H={4})",
            _currentRectangleInList.Id,
            _currentRectangleInList.Center.X,
            _currentRectangleInList.Center.Y,
            _currentRectangleInList.Width,
            _currentRectangleInList.Length);
            PanelRectanglesListBox.SelectedIndex = _selectedIndex;

        }

        private void YRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (YRectangleTextBox.Text == "")
                {
                    YRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }

                var yRectangle = Convert.ToInt32(YRectangleTextBox.Text);
                _currentRectangleInList.Center.Y = yRectangle;
                _rectanglePanels[_selectedIndex].Location = new Point(_rectanglePanels[_selectedIndex].Location.X, yRectangle - (int)_currentRectangleInList.Length / 2);
                YRectangleTextBox.BackColor = System.Drawing.Color.White;
                FindCollision();
                UpdateRectangleInfo(_currentRectangleInList);
            }
            catch (ArgumentException)
            {
                YRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                YRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                YRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (WidthRectangleTextBox.Text == "")
                {
                    WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var indexPanel = PanelRectanglesListBox.SelectedIndex;
                var widthRectangle = Convert.ToInt32(WidthRectangleTextBox.Text);
                _currentRectangleInList.Width = widthRectangle;
                _rectanglePanels[indexPanel].Width = widthRectangle;
                WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
                FindCollision();
                UpdateRectangleInfo(_currentRectangleInList);
            }
            catch (ArgumentException)
            {
                WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void HeightRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (HeightRectangleTextBox.Text == "")
                {
                    HeightRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var indexPanel = PanelRectanglesListBox.SelectedIndex;
                var heightRectangle = Convert.ToInt32(HeightRectangleTextBox.Text);
                _currentRectangleInList.Length = heightRectangle;
                _rectanglePanels[indexPanel].Height = heightRectangle;
                HeightRectangleTextBox.BackColor = System.Drawing.Color.White;
                FindCollision();
                UpdateRectangleInfo(_currentRectangleInList);
            }
            catch (ArgumentException)
            {
                HeightRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                HeightRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                HeightRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void XRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (XRectangleTextBox.Text == "")
                {
                    XRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var xRectangle = Convert.ToInt32(XRectangleTextBox.Text);
                _currentRectangleInList.Center.X = xRectangle;
                _rectanglePanels[_selectedIndex].Location = new Point(xRectangle - (int)_currentRectangleInList.Width / 2, _rectanglePanels[_selectedIndex].Location.Y);
                XRectangleTextBox.BackColor = System.Drawing.Color.White;
                FindCollision();
                UpdateRectangleInfo(_currentRectangleInList);
            }
            catch (ArgumentException)
            {
                XRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                XRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (OverflowException)
            {
                XRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }
    }
}
