using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Rectangle
    {
        private double _length;
        private double _width;
        public string Color { get; set; }
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
            }
        }
        
       

        public Rectangle()
        {

        }

        public Rectangle(double length, double width, string color)
        {
            this.Length = length;
            this.Width = width;
            this.Color = color;
        }
    }
}
