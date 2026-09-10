using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_And_Overriding_EX2
{
    public class Point
    {
        private int xPos;
        private int yPos;

        public Point() : this(10, 20) { }

        public Point(int _xPos, int _yPos)
        {
            xPos = _xPos;
            yPos = _yPos;
        }

        public void SetPoint(int x, int y)
        {
            xPos = x;
            yPos = y;
        }

        public void ShowPoint()
        {
            Console.WriteLine("(" + xPos + ", " + yPos + ")");
        }
    }
}
