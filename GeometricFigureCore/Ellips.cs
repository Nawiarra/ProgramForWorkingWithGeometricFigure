using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Ellips : FigureInterface<Ellips>
    {
        public Point CenterCoord { get; protected set; }

        private float semiMajorAxis;
        protected float SemiMajorAxis
        {
            get { return semiMajorAxis; }
            set { semiMajorAxis = value > 0 ? value : 1; }
        }

        protected float semiMinorAxis;
        public float SemiMinorAxis
        {
            get { return semiMinorAxis; }
            set { semiMinorAxis = value > 0 ? value : 1; }
        }

        public virtual void CreateEllips(Point centerCoord, float semiMajorAxis, float semiMinorAxis)
        {
            CenterCoord = centerCoord;
            SemiMajorAxis = semiMajorAxis;
            SemiMinorAxis = semiMinorAxis;
        }

        public bool Equals(Ellips obj)
        {
            return SemiMajorAxis == obj.SemiMajorAxis ? (SemiMinorAxis == obj.SemiMinorAxis ? true : false) : false;
        }

        public virtual double GetArea()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }

        public virtual string GetInfo()
        {
            return $"This is ellips with semi major axis = {semiMajorAxis}, semi minor axis = {semiMajorAxis}, centre coord ({CenterCoord.X}; {CenterCoord.Y}) and area = {GetArea()} ";
        }
    }
}
