using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Circle : FigureInterface<Circle>
    {
        public Point CenterCoord { get; private set; }

        private float radius;
        public float Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : 1; }
        }

        public Circle(Point centerCoord, float radius)
        {
            CenterCoord = centerCoord;
            Radius = radius;
        }
        public bool Equals(Circle obj)
        {
            return Radius == obj.Radius ? true : false;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public string GetInfo()
        {
            return $"This is circle with radius = {radius}, centre coord ({CenterCoord.X}; {CenterCoord.Y}) and area = {GetArea()} ";
        }
    }
}
