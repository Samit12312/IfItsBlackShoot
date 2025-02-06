using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circle
    {
        protected Point center;
        protected int radius;
        public Circle(Point center, int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public Circle(int x , int y, int radius)
        {
            this.center =  new Point(x, y);
            this.radius = radius;
        }
        public Point GetCenter()
        {
            return this.center;
        }
        public void SetCenter(Point center)
        {
            this.center = center;
        }

        public int GetRadius()
        {
            return this.radius;
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * Math.Pow(this.radius, 2);
        }
        public override string ToString()
        {
            return $"center {base.ToString()}, raduys: {this.radius}";
        }

    }
}
