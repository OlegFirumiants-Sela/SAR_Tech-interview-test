using System;
using System.Collections.Generic;
using System.Text;

namespace FirstQuestion
{
    class Rectangle : AbstractPolygon, IPolygon
    {
        double _width, _length;
        public Rectangle(double width, double length)
        {
            _width = width;
            _length = length;
            CalcArea();
            CalcPerimeter();
        }
        public void CalcArea()
        {
            _area = _width * _length;
        }

        public void CalcPerimeter()
        {
            _perimeter = 2 * (_width + _length);
        }
    }
}
