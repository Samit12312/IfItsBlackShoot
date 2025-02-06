using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleApp1
{
    internal class Cylinder : Circle
    {
        int height;
        public Cylinder(int x, int y, int radius, int height):base(x, y, radius)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void SetHeight(int height)
        {
            this.height = height;
        }
        public double GetVolume()
        {
            return base.GetArea() * this.height;
        }
        public double GetArea() { return 2 * base.GetArea() + base.GetPerimiter() * this.height; }
        public override string ToString()
        {
            string str = "The Celinder Details: \n\r ";
            str += $"The center of the Base: + {base.ToString()}";
            str = $"The radius of the Base: {base.GetRadius()} \n\r";
            str = $"The Area of the celinder: {base.GetArea()} \n\r";
            str = $"The Volume of celinder: {GetVolume()}";
            return str;
        }
    }
}
