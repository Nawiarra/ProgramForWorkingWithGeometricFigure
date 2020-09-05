using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigureCore;

namespace ProgramForWorkingWithGeometricFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Square customSquare = new Square(10);
            Console.WriteLine(customSquare.GetInfo());


            Circle customCircle = new Circle();
            customCircle.CreateEllips(new Point(0, 0), 6);
            Console.WriteLine(customCircle.GetInfo());

            Rectangle customRectangle = new Rectangle(5, 7);
            Console.WriteLine(customRectangle.GetInfo());

            Console.ReadKey();

        }
    }
}
