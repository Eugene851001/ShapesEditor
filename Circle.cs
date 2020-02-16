using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : Shape
    {
        private int radius;
        public int Radius
        {
            get
            {
                return radius;
            }
        }
        public Circle(int x, int y, int radius) : base(x, y, "Circle")
        {
            this.radius = radius;
        }

        public Circle(Point point, int radius): base(point, "Circle")
        {
            this.radius = radius;
        }
        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }

        public override void Draw(Graphics g)
        {
            DrawShapes.DrawCircle(this, g);
        }
    }
}
