using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Square : FigureInterface<Square>
    {
        private float side;
        public float Side
        {
            get { return side; }

            set { side = value > 0 ? value : 1; }
        }

        public bool Equals(Square obj)
        {
            throw new NotImplementedException();
        }
        public Square(float side)
        {
            Side = side;
        }

        public double GetArea()
        {
            return Math.Pow(Side, 2);
        }

        public string GetInfo()
        {
            return $"This is rectangle with side = {Side} and area = {GetArea()} ";
        }
    }
}
