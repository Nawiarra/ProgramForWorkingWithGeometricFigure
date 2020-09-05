using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    public class Triangle : FigureInterface<Triangle>
    {
        private static int countOfSidesAndAngles = 3;

        private float[] sides = new float[countOfSidesAndAngles];
        public float[] Sides
        {
            get { return sides; }

            set
            {
                if (value.Length == sides.Length)
                {
                    for (int index = 0; index < value.Length; index++)
                    {
                        sides[index] = value[index] > 0 ? value[index] : 1;
                    }
                }
            }
        }

        private float[] angles = new float[countOfSidesAndAngles];
        public float[] Angles
        {
            get { return angles; }

            set
            {
                if (value.Length == angles.Length)
                {
                    for (int index = 0; index < value.Length; index++)
                    {
                        while (value[index] - 360 > 0)
                        {
                            value[index] = value[index] - 360;
                        }
                        angles[index] = value[index] > 0 ? value[index] : Math.Abs(value[index]);
                    }
                }
            }
        }

        public Triangle(float[] angles, float[] sides)
        {
            for (int i = 0; i < countOfSidesAndAngles; i++)
            {
                Angles[i] = angles[i];

                Sides[i] = sides[i];
            }
        }

        public bool Equals(Triangle obj)
        {
            if ((Sides[0] == obj.Sides[0]) && (Sides[1] == obj.Sides[1]) && (Sides[2] == obj.Sides[2]))
            {
                if ((Angles[0] == obj.Angles[0]) && (Angles[1] == obj.Angles[1]) && (Angles[2] == obj.Angles[2]))
                {
                    return true;
                }
            }
            return false;
        }

        public double GetArea()
        {
            return 0.5 * Sides[0] * Sides[1] * Math.Sin(Angles[0]);
        }

        public string GetInfo()
        {
            return $"This is rectangle with sides: AB = {Sides[0]}, BC = {Sides[1]}, CD = {Sides[2]} and area = {GetArea()} ";
        }
    }
}
