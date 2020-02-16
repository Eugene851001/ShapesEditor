using System.Drawing;

namespace Shapes
{
    class Section: Shape
    {
        Point point2;

        public Point[] points
        {
            get
            {
                return new Point[] { point, point2 };
            }
        }
        public override double GetArea()
        {
            return 0;
        }

        public Section(int x1, int y1, int x2, int y2): base(x1, y1, "Section")
        {
            point2 = new Point() { X = x2, Y = y2 };
        }

        public Section(Point point, Point point2): base(point, "Section")
        {
            this.point2 = point2;
        }
        public override void Draw(Graphics g)
        {
            DrawShapes.DrawSection(this, g);
        }
    }
}
