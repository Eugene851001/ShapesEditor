using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Shapes
{
    abstract class Shape: IDraw
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        protected Point point;
        public Point Position
        {
            get 
            {
                return point;
            }
        }

        public Shape(Point point, string name)
        {
            this.name = name;
            this.point = point;

        }

        public Shape(int x, int y, string name)
        {
            this.name = name;
            point = new Point() { X = x, Y = y };
        }

        public abstract void Draw(Graphics g);
        public abstract double GetArea();
    }
}