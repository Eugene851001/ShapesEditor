using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    class Square: Shape
    {
        protected int width;

        public int Width
        {
            get
            {
                return width;
            }
        }
        public Square(int x, int y, int width): base(x, y, "Square")
        {
            this.width = width;
        }

        public Square(Point point, int width): base(point, "Square")
        {
            this.width = width;
        }

        public override double GetArea()
        {
            return width * width;
        }

        public override void Draw(Graphics g)
        {
            DrawShapes.DrawSquare(this, g);
        }
    }
}
