using System;
using System.Collections.Generic;
using System.Text;

namespace FirstQuestion
{
    class Square : AbstractPolygon, IPolygon
    {
        double _side;
        public Square(double side)
        {
            _side = side;
            CalcArea();
            CalcPerimeter();
        }

        public void CalcArea()
        {
            _area = _side * _side;
        }

        public void CalcPerimeter()
        {
            _perimeter = _side * 4;
        }
    }
}
