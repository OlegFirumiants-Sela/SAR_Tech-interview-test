using System;
using System.Collections.Generic;

namespace FirstQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AbstractPolygon> figures = new List<AbstractPolygon>();
            figures.Add(new Square(2));
            figures.Add(new Rectangle(2, 4));
            try
            {
                figures.Add(new Rhombus(3, 4, 2));
            }
            catch (ArgumentException e) { Console.WriteLine(e.Message); }

            foreach (var item in figures)
            {
                Console.WriteLine(item.PrintDetails());
            }
        }
    }
}
