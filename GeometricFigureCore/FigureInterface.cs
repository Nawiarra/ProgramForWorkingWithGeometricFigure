using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigureCore
{
    interface FigureInterface<T>
    {
        bool Equals(T obj);
        double GetArea();
        string GetInfo();
    }
}
