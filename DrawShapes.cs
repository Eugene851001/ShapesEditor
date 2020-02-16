using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Shapes
{
    static class DrawShapes
    {

        public static void DrawCircle(Shape shape, Graphics g)
        {
            Point pos = shape.Position;
            Circle circle = (Circle)shape;
            g.FillEllipse(new SolidBrush(Color.Red), pos.X - circle.Radius,
                pos.Y - circle.Radius, circle.Radius * 2, circle.Radius * 2);
        }

        public static void DrawEllipse(Shape shape, Graphics g)
        {
            Point pos = shape.Position;
            Ellipse ellipse = (Ellipse)shape;
            g.FillEllipse(new SolidBrush(Color.Red), pos.X, pos.Y,
                ellipse.Width, ellipse.Height);
        }

        public static void DrawSquare(Shape shape, Graphics g)
        {
            Point pos = shape.Position;
            Square square = (Square)shape;
            g.FillRectangle(new SolidBrush(Color.Red), new System.Drawing.Rectangle(pos.X, pos.Y,
                square.Width, square.Width));
        }

        public static void DrawRectangle(Shape shape, Graphics g)
        {
            Point pos = shape.Position;
            Rectangle rect = (Rectangle)shape;
            g.FillRectangle(new SolidBrush(Color.Red), pos.X, pos.Y, rect.Width, rect.Height);
        }

        public static void DrawTriangle(Shape shape, Graphics g)
        {
            Point pos = shape.Position;
            Triangle triangle = (Triangle)shape;
            g.FillPolygon(new SolidBrush(Color.Red), triangle.points);
        }

        public static void DrawSection(Shape shape, Graphics g)
        {
            Point pos = shape.Position;
            Section section = (Section)shape;
            g.DrawLine(new Pen(Color.Red), section.points[0], section.points[1]);
        }
    }
}
