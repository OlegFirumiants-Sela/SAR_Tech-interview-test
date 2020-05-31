using System;
using System.Collections.Generic;
using System.Text;

namespace FirstQuestion
{
    public abstract class AbstractPolygon
    {
        protected double _area, _perimeter;

        public double GetArea()
        {
            return _area;
        }
        public double GetPerimeter()
        {
            return _perimeter;
        }

        public virtual string PrintDetails()
        {
            return $"its a {this.GetType().Name}, Area: {_area}, Perimeter: {_perimeter}.";
        }

    }
}
