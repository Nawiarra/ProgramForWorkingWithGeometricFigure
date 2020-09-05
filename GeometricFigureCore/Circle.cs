using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Circle : Ellips
    {
        public virtual void CreateEllips(Point centerCoord, float radius)
        {
            CenterCoord = centerCoord;
            SemiMajorAxis = radius;
            SemiMinorAxis = radius;
        }
        public bool Equals(Circle obj)
        {
            return SemiMajorAxis == obj.SemiMajorAxis ? true : false;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(SemiMajorAxis, 2);
        }

        public override string GetInfo()
        {
            return $"This is circle with radius = {SemiMajorAxis}, centre coord ({CenterCoord.X}; {CenterCoord.Y}) and area = {GetArea()} ";
        }
    }
}
