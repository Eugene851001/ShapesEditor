using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Ellipse: Rectangle
    {

        public Ellipse(int x, int y, int width, int height) : base(x, y, width, height)
        {
            this.height = height;
            this.width = width;
            name = "Ellipse";
        }

        public Ellipse(Point point, int width, int height): base(point, width, height)
        {
            this.height = height;
            this.width = width;
            name = "Ellipse";
        }

        public override double GetArea()
        {
            return Math.PI * width / 2 * height / 2;
        }

        public override void Draw(Graphics g)
        {
            DrawShapes.DrawEllipse(this, g);
        }
    }
}
