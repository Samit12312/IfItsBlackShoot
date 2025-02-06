using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert x of center");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("insert y of center");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("insert baseof radius");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("insert heigth of the cilinder");
            int height = int.Parse(Console.ReadLine());
            Cylinder cilinder = new Cylinder(x, y, radius, height);
            Console.WriteLine(cilinder.ToString());
        }
    }
}
