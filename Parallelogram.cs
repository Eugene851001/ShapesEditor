using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Parallelogram: Shape
    {
        private Triangle FirstTriangle, SecondTriangle;

        public Parallelogram(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, x2, "Parallelogram")
        {
            FirstTriangle = new Triangle(x1, y1, x2, y2, x3, y3);
            SecondTriangle = new Triangle(x1, y1, x1 + x3 - x2, y1, x3, y3);
        }

        public Parallelogram(Point point, Point point2, Point point3): base(point, "Parallelogram")
        {
            FirstTriangle = new Triangle(point, point2, point3);
            SecondTriangle = new Triangle(point, new Point(point.X + point3.X - point2.X, point.Y), point3);
        }
        
        public override double GetArea()
        {
            return FirstTriangle.GetArea() * 2;
        }

        public override void Draw(Graphics g)
        {
            DrawShapes.DrawTriangle(FirstTriangle, g);
            DrawShapes.DrawTriangle(SecondTriangle, g);
        }
    }
}
