using MindBoxTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest
{
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        public double Radius { get; set; }

        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        /// <summary>
        /// Площадь круга
        /// </summary>
        public override double Area
        {
            get
            {
                return Radius * Radius * Math.PI;
            }
        }

        /// <summary>
        /// Периметр круга
        /// </summary>
        public override double Perimeter
        {
            get
            {
                return 2 * Radius * Math.PI;
            }
        }

        internal override bool IsCorrectSides()
        {
            return Radius > 0;
        }
    }
}
