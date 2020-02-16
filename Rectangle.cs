using System.Drawing;

namespace Shapes
{
    class Rectangle: Square
    {
        protected int height;

        public int Height
        {
            get 
            {
                return height;
            }
        }
        public Rectangle(int x, int y, int width, int height): base(x, y, width)
        {
            this.height = height;
            this.name = "Rectangle";
        }

        public Rectangle(Point point, int width, int height): base(point, width)
        {
            this.height = height;
            this.name = "Rectnagle";
        }

        public override double GetArea()
        {
            return height * width;
        }

        public override void Draw(Graphics g)
        {
            DrawShapes.DrawRectangle(this, g);
        }
    }
}
