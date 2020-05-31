using System;
using System.Collections.Generic;
using System.Text;

namespace FirstQuestion
{
    class Rhombus : AbstractPolygon, IPolygon
    {
        double _side, _diagonal1, _diagonal2;
        public Rhombus(double side, double diagonal1, double diagonal2)
        {
            if (ValidateInput(side, diagonal1, diagonal2))
            {
                _side = side;
                _diagonal1 = diagonal1;
                _diagonal2 = diagonal2;
                CalcArea();
                CalcPerimeter();
            }
            else
            {
                throw new ArgumentException($"Invalid input for {this.GetType().Name}");
            }
        }


        /// <summary>
        /// Returns whether the input is geometrically valid.
        /// </summary>
        /// <param name="a">side</param>
        /// <param name="p">diagonal1</param>
        /// <param name="q">diagonal2</param>
        /// <returns>boolean</returns>
        private bool ValidateInput(double a, double p, double q)
        {
            return p < a * 2 && q < a * 2;
        }

        public void CalcArea()
        {
            _area = _diagonal1 * _diagonal2 / 2;
        }

        public void CalcPerimeter()
        {
            _perimeter = _side * 4;
        }
    }
}
