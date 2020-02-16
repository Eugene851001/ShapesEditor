using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shapes;

namespace OOPLaba2
{
    public partial class frmMain : Form
    {
        ShapeList shapes;
        int index;
        Point[] points;
        Type ShapeType;
        delegate Shape ShapeConstructor(Point[] points);
        Dictionary<Type, ShapeConstructor> constructors;
        int RequiredPointsAmount;

        public frmMain()
        {
            InitializeComponent();
            shapes = new ShapeList(5);
            points = new Point[3];
            index = 0;
            RequiredPointsAmount = -1;
            ShapeType = typeof(object);
            constructors = new Dictionary<Type, ShapeConstructor>();
            constructors.Add(typeof(Circle), 
                (Point[] points)=> { return new Circle(points[0], (int)GetDistance(points[0], points[1]));});
            constructors.Add(typeof(Ellipse),
                (Point[] points) => { return new Ellipse(points[0], points[1].X - points[0].X, points[1].Y - points[0].Y);});
            constructors.Add(typeof(Parallelogram),
                (Point[] points) => { points[1].Y = points[2].Y; return new Parallelogram(points[0], points[1], points[2]);});
            constructors.Add(typeof(Shapes.Rectangle),
                (Point[] points) =>{ return new Shapes.Rectangle(points[0], points[1].X - points[0].X, points[1].Y - points[0].Y);});
            constructors.Add(typeof(Section),
                (Point[] points) => { return new  Section(points[0], points[1]); });
            constructors.Add(typeof(Square),
                (Point[] points) => { return new Square(points[0], points[1].X - points[0].X); });
            constructors.Add(typeof(Triangle), 
                (Point[] points)=> { return new Triangle(points[0], points[1], points[2]);});
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        double GetDistance(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Circle);
            RequiredPointsAmount = 2;
            index = 0;
        }

        private void btTriangle_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Triangle);
            RequiredPointsAmount = 3;
            index = 0;
        }

        Point SubPoints(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Square);
            RequiredPointsAmount = 2;
            index = 0;
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            if (index > 2)
                index = 0;
            points[index++] = SubPoints(MousePosition, this.Location);
            points[index - 1].Y -= 25;
            if (index == RequiredPointsAmount)
            {
                ShapeConstructor CreateShape;
                constructors.TryGetValue(ShapeType, out CreateShape);
                shapes.Add(CreateShape(points));
                index = 0;
            }
            Invalidate();
        }

        void DrawPoints(Graphics g)
        {
            int radius = 5;
            for (int i = 0; i < index; i++)
            {
                g.FillEllipse(new SolidBrush(Color.Black), points[i].X - radius, points[i].Y - radius,
                    radius * 2, radius * 2);
            }
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(new SolidBrush(BackColor), this.ClientRectangle);
            DrawPoints(g);
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw(g);
                if (cbShowArea.Checked)
                    g.DrawString(((int)shapes[i].GetArea()).ToString(), new Font("Arial", 12),
                        new SolidBrush(Color.Black), shapes[i].Position);
            }
        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Shapes.Rectangle);
            RequiredPointsAmount = 2;
            index = 0;
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            index = 0;
            Invalidate();
        }

        private void btSection_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Section);
            RequiredPointsAmount = 2;
            index = 0;
        }

        private void btEllipse_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Ellipse);
            RequiredPointsAmount = 2;
            index = 0;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            Invalidate();
        }

        private void btParallelogram_Click(object sender, EventArgs e)
        {
            ShapeType = typeof(Parallelogram);
            RequiredPointsAmount = 3;
            index = 0;
        }

        private void cbShowArea_CheckedChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}