using MindBoxTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLib
{
    public class Square : Shape
    {
        /// <summary>
        /// Сторона квадрата
        /// </summary>
        public double Side {  get; set; }

        public Square(double side) : base()
        {
            Side = side;
        }

        /// <summary>
        /// Площадь квадрата
        /// </summary>
        public override double Area
        {
            get
            {
                return Side * Side;
            }
        }

        /// <summary>
        /// Периметр квадрата
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return Side * 4;
            }
        }

        internal override bool IsCorrectSides()
        {
            return Side > 0;
        }
    }
}
