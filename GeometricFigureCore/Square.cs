using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Square : FigureInterface <Square>
    {
        public float Side { get; private set; }

        public bool Equals(Square obj)
        {
            throw new NotImplementedException();
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
