using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ShapeList
    {
        private Shape[] shapes;
        int counter;
        int k;
        public ShapeList(int size)
        {
            shapes = new Shape[size];
            counter = 0;
            k = 2;
        }

        public ShapeList(Shape[] shapes)
        {
            this.shapes = new Shape[shapes.Length];
            for (int i = 0; i < shapes.Length; i++)
            {
                this.shapes[i] = shapes[i];
            }
            counter = 0;
            k = 2;
        }

        public void Add(Shape shape)
        {
            if (counter >= shapes.Length)
                    Array.Resize(ref shapes, k * shapes.Length);
            shapes[counter++] = shape;
        }
        public int Length
        {
            get
            {
                return counter;
            }
        }

        public Shape this[int index]
        {
            get
            {
                if (index < 0 || index >= shapes.Length)
                    throw new ArgumentOutOfRangeException();
                return shapes[index];

            }
            set
            {
                if (index < 0 || index >= counter)
                    throw new ArgumentOutOfRangeException();
                shapes[index] = value;
            }
        }

        public void Clear()
        {
            for (int i = 0; i < counter; i++)
            {
                shapes[i] = null;
            }
            counter = 0;
        }
    }
}