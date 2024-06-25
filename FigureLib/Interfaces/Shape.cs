using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTest.Interfaces
{
    public abstract class Shape
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Метод проверки корректности сторон для конструктора
        /// </summary>
        internal abstract bool IsCorrectSides();
    }
}
