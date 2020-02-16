using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//using Vector = System.Drawing.Point;

namespace Shapes
{

    struct Vector3D
    {
        public double X, Y, Z;
        public Vector3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
    class Triangle: Shape
    {
        private Point point2;
        private Point point3;

        public Point[] points
        {
            get
            {
                return new Point[]{ point, point2, point3};
            }
        }
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1, "Triangle")
        {
            point2 = new Point() { X = x2, Y = y2 };
            point3 = new Point() { X = x3, Y = y3 };
        }

        public Triangle(Point point, Point point2, Point point3): base(point, "Triangle")
        {
            this.point2 = point2;
            this.point3 = point3;
        }

        Vector3D CrossProduct(Vector3D a, Vector3D b)
        {
            return new Vector3D() {X = a.Y * b.Z - a.Z * b.Y, 
                Y = -a.X * b.Z + a.Z * b.X, Z = a.X * b.Y - a.Y * b.X};
        }
        public override double GetArea()
        {
            Vector3D normal = CrossProduct(new Vector3D(point2.X - point.X, point2.Y - point.Y, 0), 
                new Vector3D(point3.X - point.X, point3.Y - point.Y, 0));
            return 0.5 * Math.Sqrt(normal.X * normal.X + normal.Y * normal.Y + normal.Z * normal.Z);
        }

        public override void Draw(Graphics g)
        {
            DrawShapes.DrawTriangle(this, g);
        }
    }
}
