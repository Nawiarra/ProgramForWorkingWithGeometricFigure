using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Rectangle : FigureInterface <Rectangle>
    {
        private float sideA;
        public float SideA
        {
            get { return sideA; }
            set { sideA = value > 0 ? value : 1; }
        }

        private float sideB;
        public float SideB
        {
            get { return sideB; }
            set { sideB = value > 0 ? value : 1; }
        }
        public bool Equals(Rectangle obj)
        {
            return (SideA == obj.SideA) ? (SideB == obj.SideB) ? true : false : false;
        }

        public double GetArea()
        {
            return SideA * SideB;
        }

        public string GetInfo()
        {
            return $"This is rectangle with sides: A = {SideA}; B = {SideB} and area = {GetArea()}";
        }
    }
}
